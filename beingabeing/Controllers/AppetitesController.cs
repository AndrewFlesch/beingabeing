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

namespace beingabeing.Controllers
{
    public class AppetitesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public string _ownerid;

        public AppetitesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        

        public IList<Appetite> Appetite { get; set; }

        // GET: Appetites
        public async Task<IActionResult> Index()
        {
            _ownerid = _userManager.GetUserId(User);
            var appetiteitems = from a in _context.Appetite select a;
            appetiteitems = appetiteitems.Where(a => a.OwnerID == _ownerid);
            Appetite = await appetiteitems.ToListAsync();
            return View(Appetite);
        }

        // GET: Appetites/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appetite = await _context.Appetite
                .SingleOrDefaultAsync(m => m.ID == id);
            if (appetite == null)
            {
                return NotFound();
            }

            return View(appetite);
        }

        // GET: Appetites/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Appetites/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OwnerID,ID,Cat,Type,Notes,DateState,Location")] Appetite appetite)
        {
            if (ModelState.IsValid)
            {
                _context.Add(appetite);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(appetite);
        }

        // GET: Appetites/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appetite = await _context.Appetite.SingleOrDefaultAsync(m => m.ID == id);
            if (appetite == null)
            {
                return NotFound();
            }
            return View(appetite);
        }

        // POST: Appetites/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OwnerID,ID,Cat,Type,Notes,DateState,Location")] Appetite appetite)
        {
            if (id != appetite.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(appetite);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppetiteExists(appetite.ID))
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
            return View(appetite);
        }

        // GET: Appetites/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appetite = await _context.Appetite
                .SingleOrDefaultAsync(m => m.ID == id);
            if (appetite == null)
            {
                return NotFound();
            }

            return View(appetite);
        }

        // POST: Appetites/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var appetite = await _context.Appetite.SingleOrDefaultAsync(m => m.ID == id);
            _context.Appetite.Remove(appetite);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AppetiteExists(int id)
        {
            return _context.Appetite.Any(e => e.ID == id);
        }
    }
}
