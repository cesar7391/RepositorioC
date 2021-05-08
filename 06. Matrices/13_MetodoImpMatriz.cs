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
            int[] matriz = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ImprimirMatriz(matriz);

            Console.WriteLine("=====================");

            double[,] matriz2D = { { 1, 2, 3 }, 
                                { 4, 5, 6 }, };
            ImprimirMatriz2D(matriz2D);
        }

        static void ImprimirMatriz(int[] matriz)
        {
            int i;

            for(i=0; i<matriz.Length; i++)
            {
                Console.WriteLine(matriz[i]);
            }
        }

        static void ImprimirMatriz2D(double[,] matriz2D)
        {
            int i, j;

            for (i = 0; i < matriz2D.GetLength(0) ; i++)
            {                
                for (j = 0; j < matriz2D.GetLength(1); j++)
                {
                    Console.WriteLine(matriz2D[i, j]);
                }
                Console.WriteLine();
            } 

            
        }
    }
}
{\rtf1}