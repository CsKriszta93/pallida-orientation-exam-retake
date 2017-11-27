using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clothing.Models
{
    public class Clothes
    {
        public long Id { get; set; }
        public string item_name { get; set; } 
        public string manufacturer { get; set; }
        public string category { get; set; }
        public string size { get; set; }
        public double unit_price { get; set; }
    }
}
