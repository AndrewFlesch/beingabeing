﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace beingabeing.Models
{
    public class Pills
    {
        public string OwnerID { get; set; }
        public int ID { get; set; }
        public string Cat { get; set; } = "Medicine";
        public string Type { get; set; }
        public string Dose { get; set; }
        public string Notes { get; set; }
        public DateTime DateState { get; set; }
    }
}
