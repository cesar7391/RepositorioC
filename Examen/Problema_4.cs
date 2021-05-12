using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            int nDias = 0;

            do
            {
                try
                {
                    Console.WriteLine("Ingresa el número de días: ");
                    nDias = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("EL VALOR INGRESADO NO ES UN NÚMERO ENTERO ");
                }                
                
            } while (nDias < 0);

            CalcularFecha(nDias);
            
        }

        static void CalcularFecha(int nDias)
        {
            int años = nDias / 365;
            int diasRestantes = nDias % 365;

            int meses = diasRestantes / 30;
            int diasS = diasRestantes % 30;

            Console.WriteLine("Equivale a {0} año(s), {1} mes(es) y {2} día(s).", años, meses, diasS);
        }
    }
}
