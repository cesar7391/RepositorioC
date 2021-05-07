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
            //Para matrices multidimensionales, se usan los índices igualmente desde 0
            /* 0,0 - 0,1 - 0,2
             * 1,0 - 1,1 - 1,2
             * 2,0 - 2,1 - 2,2
             * 3,0 - 3,1 - 3,2   ESTA ES UNA MATRIZ MULTIDIMENSIONAL [4,3] (Filas por columnas)
             */

            //tipo[,] nombre = new tipo [filas, columnas] 2 dimensiones
            double[,] ventas = new double [4,3] { { 100, 120, 205 }, 
                                                  { 115, 196, 300 }, 
                                                  { 157, 172, 245 }, 
                                                  { 130, 180, 281 } };


            //tipo[,,] nombre = new tipo[fila, columna, prof] 3 dimensiones
            /* 1  4 | 2  5 | 3  6
             * 7 10 | 8 11 | 9 12
             */
            double[,,] matriz3D = new double[2, 2, 3] { { { 1,  2,  3 }, 
                                                          { 4,  5,  6 } }, 
                                                        { { 7,  8,  9 }, 
                                                         { 10, 11, 12 } } };


        }
    }
}
