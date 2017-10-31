using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class FuelEvent
    {
        [Key]
        public int EventID { get; set; }
        public int FuelUsed { get; set; }
        public int Truck { get; set; }
        public int Order { get; set; }
        public int Location { get; set; }
        public DateTime Time { get; set; }
    }
}