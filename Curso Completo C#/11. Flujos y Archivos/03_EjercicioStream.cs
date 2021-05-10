using System;
using System.Collections.Generic;
using System.IO; //Uso de Strems
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creación del Stream
            MemoryStream ms = new MemoryStream(50);

            //Cadena para el Stream
            String cadenaStream = "";

            //Variables del stream
            int capacidad = 0; 
            long longitud = 0, posicion = 0;

            //Arreglo de bytes
            byte[] buffer = new byte[50];

            //Petición de cadena
            Console.Write("Introduce una cadena: ");
            cadenaStream = Console.ReadLine();

            //ASCII: Codigo Estadounidense Estándar para el Intercambio de Informacion
            //Se le pasa la cadena pero haciendo la codificación ASCII
            ms.Write(ASCIIEncoding.ASCII.GetBytes(cadenaStream), 0, cadenaStream.Length);

            //Se asignan las propiedades:
            capacidad = ms.Capacity;
            longitud = ms.Length;
            posicion = ms.Position;

            //Se muestra la información
            Console.WriteLine("Capacidad: {0}, Longitud: {1}, Posición: {2}", capacidad, longitud, posicion);

            //Nos colocamos en la posición 0 desde el inicio
            ms.Seek(0, SeekOrigin.Begin);
            //Desde la posición donde nos encontramos, se leen 7 bytes
            ms.Read(buffer, 0, 15);
            //Se obtiene la cadena almacenada en el buffer, usando GetString del ASCII
            Console.WriteLine(ASCIIEncoding.ASCII.GetString(buffer));

            //Segunda prueba colocándonos en la posición 5 desde el inicio
            ms.Seek(5, SeekOrigin.Begin);
            ms.Read(buffer, 0, 15);
            Console.WriteLine(ASCIIEncoding.ASCII.GetString(buffer));

            //Ahora una prueba colocándonos a 12 posiciones desde el final
            ms.Seek(-12, SeekOrigin.End);
            ms.Read(buffer, 0, 10);
            Console.WriteLine(ASCIIEncoding.ASCII.GetString(buffer));

            //Se cierra el flujo
            ms.Close();
        }
    }
}
