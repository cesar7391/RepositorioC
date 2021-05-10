using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Seccion2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 8;
            double num2 = 4.5;
            double resultado;
            String saludo = "Hola";
            String nombre = "César";

            //Se suman 2 variables y se asignan a resultado
            resultado = num1 + num2;

            Console.WriteLine(5 + 5 + 8 - 2);

            Console.WriteLine((2*10)/5);
            
            Console.WriteLine(resultado);

            //Al sumar 2 cadenas se le llama concatenar
            Console.WriteLine(saludo + " " + nombre + ", ¿Cómo estás?");
        }
    }
}
