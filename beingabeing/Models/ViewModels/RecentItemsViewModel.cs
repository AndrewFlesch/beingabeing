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

namespace beingabeing.Models.ViewModels
{
    public class RecentItemsViewModel
    {
        public int RiModeItemID { get; set; }
        public string RiOwnerID { get; set; }
        public string RiType { get; set; }
        public string RiCat { get; set; }
        public DateTime RiDateTime { get; set; }

    }
}