using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Matematicas
    {
        private double num1, num2, resultado;

        public void Suma()
        {
            Console.Write("Primer número: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Segundo número: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            resultado = num1 + num2;
            Console.WriteLine("{0} + {1} = {2}", num1, num2, resultado);
        }

        public void Resta(double num1, double num2)
        {
            resultado = num1 - num2;
            Console.WriteLine("{0} - {1} = {2}", num1, num2, resultado);
        }

        public double Multiplicacion()
        {
            Console.Write("Primer número: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Segundo número: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            resultado = num1 * num2;
            return resultado;
        }

        //[acceso][modificador][tipo][identificador][parametros]
    }
}
