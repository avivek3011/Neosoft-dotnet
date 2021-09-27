using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVC.Models
{
    public class SuperHero
    {
        [DisplayName("Id")]
        public int id { get; set; }
        [DisplayName("Name")]
        [Required]
        public string name { get; set; }
        [DisplayName("Alias")]
        [Required]
        public string alias { get; set; }
        [DisplayName("Place of hiding")]
        public string hideOuts { get; set; }
        [DisplayName("Super Powers")]
        public List<SuperPower> superPowers { get; set; }

        /*public static IEnumerable<SuperHero> getDummySuperHeros()
        {
            List<SuperHero> superHeroes = new List<SuperHero>()
            {
                new SuperHero(){id=1, name="Peter Parker", alias="Superman", hideOuts="NYC apartment"},
                new SuperHero(){id=2, name="Tony Stark", alias="Ironman", hideOuts="Dumpyard"},
                new SuperHero(){id=3, name="Thor", alias="Thor", hideOuts="Asgard"},
                new SuperHero(){id=4, name="Gangadhar", alias="Shaktiman", hideOuts="tenant in a village"}
            };
            return superHeroes;
        }*/
    }
}
