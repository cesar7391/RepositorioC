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
            //Matriz Escalonada o JAGGED: es una matriz en la que sus elementos son matrices
            /* |____|____|____| 3 elementos
             * |_______|______| 2 elementos
             * |___|___|___|__| 4 elementos
             * |____|____|____| 3 elementos
             * En este caso será una matriz unidimensional de 4 elementos, cada uno con distintos elementos
             */

            //tipo [][] nombre = new tipo[matrices internas][elementos por matriz];
            double[][] mJagged = new double[4][];
            //Se declaran e inicializan las matrices internas, es posible declarar cuantos elementos tendrá cada matriz, o no.
            mJagged[0] = new double[] { 155, 100, 170 };
            mJagged[1] = new double[] { 205, 120 };
            mJagged[2] = new double[] { 115, 190, 104, 130};
            mJagged[3] = new double[] { 163, 218, 125};

            //TAMBIÉN ES POSIBLE HACERLO DE ESTA MANERA
            double[][] mJagged2 =
            {
                new double[] { 155, 100, 170 },
                new double[] { 205, 120 },
                new double[] { 115, 190, 104, 130},
                new double[] { 163, 218, 125}
            };
        }
    }
}
