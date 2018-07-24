using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace beingabeing.Models.ViewModels
{
    public class HomeViewModel
    {
        [BindProperty]
        public Item Item { get; set; }
        public Appetite Appetite { get; set; }
        public Consuming Consuming { get; set; }
        public EmotionalStates EmotionalStates { get; set; }
        public Exercise Exercise { get; set; }
        public Pills Pills { get; set; }
        public Poop Poop { get; set; }
        public Sickness Sickness { get; set; }
        public Sleep Sleep { get; set; }
        public Stats Stats { get; set; }
        public Social Social { get; set; }
        public Weather Weather { get; set; }
        public Working Working { get; set; }
    }
}
