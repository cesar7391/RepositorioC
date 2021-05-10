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
            byte opcion;
            String mes="";

            Console.Write("Teclea un número del 1 al 12: ");
            opcion = Convert.ToByte(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("El mes es ENERO");
                    break;
                case 2:
                    Console.WriteLine("El mes es FEBRERO");
                    break;
                case 3:
                    Console.WriteLine("El mes es MARZO");
                    break;
                case 4:
                    Console.WriteLine("El mes es ABRIL");
                    break;
                case 5:
                    Console.WriteLine("El mes es MAYO");
                    break;
                case 6:
                    Console.WriteLine("El mes es JUNIO");
                    break;
                case 7:
                    Console.WriteLine("El mes es JULIO");
                    break;
                case 8:
                    Console.WriteLine("El mes es AGOSTO");
                    break;
                case 9:
                    Console.WriteLine("El mes es SEPTIEMBRE");
                    break;
                case 10:
                    Console.WriteLine("El mes es OCTUBRE");
                    break;
                case 11:
                    Console.WriteLine("El mes es NOVIEMBRE");
                    break;
                case 12:
                    Console.WriteLine("El mes es DICIEMBRE");
                    break;
                default:
                    Console.WriteLine("El número no está en el rango");
                    break;
            }
        }
    }
}
