using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Entities
{
    public class Test
    {
        [Key] public int Id { get; set; }
        [ForeignKey("Car")]
        public int CarId { get; set; }
        public Car Car { get; set; }
        [Display(Name ="Time 0-100km/h")]
        public float? TimeToHundred { get; set; }
        public float? Acceleration { get; set; }
    }
}
