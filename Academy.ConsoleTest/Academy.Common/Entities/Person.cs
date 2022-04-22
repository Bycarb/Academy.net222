using System;

namespace Academy.Common.Entities
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime DateBirth { get; set; }

        protected string StudyTitle { get; set; }
        public string CF { get; set; }
        public bool IsNewdriver { get; set; }

        public Car car { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public Person(String name, string CF, bool IsNewdriver)
        {
            this.Name = name;
            this.CF = CF;
            this.IsNewdriver = IsNewdriver;

        }

        public int getAge()
        {
            TimeSpan time = DateTime.Now - DateBirth;
            int age = time.Days / 365;
            return age;
        }

        public virtual string SayHello()
        {
            return "I'm a person";
        }
    }
}
