using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BankRateMVC.Models
{
    public class RatingInputs
    {
        [Required]
        [Display(Name = "Input 1")]
        public decimal Input1 { get; set; }
        [Required]
        [Display(Name = "Input 2")]
        public decimal Input2 { get; set; }
        [Required]
        [Display(Name = "Input 3")]
        public decimal Input3 { get; set; }
        [Required]
        [Display(Name = "Input 4")]
        public decimal Input4 { get; set; }
        [Required]
        [Display(Name = "Input 5")]
        public decimal Input5 { get; set; }
        [Required]
        [Display(Name = "Input 6")]
        public decimal Input6 { get; set; }
        [Required]
        [Display(Name = "Input 7")]
        public decimal Input7 { get; set; }
        [Required]
        [Display(Name = "Input 8")]
        public decimal Input8 { get; set; }
        [Required]
        [Display(Name = "Input 9")]
        public decimal Input9 { get; set; }
        [Required]
        [Display(Name = "Input 10")]
        public decimal Input10 { get; set; }

    }


}
