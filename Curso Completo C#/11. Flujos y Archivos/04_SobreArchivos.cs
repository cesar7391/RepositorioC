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
            String nArchivo = "Archivo.txt";
            String cadena = "Este es un ejemplo de escritura de archivos.";
            FileStream fs = new FileStream(nArchivo, FileMode.Create);

            //Necesita 3 parámetros, 1. El arreglo de bytes que se escribirá, igualmente se utilizará ASCIIEncoding. 2. Desde dónde se comienza a escribir y 3. La cantidad de caracteres a escribir
            fs.Write(ASCIIEncoding.ASCII.GetBytes(cadena), 0,cadena.Length);
            
            //También se debe cerrar el archivo
            fs.Close();
        }
    }
}
