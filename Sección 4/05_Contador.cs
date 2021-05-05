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
            int contador = 0;
            for(int i = 0; i <= 20; i+= 2)
            {
                contador++;
                //contador += 2;
                Console.WriteLine("Vuelta del ciclo {0}, valor: {1}", contador,i);
            }

            Console.WriteLine("El número de vueltas que dio ciclo fue {0}", contador);
        }
    }
}
