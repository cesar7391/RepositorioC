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
            int i, acumulador = 0, precio;

            for (i = 1; i <= 5; i++)
            {
                Console.Write("Ingresa el precio del producto: $");
                precio = Convert.ToInt32(Console.ReadLine());

                acumulador += precio;
            }

            Console.WriteLine("El total es de: ${0}",acumulador);
        }
    }
}
