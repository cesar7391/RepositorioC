using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultadoInt;
            double resultadoDouble;

            Operacion Calc1 = new Operacion();

            resultadoDouble = Calc1.Suma(4.6,7.5);
            resultadoInt = Calc1.Suma(5, 10);
            Console.WriteLine("El resultado (Int) es: " + resultadoInt);
            Console.WriteLine("El resultado (Double) es: " + resultadoDouble);

            resultadoInt = Calc1.Suma(2,4,98);
            Console.WriteLine("El resultado (Suma de 3 parámetros) es: " + resultadoInt);
        }
    }
}
