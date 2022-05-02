using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Animals
{
    public class Cinghiale : Animal, ICarnivoro, IErbivoro
    {
        Cinghiale(string name)
        {
            base.Name = name;
        }

        public void LookForPrey() => Console.WriteLine($"Scanning....");
        public void Eat(Animal animal) => Console.WriteLine($"Eating a {animal.ToString()}");
        public void LookForGrass() => Console.WriteLine("Scanning for grass...");
        public void Eat(Plant plant) => Console.WriteLine($"Eating a {plant.ToString()}");
    }
}
