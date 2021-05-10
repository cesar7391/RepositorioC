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
            //Justificación
            String cadena = "Texto de ejemplo";
            String cadena2 = "Hola";
            String resultado,resultado2;

            //Se usa PadLeft para escribir la cadena justificando a la izquierda el texto, según cuántos espacios en total se deseen
            resultado = cadena.PadLeft(20);
            resultado2 = cadena2.PadLeft(20);
            Console.WriteLine(resultado+"\n"+resultado2);

            //Se usa PadRight para escribir la cadena justificando a la derecha el texto, según cuántos espacios en total se deseen
            resultado = cadena.PadRight(20);
            resultado2 = cadena2.PadRight(20);
            Console.WriteLine(resultado + "\n" + resultado2);

            Console.WriteLine("\n=============\n");

            //Eliminar Caracteres, se usa Remove, necesita 2 parámetros, el índice y la cantidad de caracteres a eliminar, devuelve un String
            String cadena3 = "TEXTO PARA ELIMINAR";
            String resultado3;

            resultado3 = cadena3.Remove(2, 11);
            Console.WriteLine("Texto original: " + cadena3);
            Console.WriteLine("Texto eliminando desde el índice [2], 11 caracteres: "+resultado3);

            Console.WriteLine("\n=============\n");

            //Para reemplazar una cadena, se utiliza Replace, puede reemplazar una palabra contenida en una cadena por otra palabra, necesita 2 parámetros, la cadena que se quiere reemplazar y la cadena nueva que reemplazará la antigua
            String cadena4 = "Palabra de prueba, cadena de prueba, prueba 1";
            String reemplazo = "reemplazo";
            Console.WriteLine(cadena4);
            Console.WriteLine(cadena4.Replace("prueba", reemplazo));           
        }
    }
}
