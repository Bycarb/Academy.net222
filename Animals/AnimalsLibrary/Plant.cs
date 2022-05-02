using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Plant
    {
        string Name{ get; set; }
        public abstract bool IsEdible();
        
    }
}
