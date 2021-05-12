using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3
{
    class Operacion
    {        
        public int Suma(int num1, int num2)
        {
            int resultado;
            resultado = num1 + num2;
            return resultado;
        }

        public double Suma(double num1, double num2)
        {
            double resultado;
            resultado = num1 + num2;
            return resultado;
        }

        public int Suma(int num1, int num2, int num3)
        {
            int resultado;
            resultado = num1 + num2 + num3;
            return resultado;
        }
    }
}
