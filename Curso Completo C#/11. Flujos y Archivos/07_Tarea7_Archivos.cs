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
            String nArchivo = "", nRuta;
            String cadena = "";

            Console.Write("¿Cómo se llamará el archivo?: ");
            nArchivo = Console.ReadLine();
            Console.Write("Indica la ruta del archivo: ");
            nRuta = Console.ReadLine();

            FileStream fs = new FileStream(nRuta+"/"+nArchivo + ".doc", FileMode.Create);

            //Se pide escribir
            Console.WriteLine("Escribe a continuación el texto para escribir en el archivo:");
            do
            {
                //Se leen las cadenas para escribir
                cadena = Console.ReadLine();
                //Se escribe en el archivo
                fs.Write(ASCIIEncoding.ASCII.GetBytes(cadena), 0, cadena.Length);

            } while (cadena != "");

            fs.Close();

            Console.WriteLine("¿Desea agregar una firma? (S/N)");
            char opcion = Convert.ToChar(Console.ReadLine());
            if(opcion == 'S')
            {
                FileStream fsA = new FileStream(nRuta + "/" + nArchivo + ".doc", FileMode.Append);
                Console.Write("Escribe tu firma: ");
                cadena = Console.ReadLine();
                fsA.Write(ASCIIEncoding.ASCII.GetBytes(cadena), 0, cadena.Length);
                //Se cierra el archivo
                fsA.Close();
            }
            else
            {
                Console.WriteLine("========PROGRAMA FINALIZADO============");
            }            
        }
    }
}
