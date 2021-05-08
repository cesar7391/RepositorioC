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
            int i = 10;
            int n = 20;

            Console.WriteLine("Valor inicial del operando: {0}", i);
            Console.WriteLine("Valor con incremento incluído: {0}", ++i);
            Console.WriteLine("Valor: {0}", i);

            Console.WriteLine("============================");

            Console.WriteLine("Valor inicial del operando: {0}", n);
            Console.WriteLine("Valor con decremento por hacer: {0}", n--);
            Console.WriteLine("Valor: {0}", n);
        }
    }
}
