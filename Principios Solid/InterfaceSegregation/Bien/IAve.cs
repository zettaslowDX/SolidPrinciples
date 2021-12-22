using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios_Solid.InterfaceSegregation.Bien
{
    interface IAve
    {
        void comer();
    }
    interface IAveVoladora
    {
        void volar();
    }

    interface IAveNadadora
    {
        void nadar();
    }

    class Loro : IAve, IAveVoladora{

    
    public void volar()
    {
        //...
    }

    
    public void comer()
    {
        //...
    }
}

class Pinguino : IAve, IAveNadadora{

    
    public void nadar()
{
    //...
}


    public void comer()
{
    //...
}
}
}
