using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DatabaseLayer.Entities
{
    public class Test
    {
        [Key] public int Id { get; set; }
        [ForeignKey("Car")]
        public Car Car { get; set; }
        public float TimeToHundred { get; set; }
    }
}
