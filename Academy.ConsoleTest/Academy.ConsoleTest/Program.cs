using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Common;

namespace Academy.ConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result;
            bool isParsed = int.TryParse(args[0], out result); //out consente di passare una primitiva per reference
            Console.WriteLine(result);
            Console.WriteLine(CommonConstants.AcademyName);


            First2Days(args);
        }

        private static void First2Days(string[] args)
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

            double a = 123.1234;
            string stUS = a.ToString("C");
            string stIT = a.ToString("C", CultureInfo.GetCultureInfo("it-IT"));
            Console.WriteLine("{0:f4} {1} {2}", a, stUS, stIT);

            DateTime date = DateTime.Now;
            TimeSpan elapsed = DateTime.Now - date;
            Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-US")));
            Console.WriteLine("Time elapsed " + elapsed.ToString());



            Console.ReadKey();
        }
    }
}
