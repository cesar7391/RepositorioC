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
            int[][] matriz = {
                new int[] {1, 2, 3},
                new int[] {4, 5, 6},
                new int[] {7, 8, 9},
                new int[] {10,11,12}
            };

            int[][] matriz180 = VoltearMatriz180(matriz);

            Console.WriteLine("MATRIZ DE ENTRADA: ");
            ImprimirMatriz(matriz);

            Console.WriteLine("MATRIZ DE SALIDA: ");
            ImprimirMatriz(matriz180);

        }

        static void ImprimirMatriz(int[][] matriz)
        {
            for (int i = 0; i < matriz[0].Length; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    Console.Write(matriz[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static int[][] VoltearMatriz180(int[][] matriz)
        {
            int N = matriz[1].Length;
            int M = matriz[0].Length;

            int[][] matriz180 = new int[M][];

            for (int i = 0; i < matriz180.Length; i++)            
                matriz180[i] = new int[N];
            
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)                
                    matriz180[M - j - 1][i] = matriz[i][j];                
            }

            return matriz180;
        }
    }
}
