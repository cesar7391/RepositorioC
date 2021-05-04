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
            //Pedir un número y determinar si es positivo o negativo
            double numero;

            Console.Write("Introduce un número: ");
            numero = Convert.ToDouble(Console.ReadLine());

            if(numero > 0)
            {
                Console.Write("El número es positivo");
            }
            if (numero < 0)
            {
                Console.Write("El número es negativo");
            }
            if (numero == 0)
            {
                Console.Write("El número es cero");
            }
        }
    }
}
