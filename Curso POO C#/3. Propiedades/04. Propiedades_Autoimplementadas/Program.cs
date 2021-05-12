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
            ClaseEjemplo Objeto1 = new ClaseEjemplo();

            Console.WriteLine("Ingresa un valor numérico: ");
            Objeto1.Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El valor del campo privado es {0}",Objeto1.Num1);

            Console.WriteLine("Escribe tu nombre: ");
            Objeto1.Nombre = Console.ReadLine();

            //Vemos si la asignación con SET fue correcta
            Console.WriteLine("El valor del campo privado nombre es: " + Objeto1.Nombre);
        }
    }
}
