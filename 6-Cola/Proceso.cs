using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Cola
{
    class Proceso
    {
        public int tiempoProceso { get; set; }
        public Proceso siguiente { get; set; }

        public Proceso(int tiempoProceso)
        {
            this.tiempoProceso = tiempoProceso;
        }
    }
}
