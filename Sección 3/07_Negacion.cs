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
            /*OPERADORES LÓGICOS
             * ! Negación lógica
             * & AND lógico
             * | OR lógico
             * ^ OR exclusivo lógico
             * && AND lógico condicional
             * || OR lógico condicional
             */

            bool bateria;

            Console.Write("¿Hay batería? (true/false): ");
            bateria = Convert.ToBoolean(Console.ReadLine());

            if(!bateria)
            {
                Console.WriteLine("Conecta el celular");
            }
            else
            {
                Console.WriteLine("No es necesario conectar el celular");
            }
        }
    }
}
