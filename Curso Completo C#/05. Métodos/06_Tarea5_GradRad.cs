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

            //Para convertir grados a radianes... Rad = (Grados * π)/180

            double Grados, Rad;

            Console.Write("¿Cuántos Grados? ");
            Grados = Convert.ToDouble(Console.ReadLine());
            Rad = GradoRad(Grados);
            Console.WriteLine("El resultado es {0} radianes", Rad);



        }

        static double GradoRad (double grados)
        {
            const double Pi = 3.141592;
            double resultado;
            resultado = (grados * Pi) / 180;
            return resultado;
        }
    }
}