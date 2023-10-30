using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucle3.Servicios;
internal class ImplementacionOperacion : InterfazOperacion //Conecto los servicios
{
   
        public int bucle2(int valor) // Int que contiene el numero anterior y que se usará en el for
    {
       

        for (int i = 1; i < valor; i++)
        {
            for (int t = 1; t <= i; t++)
            {
                Console.Write("" + t);
            }
            Console.WriteLine("");
        }
        return valor;
    }
}

  
