﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace beingabeing.Models
{
    public class Exercise
    {
        public string OwnerID { get; set; }
        public int ID { get; set; }
        public string Cat { get; set; } = "Exercise";
        public string Type { get; set; }
        public string Intensity { get; set; }
        public int Duration { get; set; }
        public string Notes { get; set; }
        public DateTime DateState { get; set; }
    }
}
