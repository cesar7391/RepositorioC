using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion3
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num1, num2, resultado = 0.0M;
            byte opcion;
            String Operacion = "";

            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");

            Console.Write("Escoge una opción: ");
            opcion = Convert.ToByte(Console.ReadLine());

            Console.Write("Primer número: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Segundo número: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Operacion = "suma";
                    resultado = num1 + num2;
                    break;
                case 2:
                    Operacion = "resta";
                    resultado = num1 - num2;
                    break;
                case 3:
                    Operacion = "multiplicación";
                    resultado = num1 * num2;
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        Operacion = "división";
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("No es posible dividir entre cero");
                    }
                    break;
            }

            //Resultado
            Console.WriteLine("La {0} de {1} y {2} es: {3}", Operacion, num1, num2, resultado);
        }
    }
}
