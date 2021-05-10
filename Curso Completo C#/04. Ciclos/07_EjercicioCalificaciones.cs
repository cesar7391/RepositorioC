using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion4
{
    class Program
    {
        static void Main(string[] args)
        {
            byte i, nAlumnos;
            double calificacion, sumaC = 0, promedio;

            Console.Write("¿Cuántos alumnos se promediarán? ");
            nAlumnos = Convert.ToByte(Console.ReadLine());

            for (i = 1; i <= nAlumnos; i++)
            {
                Console.Write("Calificación del alumno {0}: ", i);
                calificacion = Convert.ToDouble(Console.ReadLine());

                sumaC += calificacion;
            }

            promedio = sumaC / nAlumnos;

            Console.WriteLine("El promedio general es de: {0}", promedio);
        }
    }
}
