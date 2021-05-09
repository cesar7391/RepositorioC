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
            Agenda persona0 = new Agenda("Ignacio", 24, "9516485521", "Privada Sta Rosa", 165);
            Console.WriteLine(persona0.ToString());

            Agenda persona1 = new Agenda("Daniel", 21, "9514455", "Tlaxiaco", 102);
            Console.WriteLine(persona1.ToString());

            Agenda persona2 = new Agenda("Marco", 29);
            Console.WriteLine(persona2.ToString());

            Agenda persona3 = new Agenda("Lenin");
            Console.WriteLine(persona3.ToString());

        }

        public struct Agenda
        {
            public String Nombre;
            public int Edad;
            public String Telefono;
            public Direccion Domicilio;

            public Agenda(String pNombre, int pEdad, String pTelefono, String pCalle, int pNumero)
            {
                Nombre = pNombre;
                Edad = pEdad;
                if (pTelefono.Length == 10)
                    Telefono = pTelefono;
                else
                    Telefono = "Sin asignar";

                //Se declara el domicilio pasándole los datos
                Domicilio = new Direccion(pCalle, pNumero);
                
            }

            public Agenda(String pNombre)
            {
                Nombre = pNombre;

                Console.Write("Ingresa la edad: ");
                Edad = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresa el teléfono: ");
                Telefono = Console.ReadLine();

                if(Telefono.Length != 10)
                    Telefono = "Sin asignar";

                Domicilio = new Direccion("Sin dirección", 0);
            }

            public Agenda(String pNombre, int pEdad)
            {
                Nombre = pNombre;
                Edad = pEdad;
                Telefono = "Sin teléfono";
                Domicilio = new Direccion("Sin dirección", 0);
            }

            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Nombre: {0}, Edad: {1}, Teléfono: {2}", Nombre, Edad, Telefono);

                //Se agrega la cadena proveniente de Direccion
                sb.Append(" Dirección: " + Domicilio.ToString());

                return sb.ToString();
            }
        }

        public struct Direccion
        {
            public String Calle;
            public int Numero;

            public Direccion(String pCalle, int pNumero)
            {
                Calle = pCalle;
                Numero = pNumero;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Calle {0} #{1}", Calle, Numero);
                return sb.ToString();
            }
        }
    }
}
