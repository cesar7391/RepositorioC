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
            //Para calcular el área de un círculo, cuadrado o triangulo. Preguntar al usuario qué figura calcular.
            double rad, basT, altura, lado, resultado;
            byte opcion;
                     
            Console.WriteLine("1. Círculo");
            Console.WriteLine("2. Cuadrado");
            Console.WriteLine("3. Triángulo\n");
            do
            {
                Console.Write("Elige una figura para calcular su área: ");
                opcion = Convert.ToByte(Console.ReadLine());
            } while (opcion < 1 || opcion > 3);

            switch (opcion)
            {
                case 1:
                    Console.Write("¿Cuál es la medida del radio? ");
                    rad = Convert.ToDouble(Console.ReadLine());
                    resultado = AreaCirculo(rad);
                    Console.WriteLine("El área del círculo es de {0} u²",resultado);
                    break;
                case 2:
                    Console.Write("¿Cuál es la medida de un lado? ");
                    lado = Convert.ToDouble(Console.ReadLine());
                    resultado = AreaCuadro(lado);
                    Console.WriteLine("El área del cuadrado es de {0} u²",resultado);
                    break;
                case 3:
                    Console.Write("¿Cuál es la medida de la base? ");
                    basT = Convert.ToDouble(Console.ReadLine());
                    Console.Write("¿Cuál es la medida de la altura? ");
                    altura = Convert.ToDouble(Console.ReadLine());
                    resultado = AreaTriangulo(basT,altura);
                    Console.WriteLine("El área del triángulo es de {0} u²",resultado);
                    break;
            }
        }

        static double AreaCirculo(double rad)
        {
            double resultado;
            const double Pi = Math.PI;
            resultado = Pi * (rad * rad);
            return resultado;
        }

        static double AreaCuadro(double lado)
        {
            double resultado;
            resultado = lado * lado;
            return resultado;
        }

        static double AreaTriangulo(double a, double b)
        {
            double resultado;
            resultado = (a * b) / 2;
            return resultado;
        }
    }
}