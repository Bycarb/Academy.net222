using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Common.Entities;

namespace Academy.EntityTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Student("galilei","mario" );
            person.Name = "Mario";
            person.DateBirth = new DateTime(1994, 12, 10);
            Console.WriteLine(person.SayHello());
            Console.WriteLine(((Student)person).SayHello());
            Console.ReadKey();
        }
    }
}
