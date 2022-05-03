using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticaLibrary
{
    public class Corriere
    {
        public List<Spedizione> Spedizioni { get; private set; }
        public Corriere()
        {
            Spedizioni = new List<Spedizione>();
        }
        public void AddSpedizione(Spedizione spedizione)
        {
            Spedizioni.Add(spedizione);
        }
        public new string ToString()
        {
            string result = "Elenco delle spedizioni del corriere:\n";
            foreach (Spedizione spedizione in Spedizioni)
            {
                result += spedizione.ToString() + '\n';
            }
            return result;
        }
        //sommo semplicemente i volumi come se i pacchi fossero liquidi
        public double TotalIngombro()
        {
            double total = 0;
            foreach (Spedizione spedizione in Spedizioni)
            {
                total += spedizione.Ingombro();
            }
            return total;
        }
    }
}
