using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int [,] { { 1, 2, 3 },
                                          { 4, 5, 6 },
                                          { 7, 8, 9} };
            
            /*int[,] matriz2 = new int[,] { { 1, 2, 3, 4 },
                                          { 5, 6, 7, 8 },
                                          { 9, 10, 11, 12},
                                          { 13, 14, 15, 16} };
            */

            int[,] matriz180 = new int[matriz.GetLength(0),matriz.GetLength(1)];

            matriz180 = VoltearMatriz(matriz, matriz180);

            Console.WriteLine("MATRIZ DE ENTRADA: ");
            ImprimirMatriz(matriz);

            Console.WriteLine("MATRIZ DE SALIDA: ");
            ImprimirMatriz(matriz180);
        }

        static void ImprimirMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static int[,] VoltearMatriz(int[,] matrizOriginal, int[,] matrizNueva)
        {
            for (int i = 0; i < matrizOriginal.GetLength(0); i++)
            {
                for (int j = 0; j < matrizOriginal.GetLength(1); j++)
                {
                    int aux = i + 1;
                    matrizNueva[matrizOriginal.GetLength(0) - aux, j] = matrizOriginal[j, i];
                }
            }

            return matrizNueva;
        }
    }
}
