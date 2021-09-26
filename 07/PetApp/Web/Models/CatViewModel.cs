using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Web.Models
{
    public enum Gender
    {
        Male=1, Female
    }
    public class CatViewModel
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage ="Name cannot be blank")]
        [StringLength(maximumLength: 50,ErrorMessage ="name of the cat should be between 2 to 50 characters", MinimumLength =2)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Gender cannot be blank")]
        [DisplayName("Gender")]
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        [Required(ErrorMessage = "Birthday cannot be blank")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DisplayName("Birthday")]
        public DateTime? Dob { get; set; }
        [DisplayName("Leg length (cms)")]
        public decimal? legLength { get; set; }
        [DisplayName("Rib length (cms)")]
        public decimal? ribLength { get; set; }
        [Required(ErrorMessage = "Please select cat type")]
        [DisplayName("Cat type")]
        public int? CatType { get; set; }
        [Required(ErrorMessage = "Please select fur type")]
        [DisplayName("Fur type")]
        public int? FurType { get; set; }

    }
}