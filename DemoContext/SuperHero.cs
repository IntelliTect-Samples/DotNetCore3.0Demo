using System;
using System.Collections.Generic;
using System.Text;

namespace DemoContext
{
    public class SuperHero
    { 
        public int SuperHeroId { get; set; }

        public string Name { get; set; }
        public string SuperName { get; set; }

        public bool StartsWith(string letters)
        {
            return SuperName.StartsWith(letters);
        }

    }
}
