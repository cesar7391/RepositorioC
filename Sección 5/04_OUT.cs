using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se declara en main, pero se inicializa en el método
            byte nAr;
            String saludoAr;
            int numPrimoAr;

            //Se invoca el método y se mandan los argumentos
            Prueba(out nAr, out saludoAr, out numPrimoAr);

            //Después de que el método cambia los valores, se muestran
            Console.WriteLine(nAr);
            Console.WriteLine(saludoAr);
            Console.WriteLine(numPrimoAr);

        }

        static void Prueba(out byte num, out String saludoAr, out int numPrimoAr)
        {
            //Se modifican los valores de los parámetros
            num = 45;
            saludoAr = "Hola a todos";
            numPrimoAr = 17;
        }
    }
}
