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

            //USO DEL OPERADOR || OR lógico condicional
            float calPrepa, calExamen;

            Console.Write("¿Con qué promedio conluiste tus estudios de preparatoria? ");
            calPrepa = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingresa tu calificación del examen de ingreso ");
            calExamen = Convert.ToSingle(Console.ReadLine());

            //Condición
            if((calPrepa >= 9) || (calExamen >= 9.5))
            {
                Console.WriteLine("¡Felicidades, tienes la beca!");
            }
            else
            {
                Console.WriteLine("Lo sentimos, no eres acreedor de la beca");
            }
        }
    }
}
