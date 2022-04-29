using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazzino
{
    internal class ProductFileHandler
    {
        private readonly string Path;

        ProductFileHandler (string path)
        {
            Path = path;
        }

        public List<Product> ReadProducts()
        {
            List<Product> products = new List<Product>();
            using var stream = new StreamReader(Path);
            var header = "idcatalogo;idprodotto;prezzo";
            string firstLine = stream.ReadLine();
            if (firstLine != header)
            {
                throw new Exception("File non conforme!");
            }
            while (!stream.EndOfStream)
            {
                string row = stream.ReadLine().Trim();
                var entries = row.Split(";");
                var product = new Product
                {
                    IdCatalogue = entries[0],
                    Id = entries[1],
                    Price = int.Parse(entries[2])

                };
                products.Add(product);
            }
            return products;
        }

        public void AddProduct(Product product)
        {
                using var stream = new StreamWriter(Path, true);
                stream.WriteLine($"{product.IdCatalogue};{product.Id};{product.Price}");
        }
    }
}
