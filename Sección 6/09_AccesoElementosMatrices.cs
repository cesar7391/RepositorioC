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
            //===============================================================

            int[] numeros = new int[4] { 23, 13, 5, 6 };
            //Mostramos cuántos elementos contiene la matriz unidimensional
            Console.WriteLine("Elementos en la matriz unidimensional: {0}\n", numeros.Length);

            //===============================================================

            double[,] ventas2D = new double[4, 3] { { 100, 120, 205 },
                                                    { 115, 196, 300 },
                                                    { 157, 172, 245 },
                                                    { 130, 180, 281 } };

            Console.WriteLine("Elementos en la matriz 2D: {0}\n", ventas2D.Length);

            //===============================================================

            double[][] ventasEsc =
            {
                new double[] { 155, 100, 170 },
                new double[] { 205, 120 },
                new double[] { 115, 190, 104, 130},
                new double[] { 163, 218, 125}
            };

            Console.WriteLine("Elementos en la matriz 3D: {0}", ventasEsc.Length);
            Console.WriteLine("Elementos en la matriz del index 0: {0}", ventasEsc[0].Length);
            Console.WriteLine("Elementos en la matriz del index 1: {0}", ventasEsc[1].Length);
            Console.WriteLine("Elementos en la matriz del index 2: {0}", ventasEsc[2].Length);
            Console.WriteLine("Elementos en la matriz del index 3: {0}\n", ventasEsc[3].Length);

            Console.WriteLine("Elemento en la posición 1,5: {0}",ventasEsc[1][0]);
        }
    }
}
