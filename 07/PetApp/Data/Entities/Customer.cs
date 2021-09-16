namespace Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        public int id { get; set; }

        [StringLength(225)]
        public string Namee { get; set; }

        [StringLength(225)]
        public string Zipcode { get; set; }

        [StringLength(225)]
        public string Email { get; set; }
    }
}
