using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios_Solid.InterfaceSegregation.Mal
{
    interface IAve
    {
        void volar();
        void comer();
        void nadar();
    }

    public class Loro:IAve
    {

    
    public  void volar()
    {
        //...
    }
    
    public void comer()
    {
        //...
    }

    
    public void nadar()
    {
        //...
    }
}

public class Pinguino: IAve
{

    
    public void volar()
{
    //...
}


    public void comer()
{
    //...
}


    public void nadar()
{
    //...
}
}
}
