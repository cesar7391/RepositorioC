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
            //Se declaran 2 variables para iteración
            int i, j;

            double[][] ventasEsc =
            {
                new double[] { 155, 100, 170 },
                new double[] { 205, 120 },
                new double[] { 115, 190, 104, 130},
                new double[] { 163, 218, 125}
            };

            //El Length devuelve el valor del numero de elementos en la matriz
            for (i = 0; i < ventasEsc.Length; i++)
            {
                Console.WriteLine("Elemento {0}", i);
                //Se debe usar al índice basado en i, para que no recorra de más o de menos
                for (j = 0; j < ventasEsc[i].Length; j++)
                {
                    Console.WriteLine("Valor en la posición [{0}][{1}]: {2}",i,j,ventasEsc[i][j]);
                }

            }
        }
    }
}