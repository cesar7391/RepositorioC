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
            int indice = 0;
            int cantidad = 0;

            ArrayList datos = new ArrayList();

            datos.Add(7);
            datos.Add(5);
            datos.Add(1);

            Console.WriteLine("Mostramos los valores iniciales del ArrayList: ");
            ImprimirArray(datos);

            //Agregamos más elementos al arreglo
            datos.Add(9);
            datos.Add(4);
            datos.Add(8);

            //Obtenemos el índice
            indice = datos.Add(10);

            Console.WriteLine("Después de agregar más elementos: ");
            ImprimirArray(datos);
            Console.WriteLine("El último elemento tiene el índice [{0}]", indice);

            Console.WriteLine("El elemento én el índice [2] es de {0}", datos[2]);

            //Se modifica el valor del arreglo en el indice 3
            datos[3] = 66;
            Console.WriteLine("Después de modificar el índice [3]: ");
            ImprimirArray(datos);

            //Obtenemos la cantidad de elementos del arreglo
            cantidad = datos.Count;
            Console.WriteLine("La cantidad de elementos es de: {0}", cantidad);

            //Ahora insertamos un elemento en una posición en particular
            datos.Insert(2, 88);
            Console.WriteLine("Después de insertar 88 en el índice [2]: ");
            ImprimirArray(datos);

            //Ahora eliminamos un elemento
            datos.RemoveAt(4);
            Console.WriteLine("Después de eliminar un elemento en el índice [4]: ");
            ImprimirArray(datos);

            //Encontramos el íundice dónde se encuentra el número 88
            indice = datos.IndexOf(88);
            Console.WriteLine("El primer '88' se encuentra en el índice [{0}]", indice);

        }

        static void ImprimirArray(ArrayList arreglo)
        {
            foreach(int n in arreglo)
            {
                Console.Write(" {0} ", n);
            }
            Console.WriteLine();
        }
    }
}
