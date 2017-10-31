using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class TruckDispatchEvent
    {
        [Key]
        public int TruckDispatchEventID { get; set; }
        public int Truck { get; set; }
        public int Stop { get; set; }
    }
}