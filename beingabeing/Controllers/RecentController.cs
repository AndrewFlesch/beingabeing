using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using beingabeing.Data;
using beingabeing.Models;
using Microsoft.AspNetCore.Identity;
using beingabeing.Models.ViewModels;

namespace beingabeing.Controllers
{
    public class RecentController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private string _ownerid;

        public RecentController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        

        // GET: Recent
        public async Task<IActionResult> Index()
        {
            List<RecentItemsViewModel> recentitems = new List<RecentItemsViewModel>();
            _ownerid = _userManager.GetUserId(User);

                var dbitems = (from a in _context.Appetite
                                     select new RecentItemsViewModel { RiModeItemID = a.ID, RiCat = a.Cat, RiDateTime = a.DateState, RiType = a.Type, RiOwnerID = a.OwnerID });
                dbitems = dbitems.Where(a => a.RiOwnerID == _ownerid);
                recentitems = dbitems.ToList();
            
            return View(recentitems);
        }

        // GET: Recent/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consuming = await _context.Consumings
                .SingleOrDefaultAsync(m => m.ID == id);
            if (consuming == null)
            {
                return NotFound();
            }

            return View(consuming);
        }

        // GET: Recent/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Recent/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OwnerID,ID,Cat,Type,Vegetable,Meat,Fish,Eggs,Cheese,Yogurt,Fruit,Bread,Rice,Potatoes,Pasta,Beans,Nuts,Oils,Butter,Sweats,Water,Soda,DietSoda,Juice,Beer,Wine,Liquor,Coffee,DateState,Location,Notes")] Consuming consuming)
        {
            if (ModelState.IsValid)
            {
                _context.Add(consuming);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(consuming);
        }

        // GET: Recent/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consuming = await _context.Consumings.SingleOrDefaultAsync(m => m.ID == id);
            if (consuming == null)
            {
                return NotFound();
            }
            return View(consuming);
        }

        // POST: Recent/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OwnerID,ID,Cat,Type,Vegetable,Meat,Fish,Eggs,Cheese,Yogurt,Fruit,Bread,Rice,Potatoes,Pasta,Beans,Nuts,Oils,Butter,Sweats,Water,Soda,DietSoda,Juice,Beer,Wine,Liquor,Coffee,DateState,Location,Notes")] Consuming consuming)
        {
            if (id != consuming.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(consuming);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConsumingExists(consuming.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(consuming);
        }

        // GET: Recent/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consuming = await _context.Consumings
                .SingleOrDefaultAsync(m => m.ID == id);
            if (consuming == null)
            {
                return NotFound();
            }

            return View(consuming);
        }

        // POST: Recent/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var consuming = await _context.Consumings.SingleOrDefaultAsync(m => m.ID == id);
            _context.Consumings.Remove(consuming);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConsumingExists(int id)
        {
            return _context.Consumings.Any(e => e.ID == id);
        }
    }
}
