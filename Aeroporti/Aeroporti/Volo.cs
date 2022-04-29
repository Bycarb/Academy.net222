using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroporti
{
    public class Volo
    { 
        public string IdVolo { get; set; }
        public string GiornoSettimana { get; set; }
        public string CittàPartenza { get; set; }
        public string CittàArrivo { get; set; }
        public DateTime OraPart { get; set; }
        public DateTime OraArr { get; set; }
        public string TipoAereo { get; set; }
        public int NumPasseggeri { get; set; }
        public int QtaMerci { get; set; }
        public override string ToString() 
        {
            return String.Format("IdVolo: {0}\nGiornoSett: {1}\nCiattaPart: {2}\nOraPart: {3}\nCittaArr:" +
                " {4}\nOraArr: {5}\nTipoAereo: {6}\nNumPasseggeri: {7}\nQtaMerci: {8}\n\n",
                IdVolo, GiornoSettimana, CittàPartenza, OraPart, CittàArrivo, OraArr, TipoAereo, NumPasseggeri, QtaMerci);
        }
    }

}
