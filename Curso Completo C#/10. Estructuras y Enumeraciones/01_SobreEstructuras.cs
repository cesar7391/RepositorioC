using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Para crear una nueva variable
            Agenda persona;

            Agenda persona1, persona2, persona3;

            Agenda[] personas = new Agenda[15];
            Agenda[] clientes = new Agenda[3];

            //Para acceder se puede hacer de la siguiente manera: VariableEstructura.Campo
            //En este caso se está asignando un valor a la estructura
            persona.Edad = 25;
            persona.Nombre = "Ricardo";
            persona.Telefono = "9513054466";

            //Para mostrar los datos de la estructura se puede hacer así:
            Console.WriteLine("La edad de la persona es {0}",persona.Edad);

            Console.WriteLine(persona.ToString());

        }

        //DEFINICIÓN DE UNA ESTRUCTURA... Sirve para encapsulad datos y su funcionalidad...
        public struct Agenda
        {
            public String Nombre;
            public int Edad;
            public String Telefono;

            //Se usa override para hacer un método
            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Nombre: {0}, Edad: {1}, Teléfono: {2}", Nombre, Edad, Telefono);
                return sb.ToString();
            }
        }
    }
}
