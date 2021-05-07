using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion7
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil auto = new Automovil();
            auto.Acelerar();
        }        
    }

    //[Modificador de acceso (por defecto es "internal"] class [identificador]
    public class Automovil
    {
        //Campos
        public string color, modelo, combustible;
        public byte año, nPuertas;
        public int ccmotor;

        public bool Acelerar()
        {
            bool acelerar = true;
            Console.WriteLine("El auto está acelerando");
            return acelerar;
        }

        public bool Frenar()
        {
            bool frenar = true;
            Console.WriteLine("El auto frenó");
            return frenar;
        }

        public void Velocidades(ref byte velocidad)
        {
            velocidad++;
            Console.WriteLine("Cambio de velocidad");
        }

    }
}
