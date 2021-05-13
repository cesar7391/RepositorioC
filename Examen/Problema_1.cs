using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = { 45, 123, 12, 15, 20, 46, 89, 129 };
            int valorMaximo = int.MinValue, valorMinimo = int.MaxValue;
            
            for(int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] > valorMaximo)
                    valorMaximo = arreglo[i];

                if (arreglo[i] < valorMinimo)
                    valorMinimo = arreglo[i];
            }

            Console.WriteLine("Valor mínimo: " + valorMinimo);
            Console.WriteLine("Valor máximo: " + valorMaximo);
        }
    }
}
