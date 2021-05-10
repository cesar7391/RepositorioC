using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool decision;
            decision = true;

            /* OPERADORES DE COMPARACIÓN
             * == Igual que
             * != Diferente que
             * < Menor que
             * <= Menor o igual que
             * > Mayor que
             * >= Mayor o igual que
             * Todas las comparaciones hechas devuelven un bool que evalua la expresión
             */

            //Esto imprimirá "true"
            Console.WriteLine(6 == 6);

            //Esto imprimirá "false"
            Console.WriteLine(5 == 3);

            //Esto imprimirá "false"
            Console.WriteLine(6 != 6);

            //Esto imprimirá "true"
            Console.WriteLine(5 != 3);
        }
    }
}
