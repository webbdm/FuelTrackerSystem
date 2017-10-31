using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public int StopLocation { get; set; }
        public int Region { get; set; }
    }
}