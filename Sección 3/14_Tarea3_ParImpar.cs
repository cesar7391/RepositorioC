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
            int numero;

            Console.Write("Escribe un número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if ((numero % 2) == 0)
            {
                Console.WriteLine("Número PAR");
            }
            else
            {
                Console.WriteLine("Número IMPAR");
            }
        }
    }
}
