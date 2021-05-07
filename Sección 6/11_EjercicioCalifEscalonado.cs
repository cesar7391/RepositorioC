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
            //i se usa para salones, j para alumnos
            byte i, j, nAlumnos, nSalones;
            double sumaCalif = 0, sumaAlumnos = 0, promedio, califMin = 10, califMax = 0;

            Console.Write("Ingrese el número de salones: ");
            nSalones = Convert.ToByte(Console.ReadLine());

            //Crear la matriz de 2 dimensiones, comenzando por salones
            double[][] calificaciones = new double[nSalones][];

            //Iteración para pedir el número de alumnos por salón
            for (i = 0; i < nSalones; i++)
            {
                Console.Write("Ingrese el número de alumnos para el salón {0}: ",i+1);
                nAlumnos = Convert.ToByte(Console.ReadLine());

                //Acumulamos el número de alumnos total
                sumaAlumnos += nAlumnos;

                //Instanciamos las matrices internas (alumnos por salón)
                calificaciones[i] = new double[nAlumnos];
            }

            //Se recorre para agregar valores
            for (i = 0; i < nSalones; i++)
            {
                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    //Se pide la calificación por cada salón
                    Console.Write("Calificación {0} del salón {1}: ", i+1, j+1);
                    calificaciones[i][j] = Convert.ToDouble(Console.ReadLine());
                    sumaCalif += calificaciones[i][j];
                }
                Console.WriteLine("===================================");
            }

            //Se calcula el promedio: Todas las calificaciones 
            promedio = sumaCalif / sumaAlumnos;

            //CALCULAR LA CALIFICACIÓN MÍNIMA
            for (i = 0; i < nSalones; i++)
            {
                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    if (calificaciones[i][j] < califMin)
                    {
                        califMin = calificaciones[i][j];
                    }
                }
            }

            //CALCULAR LA CALIFICACIÓN MAXIMA
            for (i = 0; i < nSalones; i++)
            {
                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    if (calificaciones[i][j] > califMax)
                    {
                        califMax = calificaciones[i][j];
                    }
                }
            }

            //SE MUESTRAN LAS CALIFICACIONES DE TODOS LOS ALUMNOS DE LA ESCUELA
            for (i = 0; i < nSalones; i++)
            {
                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    Console.WriteLine("Calificación del alumno {0}: {1}", j, calificaciones[i][j]);
                }
            }

            Console.WriteLine("El promedio es: {0}", promedio);
            Console.WriteLine("La calificación mínima es: {0}", califMin);
            Console.WriteLine("La calificación máxima es: {0}", califMax);
        }
    }
}
