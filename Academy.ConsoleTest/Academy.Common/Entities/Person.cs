using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Common.Entities
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime DateBirth { get; set; }

        public Car car { get; set; }

        public int getAge()
        {
            TimeSpan time = DateTime.Now - DateBirth;
            int age = time.Days / 365;
            return age;
        }
    }
}
