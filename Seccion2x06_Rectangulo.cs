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
            //Realizar un programa que calcule el área y perímetro de un rectángulo

            double altura, ancho, area, perimetro;

            Console.WriteLine("=== CALCULAR ÁREA Y PERÍMETRO DE UN RECTÁNGULO ===");
            Console.Write("Introducir altura: ");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introducir ancho: ");
            ancho = Convert.ToDouble(Console.ReadLine());

            // Cálculos
            area = ancho * altura;
            perimetro = 2 * (altura + ancho);

            //RESULTADOS
            Console.WriteLine("El área es de : {0} u²", area);
            Console.WriteLine("El perímetro es: {0} u", perimetro);
        }
    }
}
