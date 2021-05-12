using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombreArg;
            ClaseEjemplo Objeto1 = new ClaseEjemplo();

            Console.WriteLine("El valor del campo privado es {0}",Objeto1.Num1);

            Console.WriteLine("Escribe tu nombre: ");
            nombreArg = Console.ReadLine();

            Objeto1.Nombre = nombreArg;

            //Vemos si la asignación con SET fue correcta
            Console.WriteLine("El valor del campo privado nombre es: " + Objeto1.Nombre);
        }
    }
}
