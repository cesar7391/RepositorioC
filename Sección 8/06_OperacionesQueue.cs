using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Seccion8
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables que vamos a utilizar
            int opcion = 0;
            string valor = "";
            int numero = 0;
            bool encontrado = false;

            //creamos nuestro Queue

            Queue fila = new Queue();

            do
            {
                Console.WriteLine("1. Agregar elemento");
                Console.WriteLine("2. Extraer elemento");
                Console.WriteLine("3. Limpiar fila");
                Console.WriteLine("4. Encontrar elemento");
                Console.WriteLine("5. Salir");

                //pedimos la opcion
                Console.Write("Escoge una opción: ");
                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);


                if (opcion == 1)
                {
                    Console.Write("Dame el valor a introducir en la fila: ");
                    valor = Console.ReadLine();
                    numero = Convert.ToInt32(valor);

                    //Agregamos el valor introducido por el usuario en el Queue
                    fila.Enqueue(numero);
                }

                if (opcion == 2)
                {
                    //Obtenemos el elemento
                    numero = (int)fila.Dequeue();

                    //Mostramos el elemento extraido
                    Console.WriteLine("El valor extraido es: {0}", numero);
                }

                if (opcion == 3)
                {
                    //Limpiar el contenido de nuestro Queue
                    fila.Clear();
                    Console.Write("ELEMENTOS ELIMINADOS");
                }

                if (opcion == 4)
                {
                    //Pedimos el valor que queremos encontrar
                    Console.Write("Dame el valor que quieres encontrar: ");
                    valor = Console.ReadLine();
                    numero = Convert.ToInt32(valor);

                    //verificamos que el elemento se encuentre
                    encontrado = fila.Contains(numero);

                    //Mostramos el resultado
                    Console.WriteLine("Elemento encontrado = {0}", encontrado);
                }

                //Mostramos la información
                Console.WriteLine("");
                Console.WriteLine("La fila tiene {0} elementos", fila.Count);
                foreach (int n in fila)

                    Console.Write(" {0} ", n);
                Console.WriteLine("\n");

            } while (opcion != 5);

        }
    }
}
