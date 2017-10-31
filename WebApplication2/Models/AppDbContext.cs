using System.Collections.Generic;
using System.Data.Entity;

namespace WebbApplication2.Models
{
    public class AppDbContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public AppDbContext() : base("name=fueltrack")
        {
        }

        public System.Data.Entity.DbSet<WebApplication2.Models.Truck> Trucks { get; set; }

        public System.Data.Entity.DbSet<WebApplication2.Models.Stop> Stops { get; set; }

        public System.Data.Entity.DbSet<WebApplication2.Models.Region> Regions { get; set; }

        public System.Data.Entity.DbSet<WebApplication2.Models.FuelEvent> FuelEvents { get; set; }

        public System.Data.Entity.DbSet<WebApplication2.Models.Order> Orders { get; set; }
    }
}