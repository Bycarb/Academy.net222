using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazzino
{
    public class OrderFileHandler
    {
        private readonly string Path;

        public OrderFileHandler(string path)
        {
            Path = path;
        }

        public List<Order> ReadOrders()
        {
            List<Order> orders = new List<Order>();
            using var stream = new StreamReader(Path);
            var header = "idprodotto;nomeprodotto;quantità";
            string? firstLine = stream.ReadLine();
            if (firstLine != header)
            {
                throw new Exception("File non conforme!");
            }
            while (!stream.EndOfStream)
            {
                string row = stream.ReadLine().Trim();
                var entries = row.Split(";");
                var order = new Order
                {
                    IDProduct = entries[0],
                    ProductName = entries[1],
                    Quantity = int.Parse(entries[2])

                };
                orders.Add(order);
            }
            return orders;
        }

        public void AddOrder(Order order)
        {
            using var stream = new StreamWriter(Path, true);
            stream.WriteLine($"{order.IDProduct};{order.ProductName};{order.Quantity}");
        }
    }
}
