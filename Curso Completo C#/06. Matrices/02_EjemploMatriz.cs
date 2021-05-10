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
            //se puede omitir el new, pero deberían colocarse los valores inmediatamente
            double[] matrizDobles = { 9, 10, 7.4, 6 }; //Se declara la matriz y valores

            //Declaración de una matriz
            int[] matrizNumeros;
            //Instancia e inicialización del objeto
            matrizNumeros = new int[] { 5, 3, 1 };

            //==================

            double[] calificaciones = new double[4];

            //Asignando un valor de 7.4 al tercer elemento de la matriz
            calificaciones[2] = 7.4;
            Console.WriteLine(calificaciones[2]);

            double caliFinal;
            //El valorq ue contiene el indice 2 se le restará 1
            caliFinal = calificaciones[2] - 1;
            Console.WriteLine(caliFinal);

            calificaciones[0] = 0;
            calificaciones[1] = 10;
            calificaciones[2] = 7.5;
            calificaciones[3] = 6;
        }
    }
}
