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
            //MATRIZ viene de array --> Estructura de datos, puede almacenar variables
            //En una tupla pueden haber varios elementos de distinto tipo
            //En una matriz todos son del mismo tipo, rl índice comienza en 0

            // tipo[] nombre;
            double[] matrizDobles; //Declaración matriz tipo double

            //=============================================================================

            byte tamaño;

            Console.Write("¿De qué tamaño será la matriz?");
            tamaño = Convert.ToByte(Console.ReadLine());

            int[] primos = new int[tamaño];

            //Operador new crea objetos
            // tipo[] nombre = new tipo[tamaño];
            //DECLARACIÓN Y CREACIÓN DE LA MATRIZ
            double[] calificaciones = new double[4];

            String[] nombres = new string[5];
            int[] numeros = new int[10];
            byte[] datos = new byte[7];

        }
    }
}
