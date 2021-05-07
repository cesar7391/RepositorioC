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
            //Variables de control de ciclo
            int i; //Para ciclo exterior
            int j; //Para ciclo interior
            double[,] ventas  = new double[4, 3];
            double[,] ventas2 = new double[4, 3] { { 100, 120, 205 },
                                                   { 115, 196, 300 },
                                                   { 157, 172, 245 },
                                                   { 130, 180, 281 } };

            //Para asignar un valor, se pone la "coordenada"
            ventas[1, 2] = 450;

            //Para acceder a los elementos, en caso de poner un índice que no existe, habrá una excepción no controlada, por salir de la matriz
            Console.WriteLine(ventas[1, 2]+"\n");

            //==============================================

            //Se crea un ciclo que recorrerá las filas
            for(i=0; i < 4; i++)
            {
                //Dentro de este ciclo hay otro ciclo que recorre las columnas
                Console.WriteLine("Fila {0}", i);
                for(j=0; j < 3; j++)
                {
                    //Se imprime el contenido en la "coordenada" actual
                    Console.WriteLine(ventas2[i, j]);
                }
            }

        }
    }
}
