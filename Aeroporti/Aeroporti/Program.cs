using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroporti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var voloProva = new Volo()
            {
                CittàArrivo = "Roma",
                CittàPartenza = "Bologna",
                OraPart = DateTime.Now,
                OraArr = DateTime.Now,
                GiornoSettimana = "Giovedì",
                IdVolo = "AZ834",
                QtaMerci = 0,
                NumPasseggeri = 380,
                TipoAereo = "F35"
            };
            List<Volo> voloList = SqlReader.GetVoloFromDepCity("Bologna");
            foreach (Volo volo in voloList)
            {
                Console.WriteLine(volo.ToString());
            }
            

        }
    }
}
