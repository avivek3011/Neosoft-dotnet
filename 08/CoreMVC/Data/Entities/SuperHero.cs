using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("superhero")]
    public class SuperHero
    {
    
        // if EFCore generator finds a property named Id or clasnameId it is going to generate it as a primary key
        //[Key] use this annotation if the name is different from the convention
        [Column("id")]
        public int Id { get; set; }
        [StringLength(50)]
        [Column("name")]
        public string Name { get; set; }
        [StringLength(50)]
        [Required]
        [Column("alias")]
        public string Alias { get; set; }
        [StringLength(150)]
        [Column("hideout")]
        public string HideOuts { get; set; }
        public ICollection<SuperPower> SuperPowers { get; set; }

    }
}
