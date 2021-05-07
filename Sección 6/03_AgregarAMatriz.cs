using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion6
{
    class Program
    {
        static void Main(string[] args)
        {
            byte i; //Variable del control del ciclo
            String[] nombres = new string[3];

            //Colocamos valores en los 3 elementos
            nombres[0] = "Sandra";
            nombres[1] = "Pedro";
            nombres[2] = "Carmen";

            for(i=0; i < nombres.Length; i++)
            {
                Console.Write("Ingresa el valor para el índicie [{0}] ", i);
                nombres[i] = Console.ReadLine();
            }

            //Mostramos los valores que se agregan
            for (i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i]);
            }
        }
    }
}
