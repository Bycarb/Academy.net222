using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaInterfacce
{
    internal class Quadrato : IPoligono
    {
        private readonly double Lato;
        public Quadrato(double lato)
        {
            Lato = lato;
        }
        public double Perimetro()
        {
            return Lato * 4;
        }
    }
}
