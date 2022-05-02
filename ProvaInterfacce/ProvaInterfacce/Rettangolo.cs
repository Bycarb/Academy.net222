using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaInterfacce
{
    internal class Rettangolo : IPoligono
    {
        private readonly double Lato1;
        private readonly double Lato2;
        public Rettangolo(double lato1, double lato2)
        {
            this.Lato1 = lato1;
            this.Lato2 = lato2;
        }
        public double Perimetro() => Lato1*2 + Lato2*2;
    }
}
