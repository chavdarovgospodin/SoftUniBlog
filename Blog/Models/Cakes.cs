using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TastyCakes.Models
{
    public class Cakes
    {
        public int CakesID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public string CakeImage
        {
            get { return Name.Replace(" ", string.Empty) + ".jpg"; }
        }
    }
}