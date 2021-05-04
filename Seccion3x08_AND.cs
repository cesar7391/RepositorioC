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

            //USO DEL OPERADOR && AND lógico condicional
            byte edad;
            bool licencia;

            Console.Write("¿Qué edad tienes? ");
            edad = Convert.ToByte(Console.ReadLine());

            Console.Write("¿Tienes licencia de conducir? (true/false) ");
            licencia = Convert.ToBoolean(Console.ReadLine());

            if(edad >= 18 && licencia == true)
            {
                Console.WriteLine("Puedes conducir");
            }
            else
            {
                Console.WriteLine("No puedes conducir");
            }
        }
    }
}
