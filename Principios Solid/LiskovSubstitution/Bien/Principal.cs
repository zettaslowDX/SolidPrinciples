using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios_Solid.LiskovSubstitution.Bien
{
    public class Principal
    {
        public static void Main(string[] args)
        {
            Coche[] arrayCoches =
            {
                new Renault(),
                new Audi(),
                new Mercedes()
            };
            imprimirPrecioMedioCoche(arrayCoches);

        }
        public static void imprimirPrecioMedioCoche(Coche[] arrayCoches)
        {
            foreach (Coche coche in arrayCoches)
            {
                Console.WriteLine(coche.precioMedioCoche());
            }
        }
        public static void imprimirNumAsientos(Coche[] arrayCoches)
        {
            foreach(Coche coche in arrayCoches)
            {
                Console.WriteLine(coche.numAsientos());
            }
        }
    }
}
