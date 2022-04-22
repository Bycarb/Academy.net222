using Academy.Common.Entities;
using System;

namespace Academy.EntityTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Student("galilei", "mario");
            person.Name = "Mario";
            person.DateBirth = new DateTime(1994, 12, 10);
            Console.WriteLine(person.SayHello());
            Console.WriteLine(((Student)person).SayHello());
            Console.ReadKey();
        }
    }
}
