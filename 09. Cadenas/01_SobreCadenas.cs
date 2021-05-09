using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Trabajar con cadenas, El String se guarda como colección y cada caracter es un elemento
            String cadena = "";
            //Todo es un elemento, incluso el espacio vacío
            String cadena2 = "Cadena de ejemplo";

            //Para convertir datos a su representación en cadena, se uriliza ToString()
            int valorNum = 158;
            //"Esto imprime un String, no un int"
            Console.WriteLine(valorNum.ToString());

            //Sobre FECHAS
            DateTime horaActual = DateTime.Now;
            //String.Format permite dar formato particular...
            String fechaString = 
                String.Format("Hoy es {0:dddd}, la fecha es {0:dd/M/yyyy}",horaActual);
            Console.WriteLine("\n{0}", fechaString);

            //Concatenación, se utiliza el +
            String nombre = "César";
            String apellido = "Flores";
            String estadoN = "Oaxaca";
            Console.WriteLine("Me llamo " + nombre + " " + apellido + " y soy de " + estadoN);

            //Se puede usar Concat() para concatenar también
            String nombreCompleto = String.Concat(nombre," ",apellido);
            Console.WriteLine(nombreCompleto);

            //StringBuilder, permite construir cadenas
            StringBuilder sb = new StringBuilder("Hola Mundo");
            //Con Append se le concatena al StringBuilder
            sb.Append(", este es un string agregado");
            //Con AppendFormat se le pueden agregar otros valores y los transforma a cadena
            sb.AppendFormat(", Ahora se añade {0}", valorNum);
            Console.WriteLine(sb);      

        }
    }
}
