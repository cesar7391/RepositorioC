using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivoVS
{
    class Program
    {
        static void Main(string[] args)
        {
            String nArchivo = "";
            String cadena = "";

            Console.Write("¿Cómo se llamará el archivo?: ");
            nArchivo = Console.ReadLine();

            FileStream fs = new FileStream(nArchivo+".txt", FileMode.Create);

            //Se pide escribir
            Console.WriteLine("Escribe a continuación el texto para escribir en el archivo:");
            do
            {
                //Se leen las cadenas para escribir
                cadena = Console.ReadLine();
                //Se escribe en el archivo
                fs.Write(ASCIIEncoding.ASCII.GetBytes(cadena), 0, cadena.Length);

            } while (cadena != "");

            //Se cierra el archivo
            fs.Close();
        }
    }
}
