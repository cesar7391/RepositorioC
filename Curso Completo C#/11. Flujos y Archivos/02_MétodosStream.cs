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
            MemoryStream ms = new MemoryStream(30);

            int capacidad = ms.Capacity;
            long longitud = ms.Length;
            long posicion = ms.Position;

            ms.Seek(0, SeekOrigin.Begin);

            //El método Read sirve para leer el stream
            //Buffer, espacio que almacena datos temporalmente
            byte[] buffer = new byte[30];

            //Recibe 3 parámetros: 1. Un arreglo de bytes para guardar la información leída, 2. La posición de inicio y 3. La cantidad de bytes que se van a leer
            ms.Read(buffer, 0, 7);
            //Después de esta operación, la información estará en el buffer

            //El método Write sirve para escribir en el stream
            //3 parámetros: el arreglo de bytes de donde se sacará la información para escribir, 2. La posición de inicio y 3. La cantidad de bytes que se van a escribir
            ms.Write(buffer, 0, 7);

            //ES MUY IMPORTANTE CERRAR EL STREAM, se lleva a cabo mediante un método llamado Close, de esta manera:
            ms.Close();
        }
    }
}
