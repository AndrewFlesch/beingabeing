﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace beingabeing.Models
{
    public class Poop
    {
        public string OwnerID { get; set; }
        public int ID { get; set; }
        public string Cat { get; set; } = "Poop";
        public string Type { get; set; }
        public string Color { get; set; }
        public string Density { get; set; }
        public string Notes { get; set; }
    }
}
