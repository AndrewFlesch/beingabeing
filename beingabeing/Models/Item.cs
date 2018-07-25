using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace beingabeing.Models
{
    public class Item
    {
        public string OwnerID { get; set; }
        public int ID { get; set; }
        public string Cat { get; set; }
        public string Type { get; set; }
        public string Notes { get; set; }
        public DateTime DateState { get; set; }
        public string Location { get; set; }

        public string With { get; set; }
        public string Where { get; set; }

        public string Intensity { get; set; }
        public int? Duration { get; set; }

        public string Dose { get; set; }

        public int? Vegetable { get; set; }
        public int? Meat { get; set; }
        public int? Fish { get; set; }
        public int? Eggs { get; set; }
        public int? Cheese { get; set; }
        public int? Yogurt { get; set; }
        public int? Fruit { get; set; }
        public int? Bread { get; set; }
        public int? Rice { get; set; }
        public int? Potatoes { get; set; }
        public int? Pasta { get; set; }
        public int? Beans { get; set; }
        public int? Nuts { get; set; }
        public int? Oils { get; set; }
        public int? Butter { get; set; }
        public int? Sweats { get; set; }
        public int? Water { get; set; }
        public int? Soda { get; set; }
        public int? DietSoda { get; set; }
        public int? Juice { get; set; }
        public int? Beer { get; set; }
        public int? Wine { get; set; }
        public int? Liquor { get; set; }
        public int? Coffee { get; set; }
    }
}
