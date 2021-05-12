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

            Matematicas mate1 = new Matematicas();

            Console.Write("Primer número: ");
            mate1.Num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Segundo número: ");
            mate1.Num2 = Convert.ToDouble(Console.ReadLine());


            do
            {
                switch (opcion)
                {
                    case 1:
                        mate1.Suma();
                        Console.WriteLine("{0} + {1} = {2}", mate1.Num1,mate1.Num2,mate1.Resultado);
                        break;
                    case 2:
                        mate1.Resta();
                        Console.WriteLine("{0} - {1} = {2}", mate1.Num1, mate1.Num2, mate1.Resultado);
                        break;
                    case 3:
                        mate1.Multiplicacion();
                        Console.WriteLine("{0} x {1} = {2}", mate1.Num1, mate1.Num2, mate1.Resultado);
                        break;
                }

            }while (opcion < 1 && opcion > 3);

        }
    }
}
