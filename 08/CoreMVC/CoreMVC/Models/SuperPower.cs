using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVC.Models
{
    public class SuperPower
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SuperHeroId { get; set; }
    }
}
