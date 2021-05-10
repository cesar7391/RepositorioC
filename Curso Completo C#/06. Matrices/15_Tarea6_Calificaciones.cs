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
            double sumaCalif = 0, porSalon = 0, totalAlumnos = 0, promedio, califMin = 10, califMax = 0;

            Console.Write("Ingrese el número de salones: ");
            nSalones = Convert.ToByte(Console.ReadLine());

            //Crear la matriz de 2 dimensiones, comenzando por salones
            double[][] calificaciones = new double[nSalones][];

            Console.WriteLine("================");

            //Iteración para pedir el número de alumnos por salón
            for (i = 0; i < nSalones; i++)
            {
                Console.Write("Ingrese el número de alumnos para el salón {0}: ", i + 1);
                nAlumnos = Convert.ToByte(Console.ReadLine());

                //Acumulamos el número de alumnos total
                totalAlumnos += nAlumnos;

                //Instanciamos las matrices internas (alumnos por salón)
                calificaciones[i] = new double[nAlumnos];
            }

            Console.WriteLine("================");

            double[] califMinSalon = new double[nSalones];
            double[] califMaxSalon = new double[nSalones];
            double[] promedioSalon = new double[nSalones];

            //Se recorre para agregar valores
            for (i = 0; i < nSalones; i++)
            {
                //Estos valores se deben reiniciar por vuelta, para que puedan compararse de nuevo
                porSalon = 0;
                califMax = 0;
                califMin = 10;

                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    //Se pide la calificación por cada salón
                    Console.Write("Ingresa la calificación {0} del salón {1}: ", i + 1, j + 1);
                    calificaciones[i][j] = Convert.ToDouble(Console.ReadLine());

                    //Se acumula la calificación total
                    sumaCalif += calificaciones[i][j];

                    //Se acumula la calificación por salón
                    porSalon += calificaciones[i][j];

                    //Encontrar la calificación mínima
                    if(calificaciones[i][j] < califMin)
                    {
                        califMin = calificaciones[i][j];                        
                    }
                    //Se asigna la calificación más baja a la casilla que corresponde a ESE salón
                    califMinSalon[i] = califMin;


                    //Encontrar la calificación máxima
                    if (calificaciones[i][j] > califMax)
                    {
                        califMax = calificaciones[i][j];
                    }
                    //Se asigna la calificación más alta a la casilla que corresponde a ESE salón
                    califMaxSalon[i] = califMax;

                }
                //Se calcula el promedio por cada salón
                promedioSalon[i] = porSalon / calificaciones[i].Length;
                Console.WriteLine("===================================");
            }

            //Se calcula el promedio: Todas las calificaciones 
            promedio = sumaCalif / totalAlumnos;

            //CALCULAR LA CALIFICACIÓN MÍNIMA Y MÁXIMA PARA TODA LA ESCUELA
            for (i = 0; i < nSalones; i++)
            {
                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    //Calif mínima
                    if (calificaciones[i][j] < califMin)
                    {
                        califMin = calificaciones[i][j];
                    }
                    //Calif máxima
                    if (calificaciones[i][j] > califMax)
                    {
                        califMax = calificaciones[i][j];
                    }
                }
            }

            Console.WriteLine("===================================");

            //SE MUESTRAN LAS CALIFICACIONES DE TODOS LOS ALUMNOS DE LA ESCUELA
            for (i = 0; i < nSalones; i++)
            {
                Console.WriteLine("SALÓN {0}", i + 1);
                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    Console.WriteLine("Calificación del alumno {0}: {1}", j+1, calificaciones[i][j]);
                }
            }

            Console.WriteLine("===================================");
            for (i = 0; i < nSalones; i++)
            {
                Console.WriteLine("SALÓN {0}: Calificación mínima: {1}\nSALÓN {0}: Calificación máxima: {2}", i + 1, califMinSalon[i], califMaxSalon[i]);
                Console.WriteLine("Promedio del salón {0}: {1}", i + 1, promedioSalon[i]);
            }

            Console.WriteLine("===================================");

            Console.WriteLine("EL PROMEDIO DE LA ESCUELA ES: {0}", promedio);
            Console.WriteLine("LA CALIFICACIÓN GENERAL MÁS BAJA ES: {0}", califMin);
            Console.WriteLine("LA CALIFICACIÓN GENERAL MÁS ALTA ES: {0}", califMax);
        }
    }
}
