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
            //Stream o flujo, lleva la información de un lugar a otro
            //Arreglo de bytes...
            //En este caso se da como parámetro el número de bytes que se utilizará
            //MemoryStream Nombre = new MemoryStream(tañamo);

            MemoryStream ms = new MemoryStream(30);
            //No se puede modificar su tamaño! se debe hacer una estimación aproximada del tamaño máximo
            int capacidad = ms.Capacity;
            Console.WriteLine("La capacidad del stream es {0}", capacidad);

            //Para conocer su longitud de los bytes que se están utilizando, se puede usar Length, si el Stream está vacío entonces muestra 0
            long longitud = ms.Length;
            Console.WriteLine("La longitud del stream es {0}", longitud);

            //Se puede saber la posicion actual del byte, está referenciada con el inicio del stream, se utiliza Position. Si está vacío devuelve 0
            long posicion = ms.Position;
            Console.WriteLine("La posición actual del stream es {0}", posicion);

            //Para posicionarnos en un stream, se usa Seek(), que recibe 2 parámetros: La distancia desde el punto de referencia en el stream y el punto de referencia que se va a utilizar... Se puede especificar Begin, Current y End

            //Para colocarse al inicio del stream: Nos encontramos a 0 posiciones de distancia desde el INICIO del stream
            ms.Seek(0,SeekOrigin.Begin);

            //Para colocarse desde el FINAL, la distancia del punto de referencia debería ser negativa
            ms.Seek(-7, SeekOrigin.End);

            //Para colocarse desde el punto actual, entonces se usa Current
            ms.Seek(3, SeekOrigin.Current);

        }
    }
}
