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
            //Para subdividir una cadena se utiliza Split, recibe un arreglo y después el caracter o caracteres para subdividir
            String cadena1 = "Hola, este es un ejemplo; para subdividir una. Cadena";
            //Separará la cadena si encuentra una coma, un punto y coma o un punto
            String[] resultado = cadena1.Split(new char[] { ',', ';', '.' });

            //Para acceder se utilizan el índice normalmente
            for (int i = 0; i < resultado.Length; i++)
            {
                Console.WriteLine(resultado[i]);
            }

            Console.WriteLine("\n===================\n");

            //Se puede formatear usando mayúsculas o minúsculas usando ToLower o ToUpper
            String cadenaMin = "cadena minúscula";
            String cadenaMay = "CADENA MAYÚSCULA";

            Console.WriteLine("A MAYUS: "+cadenaMin.ToUpper());
            Console.WriteLine("A minus: "+cadenaMay.ToLower());

            Console.WriteLine("\n===================\n");

            //Podar una cadena, eliminar espacios al inicio y final se usa Trim
            //Trim devuelve una cadena sin espacios al inicio y al final
            String cadena2 = "    México es un país muy grande                ";
            Console.WriteLine(cadena2 + ", vengo de ahí");
            Console.WriteLine(cadena2.Trim() + ", vengo de ahí");

            Console.WriteLine("\n===================\n");

            //TrimStart recibe los caracteres a eliminar, para "podar" el inicio de la cadena
            String cadena3 = " xxxx ____ ---- (((( México es un país muy grande";
            String cadena4 = "México es un país muy grande xxxx ____ ---- ((((";
            Console.WriteLine(cadena3);
            Console.WriteLine(cadena3.TrimStart(' ', 'x', '_', '-','('));
            Console.WriteLine();
            Console.WriteLine(cadena4);
            Console.WriteLine(cadena4.TrimEnd(' ', 'x', '_', '-', '('));
        }
    }
}
