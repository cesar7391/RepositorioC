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
            //Para comparar cadenas se utiliza Compare(String cadena1, String cadena2)
            int comparacion = 0;
            String nombre = "César";

            //Se lleva a cabo la comparación
            comparacion = String.Compare("Pedro", nombre);

            if (comparacion == 0)
                Console.WriteLine("Los nombres son iguales");
            else
                Console.WriteLine("Los nombres son diferentes");

            //Con Equals se puede saber si 2 cadenas son iguales, Equals(String cadena1, String cadena2) Devuelve true o false
            String cadena1 = "Hola";
            String cadena2 = "Hola";

            if (String.Equals(cadena1, cadena2))
                Console.WriteLine("Las cadenas son iguales");
            else
                Console.WriteLine("Las cadenas son diferentes");
            
        }
    }
}
