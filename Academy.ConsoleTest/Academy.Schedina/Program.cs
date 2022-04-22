// See https://aka.ms/new-console-template for more information

int a, b;
Console.WriteLine("Inserisci goal prima squadra:");
string userInput = Console.ReadLine();
a = Convert.ToInt32(userInput);
Console.WriteLine("Inserisci goal seconda squadra:");
userInput = Console.ReadLine();
b = Convert.ToInt32(userInput);

Console.WriteLine(Esito(a, b));

static string Esito(int a, int b)
{
    string result = String.Empty;
    if (a == b)
    {
        result = "X";
    }
    else if (a > b)
    {
        result = "1";
    }
    else
    {
        result = "2";
    }
    return result;
}

static void Esito2(int a, int b)
{
    Console.WriteLine(Esito(a, b));
}
