using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion6
{
    class Program
    {
        static void Main(String[] args)
        {
            //Matriz unidimensional con asignación implícita de tipo (Se omiten corchetes al inicio y el tipo en la 2da parte
            var matriz = new[] { 1, 2, 3 };
            var matriz2 = new[] { "Cesar","Melina" };

            //Matriz multidimensional con asignación implícita de tipo 
            var matriz2D = new[,] { { 1, 2, 3 }, { 4, 5, 6 } };

            //Matriz escalonada con asignación implícita de tipo, no se usan corchetes dobles
            var matrizJagged = new[]
            {
                new[] {12,23},
                new[] {15,16}
            };
        }
    }
}
