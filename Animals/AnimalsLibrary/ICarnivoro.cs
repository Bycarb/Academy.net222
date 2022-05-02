using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public interface ICarnivoro
    {
        public void LookForPrey();
        public void Eat(Animal prey);
    }
}
