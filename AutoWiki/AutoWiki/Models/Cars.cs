using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AutoWiki.Models
{
    public class Cars
    {
        public int ID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Engine { get; set; }
        public string HorsePower { get; set; }
        public string Coupe { get; set; }
        public int MaxSpeed { get; set; }
    }
    public class CarsDBContent : DbContext
    {
        public DbSet<Cars> Car { get; set; }
    }
}