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
            decimal n1, n2, resultado = 0M;
            int opcion;

            do
            {
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");

                Console.Write("Elige una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());
            }
            while (opcion < 1 || opcion > 4);

            Console.Write("Primer número: ");
            n1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Segundo número: ");
            n2 = Convert.ToDecimal(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    resultado = n1 + n2;
                    break;
                case 2:
                    resultado = n1 - n2;
                    break;
                case 3:
                    resultado = n1 * n2;
                    break;
                case 4:
                    if(n2 != 0)
                    {
                        resultado = n1 / n2;
                    }
                    else
                    {
                        Console.WriteLine("¡Divisor no válido!");
                    }                    
                    break;
            }

            Console.WriteLine("El resultado es {0}", resultado);

        }
    }
}
