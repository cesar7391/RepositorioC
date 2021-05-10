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
            int i, j;

            double[,] ventas = new double[,] { { 100, 120, 205 },
                                                  { 115, 196, 300 },
                                                  { 157, 172, 245 },
                                                  { 130, 180, 281 } };

            //Mostrar el tamaño de la primera dimensión (Se pide al método GetLength el tamaño de la primera dimensión
            Console.WriteLine(ventas.GetLength(0));
            //Mostrar el tamaño de la segunda dimensión (Se pide al método GetLength el tamaño de la segunda dimensión
            Console.WriteLine(ventas.GetLength(1));

            Console.WriteLine("\n=====================");

            //Ciclo que recorre las filas
            for (i = 0; i < ventas.GetLength(0); i++)
            {
                Console.WriteLine();
                //Dentro de este ciclo hay otro ciclo que recorre las columnas
                for (j = 0; j < ventas.GetLength(1); j++)
                {
                    //Se imprime el contenido en la "coordenada" actual
                    Console.WriteLine(ventas[i, j]);
                }
            }
        }
    }
}
