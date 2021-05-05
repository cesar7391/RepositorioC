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
            ulong i, numero, factorial = 1;
			Console.Write("Ingresa un número para calcular su factorial: ");
			numero = Convert.ToUInt64(Console.ReadLine());

			for(i = numero; i >= 1; i--)
			{
				factorial *= i;
			}

			Console.WriteLine("El factorial de {0} es {1}", numero, factorial);
        }
    }
}
