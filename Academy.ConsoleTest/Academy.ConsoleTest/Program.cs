using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.ConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString3 = null;
            string myString2 = "test ";
            myString3 = string.Join("-", args);

            var result = myString2 + myString3;
            result = string.Concat(myString2, myString3);

            bool hasC = myString3.Contains("c");
            int indexA = myString3.IndexOf("a");

            Console.WriteLine(result);
            Console.WriteLine(Constants.aString);

            string[] myStringArr = new string[] { "a", "b", "c" };
            Console.WriteLine(myStringArr[1]);

            Console.ReadKey();
        }
    }
}
