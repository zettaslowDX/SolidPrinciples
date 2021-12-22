using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios_Solid.LiskovSubstitution.Bien
{
    public class Audi : Coche
    {
        
        public override int numAsientos()
        {
            return 25000;
        }
        
        public override int precioMedioCoche()
        {
            return 5;
        }
    }
}
