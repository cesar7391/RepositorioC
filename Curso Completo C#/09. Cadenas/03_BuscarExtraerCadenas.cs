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
            /* Para buscar una subcadena dentro de una cadena, puede servir en búsquedas, se 
             * utiliza Contains, necesita sólo un parámetro: la cadena que buscará
             * devuelve un bool, TRUE en caso de encontrarla, FALSE en caso de no encontrarla
             * Si se usa en una cadena vacía entonces devuelve true
             * hace diferencia de mayúsculas y minúsculas */

            String nombreCompleto = "César Elí Flores López";
            String buscar = "César";

            if (nombreCompleto.Contains(buscar))
                Console.WriteLine("El nombre está en la cadena");
            else
                Console.WriteLine("El nombre no está en la cadena");

            /* También se pueden extraer cadenas, mediante el método Substring()
             * necesita 2 parámetros, el índice de inicio y la cantidad de caracteres a extraer
             * devuelve una cadena que contiene los caracteres obtenidos
             */

            String cadena = "Cadena de ejemplo";
            //SE EXTRAEN LAS PALABRAS SEGÚN ÍNDICE Y NUM DE LETRAS
            String resultado = cadena.Substring(0, 6);
            String resultado2 = cadena.Substring(7, 2);
            String resultado3 = cadena.Substring(10, 7);
            //SE CONCATENAN PARA MOSTRAR LA ORACIÓN
            Console.WriteLine(resultado + " "+ resultado2+" "+resultado3);
        }
    }
}
