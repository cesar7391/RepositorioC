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
        enum meses
        {
            Enero, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto, Septiembre, Octubre, Noviembre, Diciembre
        };

        enum colores
        {
            Rojo=4,Negro,Morado
        };

        static void Main(string[] args)
        {
            //Se declara y asigna la variable meses
            meses miMes = meses.Octubre;
            //Se pasa de enumeración a int
            int nMes = (int)miMes;
            //Se muestra la información
            Console.WriteLine("El mes de {0} tiene un valor de índice de {1}", miMes, nMes);

            colores miColor = colores.Negro;
            int nColor = (int)miColor;
            Console.WriteLine("El color {0} tiene un valor del índice de {1}", miColor, nColor);
        }        
    }
}
