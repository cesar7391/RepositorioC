using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Iteración anidada, mostrar las tablas de multiplicar del 1 al 10
            int i; //Variable para el bucle exterior
            int j; //Variable para el bucle anidado
            int resultado;

            for(i=1; i <= 10; i++)
            {
                Console.WriteLine("==== TABLA DEL {0} ====", i); //Muestra la tabla actual

                for(j=1; j <= 10; j++)
                {
                    resultado = i * j;
                    Console.WriteLine("{0} * {1} = {2}", i, j, resultado);                    
                }
            }
        }
    }
}
