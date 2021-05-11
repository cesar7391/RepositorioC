using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class ClasePrueba
    {
        //Este campo es conocido únicamente por todos los elementos de esta clase
        double z = 100;

        //Este campo tiene ambito de clase y lleva el mismo nombre que uno contenido en Informacion();
        double x = 150;

        public void Informacion()
        {
            //No se puede acceder a una variable local de Main
            //Console.WriteLine("Variable local de num1 = {0}", num1);

            double x = 30;

            //Se reconoce "x" sin problema por que es "conocida" en todo el método
            Console.WriteLine("Variable local de Informacion (x) = {0}", x);

            //Se usa el campo a nivel de clase
            Console.WriteLine("Variable a nivel de clase (z): {0}", z);

            //This es una palabra clave de acceso, sirve para hacer referencia a campos a nivel de clase
            Console.WriteLine("Variable local de Informacion (x) = {0}", this.x);
        }

        public void Suma()
        {
            double y = 20;
            double resultado;

            //No se puede acceder a "x" porque es una variable con ámbito a nivel de método
            //resultado = x + y;
            //Se debería crear una nueva variable "x"...
            double x = 55;
            resultado = x + y;
            Console.WriteLine("{0} + {1} = {2}", x, y, resultado);
        }
    }
}
