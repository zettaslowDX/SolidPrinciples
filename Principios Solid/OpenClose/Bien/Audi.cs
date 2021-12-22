using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios_Solid.OpenClose.Bien
{
     class Audi:Coche
    {
        override
        public int precioMedioCoche() { return 25000; }
    }
}
