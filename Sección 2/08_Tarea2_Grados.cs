using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Seccion2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizar un programa que transforme grados Centígrados a grados Fahrenheit

            double gradosC, gradosF;

            Console.Write("Introducir temperatura en °C: ");
            gradosC = Convert.ToInt32(Console.ReadLine());

            //La fórmula es (°C × 9/5) + 32 = °F
            gradosF = (gradosC * 1.8) + 32;

            Console.WriteLine("La temperatura en °F es de: {0}",gradosF);
        }
    }
}
