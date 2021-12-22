using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios_Solid.LiskovSubstitution.Mal
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
            imprimirNumAsientos(arrayCoches);
        }
        public static void imprimirNumAsientos(Coche[] arrayCoches)
        {
            foreach (Coche coche in arrayCoches)
            {
                if (coche.GetType() == typeof(Renault))
                    Console.WriteLine("num asientos 4");
                if (coche.GetType() == typeof(Audi))
                    Console.WriteLine("num asientos 5");
                if (coche.GetType() == typeof(Mercedes))
                    Console.WriteLine("num asientos 6");
            }
        }
    }
}
