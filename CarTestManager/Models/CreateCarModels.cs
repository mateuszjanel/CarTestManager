using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarTestManager.Models
{
    public class CreateCarModels
    {
        [Required]
        public string Make { get; set; }
        [Required]
        public string CarModel { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Engine { get; set; }
        public float? FuelConsumingPer100km { get; set; }
    }
}