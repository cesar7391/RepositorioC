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
            decimal r; //Almacena el valor devuelto por el método Resta() o Dividir()
            decimal n1Ar, n2Ar; //Se usarán como argumentos para un método

            //Se declara una tupla
            (decimal n1, decimal n2, decimal resultado) tuplaNum;

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
                    tuplaNum = Restar();
                    Console.WriteLine("{0} - {1} = {2}", tuplaNum.n1, tuplaNum.n2, tuplaNum.resultado);

                    break;
                case 3:
                    n1Ar = IngresarNumero("Primer número: ");
                    n2Ar = IngresarNumero("Segundo número: ");
                    Multiplicar(n1Ar, n2Ar);

                    break;
                case 4:
                    n1Ar = IngresarNumero("Primer número: ");
                    n2Ar = IngresarNumero("Segundo número: ");
                    tuplaNum = Dividir(n1Ar, n2Ar);
                    Console.WriteLine("{0} / {1} = {2}", tuplaNum.n1, tuplaNum.n2, tuplaNum.resultado);

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

        //Método que devuelve un valor
        static (decimal, decimal, decimal) Restar()
        {
            //Variables locales
            decimal n1, n2, resultado;

            Console.Write("Primer número: ");
            n1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Segundo número: ");
            n2 = Convert.ToDecimal(Console.ReadLine());

            resultado = n1 - n2;

            //Se devuelven múltiples valores
            return (n1, n2, resultado);
        }

        //Método que recibe valores
        static void Multiplicar(decimal n1, decimal n2)
        {
            decimal resultado = n1 * n2;
            Console.WriteLine("{0} x {1} = {2}", n1, n2, resultado);
        }

        //Método que recibe valores y devuelve otro
        static (decimal, decimal, decimal) Dividir(decimal n1, decimal n2)
        {
            decimal resultado;

            if (n2 != 0)
            {
                resultado = n1 / n2;
            }
            else
            {
                Console.WriteLine("NO SE PUEDE DIVIDIR ENTRE 0");
                resultado = 0;
            }

            return (n1, n2, resultado);
        }

        //Método para devolver número
        static decimal IngresarNumero(string peticion)
        {
            //variable local
            decimal numero;

            Console.Write(peticion);
            numero = Convert.ToDecimal(Console.ReadLine());

            return numero;
        }

    }
}