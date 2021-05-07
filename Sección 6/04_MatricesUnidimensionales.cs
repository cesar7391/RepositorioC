using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion6
{
    class Program
    {
        static void Main(string[] args)
        {
            byte i, nAlumnos;
            double sumaCalif = 0, promedio, califMin = 10, califMax = 0;

            Console.Write("Ingrese el número de alumnos: ");
            nAlumnos = Convert.ToByte(Console.ReadLine());

            //Crear la matriz
            double[] calificaciones = new double[nAlumnos];

            //Se recorre para agregar valores
            for (i = 0; i < nAlumnos; i++)
            {
                Console.Write("Calificación {0}: ", i + 1);
                calificaciones[i] = Convert.ToDouble(Console.ReadLine());
                //Se acumulan las calificaciones
                sumaCalif += calificaciones[i];
            }

            //Se calcula el promedio
            promedio = sumaCalif / nAlumnos;

            //CALCULAR LA CALIFICACIÓN MÍNIMA
            for (i = 0; i < nAlumnos; i++)
            {
                if(calificaciones[i] < califMin)
                {
                    califMin = calificaciones[i];
                }
            }

            //CALCULAR LA CALIFICACIÓN MAXIMA
            for (i = 0; i < nAlumnos; i++)
            {
                if (calificaciones[i] > califMax)
                {
                    califMax = calificaciones[i];
                }
            }

            Console.WriteLine("El promedio es: {0}", promedio);
            Console.WriteLine("La calificación mínima es: {0}", califMin);
            Console.WriteLine("La calificación máxima es: {0}", califMax);

        }
    }
}
