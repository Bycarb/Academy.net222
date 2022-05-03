// See https://aka.ms/new-console-template for more information

using LogisticaLibrary;

Corriere tnt = new Corriere();
tnt.AddSpedizione(new Pacco(12, "Mario Rossi", "Brambilla Fumagalli", 10.99, 10, 10, 15));
tnt.AddSpedizione(new Pacco(13, "Frodo Baggins", "Luke Skywalker", 19.95, 10, 10, 100));
tnt.AddSpedizione(new Plico(14, "Bojack Horseman", "Peter Griffin", 5.50, 20, 25));

Console.WriteLine(tnt.ToString());
Console.WriteLine($"Ingombro totale: {tnt.TotalIngombro()}");