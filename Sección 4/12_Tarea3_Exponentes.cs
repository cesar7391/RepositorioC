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
            int numero, exponente, i;
            double resultado = 1;

            Console.Write("Ingresa el número base: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el exponente: ");
            exponente = Convert.ToInt32(Console.ReadLine());

            if(exponente >= 1) //Si el exponente es positivo
            {
                for (i = 1; i <= exponente; i++)
                {
                    resultado *= numero;
                }
                Console.WriteLine("{0}^{1} = {2}", numero, exponente, resultado);
            }
            else
            {
                if(exponente < 0) //si el exponente es negativo
                {
                    exponente = exponente * -1; //Se pasa el exponente a positivo para poder recorrer

                    //Se hace lo mismo, pero ahora 1 se dividirá sobre el resultado
                    for (i = 1; i <= exponente; i++)
                    {
                        resultado *= numero;
                    }
                    resultado = 1 / resultado;

                    Console.WriteLine("{0}^-{1} = {2}", numero, exponente, resultado);
                }
            }
        }
    }
}
