using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ámbito a nivel de método
            double num1;

            /*
            Console.Write("Valor para la variable local de Main: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Variable local n1 = {0}", num1);
            */

            ClasePrueba ejemplo = new ClasePrueba();
            ejemplo.Informacion();

        }
    }
}
