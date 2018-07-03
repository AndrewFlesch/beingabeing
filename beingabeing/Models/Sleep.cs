﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace beingabeing.Models
{
    public class Sleep
    {
        public string OwnerID { get; set; }
        public int ID { get; set; }
        public string Cat { get; set; } = "Sleep";
        public string Type { get; set; }
        public DateTime WentDown { get; set; }
        public DateTime WokeUp { get; set; }
        public string Notes { get; set; }
        public int Duration { get; set; }
    }
}
