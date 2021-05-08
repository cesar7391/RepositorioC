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
            //El Queue es como una fila, el primero en entrar es el primero en salir, estructura FIFO
            Queue fila = new Queue();

            //Para agregar elemento a la fila, se usa Enqueue()
            fila.Enqueue(10);
            fila.Enqueue(9);
            fila.Enqueue(8);
            fila.Enqueue(7);
            fila.Enqueue(6);

            //Para extraer elementos a la fila, se usa Dequeue()
            object valor = fila.Dequeue();
            Console.WriteLine("Valor extraído: {0}", valor);

            //Para observar el elemento de la fila pero sin extraer, se usa Peek
            valor = fila.Peek();
            Console.WriteLine("Valor observado: {0}", valor);

            //Para saber si la fila contiene un valor, entonces se usa Contains()
            bool enFila = fila.Contains(9);
            Console.WriteLine("¿Existe el elemento 9 en la fila?: {0}", enFila);            

            //Para conocer todos los elementos de la fila, se usa Count
            int conteo = fila.Count;
            Console.WriteLine("Hay {0} elementos en la fila", conteo);

            //Para recorrer los elementos de la fila se usa foreach
            foreach(object n in fila)
            {
                Console.Write(" {0} ", n);
            }
            Console.WriteLine();

            //Para eliminar todos los elementos de la fila, se usa Clear();
            fila.Clear();
            Console.WriteLine("Se eliminaron todos los elementos");

            //Se vuelve a contar
            conteo = fila.Count;
            Console.WriteLine("Hay {0} elementos en la fila", conteo);

        }
    }
}
