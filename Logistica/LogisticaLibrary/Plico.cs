using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticaLibrary
{
    public class Plico : Spedizione
    {
        public double Height { get; private set; }
        public double Width { get; private set; }
        public Plico(int id, string sender, string receiver, double value, double height, double width) : base(id, sender, receiver, value)
        {
            Height = height;
            Width = width;
        }

        public override double Ingombro() => 0;
        
    }
}
