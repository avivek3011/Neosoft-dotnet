using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class CatApiModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GenderId { get; set; }
        public string Gender { get; set; }
        public DateTime? Dob { get; set; }
        public decimal? legLength { get; set; }
        public decimal? ribCage { get; set; }
        public int? CatTypeId { get; set; }
        public string CatType { get; set; }
        public int? FurTypeId { get; set; }
        public string FurType { get; set; }
    }
}