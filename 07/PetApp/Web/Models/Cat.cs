using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class Cat
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Gender { get; set; }
        [DisplayName("Birthday")]
        [DataType(DataType.Date, ErrorMessage = "Date only")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Dob { get; set; }
        [DisplayName("Leg length (cms)")]
        public decimal? legLength { get; set; }
        [DisplayName("Rib cage (cms)")]
        public decimal? ribCage { get; set; }
        [DisplayName("Cat type")]
        public string CatType { get; set; }
        [DisplayName("Fur Type")]
        public string FurType { get; set; }
    }
}