using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se usa EndsWith para saber si una cadena termina con una subcadena
            String cadena = "Soy César Flores y vengo de Oaxaca";
            String cadena2 = "de Oaxaca";

            if (cadena.EndsWith(cadena2))
                Console.WriteLine("[{0}] SI TERMINA CON [{1}]", cadena, cadena2);
            else
                Console.WriteLine("[{0}] NO TERMINA CON [{1}]", cadena, cadena2);

            //Copiar parte de una cadena, se usa CopyTo()
            char[] destino = new char[10];
            String cadenaC = "Hola a todos mis amigos";
            //CopyTo(Indice,destino de copia,índice a partir de dónde se colocarán, cuántos caracteres se copiarán)
            cadenaC.CopyTo(7, destino, 0, 5);
            //Se copiaron 5 caracteres, a partir del index 7 a "destino" desde el índice 0
            Console.Write("La palabra copiada es: "); Console.Write(destino);
            Console.WriteLine();

            //Se puede insertar en una cadena haciendo uso de Insert, recibe 2 parámetros, el índice donde se insertará la cadena y la cadena en sí, regresa un valor de tipo String
            //----------------01234567891011
            String cadena3 = "Hola a todos";
            String cadena4 = ", esta es una inserción";
            //Se imprime la cadena con la otra que se insertó
            Console.WriteLine(cadena3.Insert(12, cadena4));

            //LastIndexOf encuentra la posición de la última aparición de la subcadena, IndexOf muestra el índice de la primera aparición de la subcadena
            int indice = 0;
            int indice2 = 0;
            String cadena5 = "Texto de ejemplo de";

            indice = cadena5.IndexOf("de");
            indice2 = cadena5.LastIndexOf("de");
            Console.WriteLine("La cadena 'de' se encontró primero en el índice ["+indice+"], su última aparición fue en el índice ["+indice2+"]");
        }
    }
}
