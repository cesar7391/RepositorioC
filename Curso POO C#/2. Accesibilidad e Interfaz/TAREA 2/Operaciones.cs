using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Operaciones
    {
        private double num1, num2;
        private double resultado;

        public void Multiplicar()
        {
            LeerNum();
            resultado = num1 * num2;
            Resultado();
        }

        private void LeerNum()
        {
            Console.WriteLine("Número 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Número 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
        }

        private void Resultado()
        {
            Console.WriteLine("El resultado es: {0}", resultado);
        }
    }
}
