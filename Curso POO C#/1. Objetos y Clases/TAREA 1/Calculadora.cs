using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    

    class Calculadora
    {
        public int n1, n2, resultado;

        public void Suma()
        {
            resultado = n1 + n2;
        }

        public void Resultado()
        {
            Console.WriteLine("{0} + {1} = {2}", n1, n2, resultado);
        }

    }
 
}
