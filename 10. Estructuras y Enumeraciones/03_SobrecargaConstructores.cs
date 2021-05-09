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
            //Declarando la estructura e imprimiendo con el override ToString()
            Agenda persona0 = new Agenda("Ignacio", 24, "9516485521");
            Console.WriteLine(persona0.ToString());

            Agenda persona1 = new Agenda("Daniel", 21, "9514455");
            Console.WriteLine(persona1.ToString());

            Agenda persona2 = new Agenda("Marco", 29);
            Console.WriteLine(persona2.ToString());

            Agenda persona3 = new Agenda("Lenin");
            Console.WriteLine(persona3.ToString());

        }

        //DEFINICIÓN DE UNA ESTRUCTURA... Sirve para encapsulad datos y su funcionalidad...
        public struct Agenda
        {
            public String Nombre;
            public int Edad;
            public String Telefono;

            //Un CONSTRUCTOR es un método que sirve para inicializar campos, siempre se llama como la estructura a la que pertenece, se invoca automáticamente cuando se hace una instancia de estructura, no tiene tipo y no devuelve nada.
            //Se puede validar la información antes de asignar, por ejemplo, el teléfono solo será valido si tiene 10 caracteres
            public Agenda(String pNombre, int pEdad, String pTelefono)
            {
                //Se lleva a cabo la asignación de valores
                Nombre = pNombre;
                Edad = pEdad;
                //Aquí se comprueba si el teléfono tiene 10 caracteres
                if (pTelefono.Length == 10)
                    Telefono = pTelefono;
                else
                    Telefono = "Sin asignar";
            }

            //PARA SOBRECARGAR UN CONSTRUCTOR SE DEBE HACER OTRA VERSIÓN, sepuede usar si se quieren pedir distintos datos

            //En este ejemplo, sólo se requiere Nombre y los otros datos se piden
            public Agenda(String pNombre)
            {
                Nombre = pNombre;

                Console.Write("Ingresa la edad: ");
                Edad = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresa el teléfono: ");
                Telefono = Console.ReadLine();

                if(Telefono.Length != 10)
                {
                    Telefono = "Sin asignar";
                }

                //Ningún campo se queda sin asignar
            }

            public Agenda(String pNombre, int pEdad)
            {
                Nombre = pNombre;
                Edad = pEdad;
                Telefono = "Sin teléfono";
            }

            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Nombre: {0}, Edad: {1}, Teléfono: {2}", Nombre, Edad, Telefono);
                return sb.ToString();
            }
        }
    }
}
