using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazzino
{
    public class Product
    {
        public string IdCatalogue { get; set; }
        public string Id { get; set; }
        public string ProductName {get; set; }
        public double Price { get; set; }

        public string ToString()
        {
            return this.IdCatalogue +' '+ this.Id + ' ' + this.ProductName +' '+ this.Price;
        }

    }
}
