// See https://aka.ms/new-console-template for more information
using TryCatchExample;

var firstNumber = 10;
var secondNumber = 0;
var calculator = new Calculator();
try
{
    var result = calculator.DIvision(firstNumber, secondNumber);
    Console.WriteLine($"Il risultato di {firstNumber} diviso {secondNumber} è {result} ");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Fine Esecuzione");
}

Console.ReadLine();
