using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucle3.Servicios
{
    internal class MenuImplementacion : MenuInterfaz //Conecto los servicios
    {
        /// <summary>
        /// Método que pide y guarda el número del usuario
        /// 301023 - chi
        /// </summary>
        /// <returns></returns>
        public int bucle()
        {
            int numero; //Creo un int donde se guardatá el número del user
            Console.WriteLine("Escribe un numero");
            numero = Convert.ToInt32(Console.ReadLine()); //Lo convierto en 32 Bits


            return numero;

        }


    }
}