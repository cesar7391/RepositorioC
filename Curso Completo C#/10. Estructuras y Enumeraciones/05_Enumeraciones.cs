using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion10
{
    class Program
    {
        //Para declarar una enumeración se utiliza enum
        enum diasSemana
        {
            //Si se asigna un index, entonces los siguientes valores lo continúan
            Lunes = 5, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo
        };

        static void Main(string[] args)
        {
            //ENUMERACIONES, son tipos que podemos definir, pero tienen un número finito de valores posibles, son útiles cuando hay valores definidos qué usar...

            //Sólo tiene los valores declarados en la enum
            diasSemana dia;

            //Se asigna el valor predefinido así
            dia = diasSemana.Lunes;

            //Devuelve la cadena con el valor enumerado
            Console.WriteLine("El día es: {0}", dia);
            Console.WriteLine("El día es: {0}", dia.ToString());

            //Para obtener la posición del índice de la enumeración sólo se hace un cast, para obtenerlo            
            int valor = (int)dia;
            //Aquí devuelve 5 porque Lunes se cambió a 5
            Console.WriteLine("El índice del día es: " + valor);
            
            //El type cast se hace con paréntesis y tipo, después del valor a convertir
        }        
    }
}
