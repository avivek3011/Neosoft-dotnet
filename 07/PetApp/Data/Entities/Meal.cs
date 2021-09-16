namespace Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Meal
    {
        public int Id { get; set; }

        public int FoodType { get; set; }

        public DateTime Time { get; set; }

        public int catid { get; set; }

        public virtual Cat Cat { get; set; }

        public virtual FoodType FoodType1 { get; set; }
    }
}
