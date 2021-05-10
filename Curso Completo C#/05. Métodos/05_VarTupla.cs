using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables con asignación implícita de tipos
            var nombre = "César";
            var numero = 10;
            var numero2 = 12.3;
            var bandera = true;
            var letra = 'A';
            //Es útil cuando es difícil determinar el tipo de una variable
            //Se usa también para simplificar el código

            //USO DE TUPLA (referencia de C#)

            //Por ejemplo, para almacenar los datos de un usuario
            String nombreUsuario = "Luis";
            byte edad = 45;
            long id = 5533004466;
            int cPostal = 71220;

            //La sintaxis de Tupla es "(tipo) Identificador = (valor)"
            //La tupla es una variable que contiene 2 o más elementos que pueden ser de distintos tipos, se les conoce como campos
            (String, byte, long, int) persona1 = ("Luis", 45, 8866004466, 71220);
            //Podría usarse var también
            var persona2 = (nombre: "Alfonso", edad: 25, id: 8866554466, CP: 68220);

            //Para imprimir la Tupla
            Console.WriteLine(persona2);

            //Los campos de la tupla se identifican con el nombre de ITEMS comenzando en 1
            Console.WriteLine(persona2.nombre);
            Console.WriteLine(persona2.edad);
            Console.WriteLine(persona2.id);
            Console.WriteLine(persona2.CP);

        }     
    }
}
