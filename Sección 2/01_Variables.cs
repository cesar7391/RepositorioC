using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Seccion2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Precalentar el horno");
            Console.WriteLine("2. Mezclar harina y mantequilla");
            Console.WriteLine("3. Agregar azúcar y un huevo");
            Console.WriteLine("4. Amasar la mezcla");
            Console.WriteLine("5. dar forma y colocar en charola");
            Console.WriteLine("6. Hornear durante 10 minutos\n");

            //Declarando 3 variables de tipo entero
            int numLibros = 500, librosNiños = 100, librosMatematicas = 200;
            
            //Declarando variable double
            double promedioFinal = 9.8;

            char caracter = 'A';

            /*
             * BLOQUE DE COMENTARIO
             * Para comentar líneas seleccionadas se utiliza el botón de arriba
             * asdaqweqwe
             */

            String saludo = "Hola, buen día";

            bool bandera = true; //POR DEFECTO

            double numeroDouble = 7.7;

            decimal pnumeroDecimal = 8.5m; //El compilador convierte el double a decimal

            float numeroFlotante = 6.8f;

            //PARA MOSTRAR LAS VARIABLES EN LA CONSOLA

            Console.WriteLine(saludo);
            Console.WriteLine(numeroDouble);
            Console.WriteLine("Hay {0} libros en la biblioteca, {1} son para niños", numLibros, librosNiños);
        }
    }
}
