using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios_Solid.SingleResponsability.Bien
{
    public class Coche
    {
        String marca;
        Coche(String marca) { this.marca = marca; }
        String getMarcachoche() { return marca; }
    }
}
