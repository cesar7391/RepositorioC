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
            int x = 5;
            //Colecciones, se usa el namespace System.Collections
            //LISTA, un arreglo que puede cambiar el tamaño según se necesite
            ArrayList miArrayList = new ArrayList();

            miArrayList.Add(10);
            miArrayList.Add(3);
            miArrayList.Add(x);

            //Así como se agregan al arraylist se les da el índice a partir de 0
            Console.WriteLine(miArrayList[2]);

            //Se pueden asignar a los índices también
            miArrayList[0] = 80;
            Console.WriteLine(miArrayList[0]);

            //Con insert, se inserta un valor en el array, se indica así (índice,valor)
            miArrayList.Insert(1, 5);
            Console.WriteLine(miArrayList[1]);

            //Se puede borrar un elemento del array, indicando el indice con RemoveAt
            miArrayList.RemoveAt(1);
            Console.WriteLine(miArrayList[1]);

            Console.WriteLine("====================");

            //Para saber si un elemento está en el array, se debe dar el objeto a encontrar, el valor que regresa es el valor del índice donde se encuentra, si no existe, regresará "-1"
            int indice = miArrayList.IndexOf(80);
            Console.WriteLine("El valor 80 se encuentra en el índice {0}",indice);

            Console.WriteLine("====================");

            //Para recorrer colecciones, se utiliza foreach: foreach(tipo identificador in expresion) sentencia
            foreach (int valor in miArrayList)
            {
                Console.WriteLine("Valores: {0}",valor);
            }


        }
    }
}
