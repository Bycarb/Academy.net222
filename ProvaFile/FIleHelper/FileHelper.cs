using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIleHelper
{
    public class FileHelper
    {
        private readonly string Path;
        public FileHelper(string path)
        {
            Path = path;
        }
        public void AddContact(Contact contact)
        {
            var result = $"{contact.nome}; { contact.cognome}; {contact.telefono}; {contact.indirizzo}";
            using (var stream = new StreamWriter(Path, true))
            {
                stream.WriteLine(result);
            }
        }

        public List <Contact> ReadAllContact()
        {
            List<Contact> contacts = new List<Contact>();
            using (var stream = new StreamReader(Path))
            {
                var header = "nome;cognome;telefono;indirizzo";
                string firstLine = stream.ReadLine();
                if(firstLine != header)
                {
                    throw new Exception("File non conforme!");
                }
                while (!stream.EndOfStream)
                {
                    string row = stream.ReadLine().Trim();
                    var splitted = row.Split(";");
                    var contact = new Contact
                    {
                        nome = splitted[0],
                        cognome = splitted[1],
                        telefono = splitted[2],
                        indirizzo = splitted[3]
                    };
                    contacts.Add(contact);
                }
            }
            return contacts;
        }
    }
}
