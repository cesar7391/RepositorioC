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
            int opcion;
            double num1, num2, resultado;

            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("Escoge una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            Matematicas mate = new Matematicas();

            do
            {
                switch (opcion)
                {
                    case 1:
                        mate.Suma();
                        break;
                    case 2:
                        Console.Write("Primer número: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Segundo número: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        mate.Resta(num1,num2);
                        break;
                    case 3:
                        Console.WriteLine("El resultado de la multiplicación es: "+mate.Multiplicacion());
                        break;
                }

            }while (opcion < 1 && opcion > 3);

        }
    }
}
