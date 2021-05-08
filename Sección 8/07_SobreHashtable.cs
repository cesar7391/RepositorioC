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
            //Hashtable, es una colección indexada, pero no como en ArrayList, el valor depende de una llave, se usa la pareja key-table

            Hashtable tablaH = new Hashtable();

            //Para usar add, se necesitan 2 parámetros, la llave(Sin repetir) y el valor (Cualquier tipo)
            tablaH.Add("Teléfono Samsung", 4499.80);
            tablaH.Add("Teléfono Huawei", 3600.50);
            tablaH.Add("Laptop HP", 9599.50);

            //Para ver el contenido del Hashtable se puede hacer de las siguientes maneras
            Console.WriteLine("==================");
            foreach (DictionaryEntry datos in tablaH)
            {
                Console.WriteLine("El Key es {0}, el dato es {1}", datos.Key, datos.Value);
            }
            Console.WriteLine("==================");

            /*
            ICollection valores = tablaH.Values;
            foreach(object valor in valores)
            {
                Console.WriteLine("El valor es de {0}", valor);
            }
            */

            //Para buscar se necesita el KEY, se utiliza Contains
            bool encontrado = tablaH.Contains("Laptop HP");
            Console.WriteLine(encontrado);

            //Para conocer el número de parejas en un Hashtable se utiliza Count
            int contador = tablaH.Count;
            Console.WriteLine("Hay {0} parejas Key-Value en la tabla", contador);

            //Para eliminar un elemento, se utiliza su Key con el método Remove
            tablaH.Remove("Laptop HP");
            Console.WriteLine("Se eliminó la laptop HP");

            //Se imprime de nuevo
            Console.WriteLine("==================");
            foreach (DictionaryEntry datos in tablaH)
            {
                Console.WriteLine("El Key es {0}, el dato es {1}", datos.Key, datos.Value);
            }
            Console.WriteLine("==================");

            //Para limpiar el contenido, se usa Clear
            tablaH.Clear();
        }
    }
}
