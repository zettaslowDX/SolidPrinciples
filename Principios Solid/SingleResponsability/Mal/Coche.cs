using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios_Solid.SingleResponsability.Mal
{
    internal class Coche
    {
        String marca;
        Coche(String marca) { this.marca = marca; }
        string getmarcacoche() { return marca; }
        void guardarCocheDB (Coche coche)
    }
}
