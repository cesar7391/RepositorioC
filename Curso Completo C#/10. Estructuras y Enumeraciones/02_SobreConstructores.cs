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
            //Declarando la estructura
            Agenda persona = new Agenda("Ignacio", 24, "9516485521");

            Console.WriteLine(persona.ToString());

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

            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Nombre: {0}, Edad: {1}, Teléfono: {2}", Nombre, Edad, Telefono);
                return sb.ToString();
            }
        }
    }
}
