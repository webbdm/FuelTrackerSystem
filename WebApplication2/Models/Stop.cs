using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Stop
    {
        [Key]
        public int StopID { get; set; }
        public bool ReFuel { get; set; }
        public int Region { get; set; }
        public string StopName { get; set; }
    }
}