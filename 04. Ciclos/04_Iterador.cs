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
            //Aumenta de 2 en 2 al momento de hacer una asignación compuesta en la sección de incremento
            for(int i = 1; i < 10; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("CICLO EN REVERSA");
            //Para hacer un for que recorra al revés
            for (int j = 10; j>= 1; j--)
            {
                Console.WriteLine(j);
            }
        }
    }
}
