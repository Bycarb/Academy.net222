// See https://aka.ms/new-console-template for more information

using Academy.Common.Entities;

Person customer = new Person("Mario Rossi", "MRARSS89B38D428U", false);
Car car = new Car()
{
    DailyPrice = 20,
    IsForNewDriver = true,
    Model = "Fiat Panda",
    Plate = "DJ283IF"
};
Rental rental = new Rental(1, DateTime.Now, 10, customer, car);
Console.WriteLine(rental.ToString());

