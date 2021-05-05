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
            //Realizar un programa que calcule el perímetro de cualquier polígono regular

            double numLados = 4, medida, perimetro;

            Console.Write("¿Cuántos lados tiene el polígono? ");
            numLados = Convert.ToInt32(Console.ReadLine());

            Console.Write("¿Cuánto mide cada lado? ");
            medida = Convert.ToInt32(Console.ReadLine());

            //SE CALCULA EL PERÍMETRO
            perimetro = numLados * medida;

            //SE IMPRIME EL RESULTADO
            Console.WriteLine("El perímetro del polígono es de {0} unidades",perimetro);
        }
    }
}
