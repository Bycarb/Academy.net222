// See https://aka.ms/new-console-template for more information
using FIleHelper;

var fileHelper = new FileHelper(@"rubrica.csv");
var rub = fileHelper.ReadAllContact();
foreach(var contact in rub)
{
    Console.WriteLine($"Nome: {contact.nome}; Cognome: {contact.cognome}; Telefono:{contact.telefono}");
}
Console.WriteLine("Inserici il nome");
var name = Console.ReadLine();
Console.WriteLine("Inserici il cognome");
var surname = Console.ReadLine();
Console.WriteLine("Inserici il telefono");
var phone = Console.ReadLine();
Console.WriteLine("Inserici l'indirizzo");
var address = Console.ReadLine();

var contactNew = new Contact
{
    nome = name,
    cognome = surname,
    telefono = phone,
    indirizzo = address
};
fileHelper.AddContact(contactNew);