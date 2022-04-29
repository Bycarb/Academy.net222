using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazzino
{
    public class Order
    {
        public string IDProduct { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string ToString()
        {
            return this.IDProduct +' '+ this.ProductName +' '+ this.Quantity;
        }

    }
}
