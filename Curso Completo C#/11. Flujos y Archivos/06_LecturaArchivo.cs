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
            //Arreglo de bytes para contener la información
            byte[] recibeInfo = new byte[100];
            String nombreArchivo = "";

            Console.Write("¿Cómo se llama el archivo a abrir? ");
            nombreArchivo = Console.ReadLine() + ".txt";

            //Se especifica que se abrirá un archivo
            FileStream fs = new FileStream(nombreArchivo,FileMode.Open);

            //Para leer se utiliza Read, recibe 1. Arreglo de bytes, 2.Inicio de lectura y 3. cantidad de caracteres a leer (obtiene la longitud del Filestream, haciendo cast)
            fs.Read(recibeInfo, 0, (int)fs.Length);

            //Muestra la información
            Console.WriteLine("El archivo contiene el siguiente texto: ");
            //Se muestra la información
            Console.WriteLine(ASCIIEncoding.ASCII.GetString(recibeInfo));

            fs.Close();

        }
    }
}
