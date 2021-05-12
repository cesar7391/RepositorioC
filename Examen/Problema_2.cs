using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            String transformar;
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            String[] arreglo = { "hola mundo", "pepe pecas pica papas", "la luna es bonita" };
            List<String> lista = new List<string>();

            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine(arreglo[i]);
                transformar = ti.ToTitleCase(arreglo[i]);
                lista.Add(transformar);
            }

            Console.WriteLine();

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
        }
    }
}