using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Entities
{
    public class Car
    {
        [Key] public int Id { get; set; }
        [Required] public string Make { get; set; }
        [Display(Name = "Model")]
        [Required] public string CarModel { get; set; }
        public int Year { get; set; }
        public string Engine { get; set; }
        public virtual ICollection<Test> Tests { get; set; }
    }
}
