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
            double dividendo, divisor, resultado;

            Console.Write("Dame el dividendo: ");
            dividendo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Dame el divisor: ");
            divisor = Convert.ToDouble(Console.ReadLine());

            if(divisor != 0)
            {
                resultado = dividendo / divisor;
                Console.WriteLine("{0} / {1} = {2}", dividendo, divisor, resultado);
            }
        }
    }
}
