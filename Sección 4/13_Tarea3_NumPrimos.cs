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
            //Hacer un programa que calcule los números primos que existen entre el 1 y el 100
            int num, divisor, nDivisores = 0;

            //Primer bucle, recorre hasta el 100
            for(num =1; num <=100; num++)
            {
                //Segundo bucle, verifica cuántos divisores hay
                for (divisor = 1; divisor <= num; divisor++)
                {
                    //Si el residuo del número y divisor es 0, el contador aumenta
                    if(num % divisor == 0)
                    {
                        nDivisores++;
                    }
                }
                //Si el número de divisores es menor o igual a 2, entonces es primo y se imprime
                if(nDivisores <= 2)
                {
                    if(num != 1)
                    {
                        Console.WriteLine(num);
                    }
                }
                //Se reinicia el contador de divisores
                nDivisores = 0;
            }
        }
    }
}
