using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion3
{
    class Program
    {
        static void Main(string[] args)
        {
            int tiempo;

            Console.Write("Tiempo de estacionamiento (minutos): ");
            tiempo = Convert.ToInt32(Console.ReadLine());

            if(tiempo >= 0 && tiempo <= 60)
            {
                Console.WriteLine("La tarifa es de $5.00");
            }
            else
            {
                if(tiempo > 60 && tiempo <= 120)
                {
                    Console.WriteLine("La tarifa es de $15.00");
                }
                else
                {
                    if(tiempo > 120)
                    {
                        Console.WriteLine("La tarifa es de $40.00");
                    }                    
                }
            }
        }
    }
}
