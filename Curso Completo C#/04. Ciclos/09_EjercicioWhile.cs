using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion4
{
    class Program
    {
        static void Main(string[] args)
        {
            String pass1, pass2="";

            Console.Write("Escribe tu nueva contraseña: ");
            pass1 = Console.ReadLine();

            while (pass1 != pass2)
            {
                Console.Write("Confirma tu contraseña: ");
                pass2 = Console.ReadLine();
            }

            Console.WriteLine("¡Contraseña actualizada correctamente!");
        }
    }
}
