using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios_Solid.OpenClose.Mal
{
    public class Coche
    {
        private string marca;
        public string Marca { get; set; }
        public Coche (string marca) { this.marca = marca; }
        public string getMarcaCoche() { return marca; }
        
    }


}

