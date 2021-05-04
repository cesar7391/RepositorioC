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
            String nombre;
            String entrada;
            int num1 = 5, num2, resultado;

            //Se piden y se leen los datos para asignarse al String nombre
            Console.Write("¿Cómo te llamas? ");
            nombre = Console.ReadLine();

            //Se muestra el resultado
            Console.WriteLine("Hola {0}, un gusto", nombre);

            //=== CONVERTIR CADENA A TIPO NUMÉRICO ===
            //Pregunta al usuario el número
            Console.Write("Escribe un número para sumarlo: ");
            entrada = Console.ReadLine();

            //Se le asigna a num2 la conversión de la cadena a int
            num2 = Convert.ToInt32(entrada);
            //num2 = Int32.Parse(entrada); También es válido
            resultado = num1 + num2;
            Console.WriteLine("El resultado es: {0}", resultado);
        }
    }
}
