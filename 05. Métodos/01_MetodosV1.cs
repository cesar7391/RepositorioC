using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion5
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");

                Console.Write("Elige una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());
            }
            while (opcion < 1 || opcion > 4);         

            switch (opcion)
            {
                case 1:
                    Sumar();
                    break;
                case 2:
                    Restar();
                    break;
                case 3:
                    Multiplicar();
                    break;
                case 4:
                    Dividir();
                    break;
            }
        }

        //[modificador][tipo][identificador][parámetros]
        static void Sumar()
        {
            //Variables locales
            decimal n1, n2, resultado;

            Console.Write("Primer número: ");
            n1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Segundo número: ");
            n2 = Convert.ToDecimal(Console.ReadLine());

            resultado = n1 + n2;
            Console.WriteLine("{0} + {1} = {2}", n1, n2, resultado);
        }

        static void Restar()
        {
            //Variables locales
            decimal n1, n2, resultado;

            Console.Write("Primer número: ");
            n1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Segundo número: ");
            n2 = Convert.ToDecimal(Console.ReadLine());

            resultado = n1 - n2;
            Console.WriteLine("{0} - {1} = {2}", n1, n2, resultado);
        }

        static void Multiplicar()
        {
            //Variables locales
            decimal n1, n2, resultado;

            Console.Write("Primer número: ");
            n1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Segundo número: ");
            n2 = Convert.ToDecimal(Console.ReadLine());

            resultado = n1 * n2;
            Console.WriteLine("{0} x {1} = {2}", n1, n2, resultado);
        }

        static void Dividir()
        {
            //Variables locales
            decimal n1, n2, resultado;

            Console.Write("Primer número: ");
            n1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Segundo número: ");
            n2 = Convert.ToDecimal(Console.ReadLine());

            if(n2 != 0)
            {
                resultado = n1 / n2;
                Console.WriteLine("{0} / {1} = {2}", n1, n2, resultado);
            }
            else
            {
                Console.WriteLine("No se puede dividir entre 0");
            }

        }

    }
}
