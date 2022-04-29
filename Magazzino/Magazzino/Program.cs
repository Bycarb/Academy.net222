using Magazzino;

ProductFileHandler catalogo = new ProductFileHandler(@"CSV\Catalogo.csv");
OrderFileHandler ordini = new OrderFileHandler(@"CSV\Ordini.csv");

Product product = new Product
{
    Id = "pd1394",
    IdCatalogue = "ct2",
    ProductName = "Televisore Sony h435",
    Price = 13.40
};
Order order = new Order
{
    IDProduct = "pd1234",
    ProductName = "Televisore samsung 4f829",
    Quantity = 10
};

//catalogo.AddProduct(product);
//ordini.AddOrder(order);
Console.WriteLine("Elenco dei prodotti in catalogo: ");
var prodInCatalogo = catalogo.ReadProducts();
foreach (var prod in prodInCatalogo)
    Console.WriteLine(prod.ToString());

Console.WriteLine("\nElenco degli ordini effettuati: ");
var ordiniSalvati = ordini.ReadOrders();
foreach (var ordine in ordiniSalvati)
    Console.WriteLine(ordine.ToString());
