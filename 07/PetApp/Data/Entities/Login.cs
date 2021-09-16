namespace Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Login")]
    public partial class Login
    {
        public int id { get; set; }

        public int? CustomerId { get; set; }

        [StringLength(225)]
        public string UserName { get; set; }

        [StringLength(225)]
        public string Password { get; set; }
    }
}
