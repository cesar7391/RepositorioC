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
            //If anidados, instruccion dentro de otra instrucción igual
            //Se necesita un programa que realice las 4 operaciones básicas a partir de 2 números, la operación deseada será elegida por el usuario

            //Se asigna valor de 0.0M de decimal a resultado
            decimal num1, num2, resultado = 0.0M;
            byte opcion;
            String Operacion="";

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

            // Suma
            if (opcion == 1)
            {
                Operacion = "+";
                resultado = num1 + num2;
            }
            else
            {
                //Resta
                if (opcion == 2)
                {
                    Operacion = "-";
                    resultado = num1 - num2;
                }
                else
                {
                    // Multiplicación
                    if (opcion == 3)
                    {
                        Operacion = "*";
                        resultado = num1 * num2;
                    }
                    else
                    {
                        //División
                        if (opcion == 4)
                        {
                            if (num2 != 0)
                            {
                                Operacion = "/";
                                resultado = num1 / num2;
                            }
                            else
                            {
                                Console.WriteLine("No es posible dividir entre cero");
                            }
                        }
                    }
                }
            }

            //Resultado
            Console.WriteLine("{0} {1} {2} = {3}",num1, Operacion,num2, resultado);
        }
    }
}
