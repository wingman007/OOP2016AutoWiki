using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AutoWiki.Models
{
    public class News
    {
        public int ID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string About { get; set; }

    }
}