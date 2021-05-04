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
            String color;

            Console.Write("Ingresa el color para obtener el código RGB: ");
            color = Console.ReadLine();

            switch (color)
            {
                case "Red":
                case "RED":
                case "red":
                    Console.WriteLine("El código RGB para {0} es: 255, 0, 0", color);
                    break;
                case "Green":
                    Console.WriteLine("El código RGB para {0} es: 0, 255, 0", color);
                    break;
                case "Blue":
                    Console.WriteLine("El código RGB para {0} es: 0, 0, 255", color);
                    break;
                default:
                    Console.WriteLine("El código RGB no se ha encontrado para {0}",color);
                    break;
            }
        }
    }
}
