using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Truck
    {
        [Key]
        public int TruckID { get; set; }
        public int CurrentStop { get; set; }
        public int NextStop { get; set; }
        public int DriverId { get; set; }
        public int CurrentFuel { get; set; }
        public int Region { get; set; }
    }
}