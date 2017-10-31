using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Region
    {
        [Key]
        public int RegionID { get; set; }
        public string RegionName { get; set; }
    }
}