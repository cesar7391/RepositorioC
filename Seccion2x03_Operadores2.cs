using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Seccion2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Si se muestra así, el compilador muestra enteros, por lo que debe agregarse un ".0" para tomarlo como dato tipo flotante
            Console.WriteLine(13 / 2);
            Console.WriteLine(13 / 2.0);

            //Flotante es el menos exacto, de 6 a 9 digitos
            Console.WriteLine(16.8f / 4.1f);

            //Double muestra más dígitos, entre 15 y 17
            Console.WriteLine(16.8 / 4.1);

            //Decimal es el más exacto
            Console.WriteLine(16.8m / 4.1m);

            //NO SE PUEDE DIVIDIR ENTRE 0, PERO SI 0 SOBRE CUALQUIER CANTIDAD, LO QUE DARÁ 0
            Console.WriteLine(0 / 1000);

            //==== RESIDUO O MÓDULO ====
            //Muestra el residuo de la división entre 2 números, se le conoce como resto
            Console.WriteLine(5 % 2);
            Console.WriteLine(5.9 % 3.1);

            /* JERARQUÍA DE OPERACIONES
             * Paréntesis
             * Multiplicación, División, Módulo (se hace la que se encuentra primero)
             * Suma, Resta 
             */
        }
    }
}
