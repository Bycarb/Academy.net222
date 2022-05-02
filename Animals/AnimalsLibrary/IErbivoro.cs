using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public interface IErbivoro
    {
        public void LookForGrass();
        public void Eat(Plant plant);
    }
}
