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
            //Stack es una estructura LIFO El último que entra es el primero que sale... Se refiere a una PILA
            Stack miPila = new Stack();
            //Necesita Push() para añadir elementos
            miPila.Push(11);
            miPila.Push(8);
            miPila.Push("asdasd");
            miPila.Push(2);

            object valor;
            //Valor en este caso guarda el valor de hasta arriba del stack
            valor = miPila.Pop();

            foreach(object n in miPila)
            {
                Console.WriteLine("{0}", n);
            }

            //Se usa Count para devolver la cantidad de elementos en la Pila
            int cantidad = miPila.Count;
            Console.WriteLine("Hay {0} elementos en la pila",cantidad);

            //Para borrar todos los elementos de la pila
            miPila.Clear();

            //Para encontrar un objeto en la pila, si se encuentra el valor devuleto será true, si no, será false

            bool enPila = miPila.Contains(8);
            Console.WriteLine("¿El elemento está en la pila?: {0}", enPila);
            
        }

    }
}
