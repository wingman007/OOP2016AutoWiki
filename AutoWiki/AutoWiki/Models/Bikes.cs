using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AutoWiki.Models
{
    public class Bikes
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Category { get; set; }
        public int Engine { get; set; }
        public int Power { get; set; }
        public string Gearbox { get; set;}
        public string Fuel { get; set; }
        public int Fuelcapacity { get; set; }
        public int Topspeed { get; set; }

    }

    public class BikesDBContent : DbContext
    {
        public DbSet<Bikes> Bike { get; set; }
    }
}