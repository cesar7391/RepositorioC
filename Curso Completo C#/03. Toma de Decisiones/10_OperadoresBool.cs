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
            /* CONDICIONES PARA DESPEGAR
             * Ambos propulsores funcionan, tanque gasolina al menos con 75%.
             * Si solo un propulsor funciona, el tanque debe estar lleno
             */
            float energia;
            bool propulsorIzq, propulsorDer;

            Console.Write("Ingrese el nivel de energía: ");
            energia = Convert.ToSingle(Console.ReadLine());

            Console.Write("¿El propulsor derecho está en buen estado? (true/false): ");
            propulsorDer = Convert.ToBoolean(Console.ReadLine());

            Console.Write("¿El propulsor izquierdo está en buen estado? (true/false): ");
            propulsorIzq = Convert.ToBoolean(Console.ReadLine());

            if (((((propulsorDer) && (propulsorIzq)) == true) && (energia >= 75)) || ((((propulsorDer) || (propulsorIzq)) == true) && (energia == 100)))
            {
                Console.WriteLine("Es seguro despegar");
            }
            else
            {
                Console.WriteLine("No es seguro despegar");
            }
        }
    }
}
