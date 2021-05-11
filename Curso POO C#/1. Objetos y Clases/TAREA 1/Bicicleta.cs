using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Bicicleta
    {
        //Variables y métodos
        public String marca, modelo, color;
        public int rodada, velocidades;

        //Hay Métodos estáticos y métodos de instancia, se accede a ellos a través de instancias de objetos

        //acceso modificador tipo identificador parámetros
        public void Acelerar()
        {
            Console.WriteLine("Acelerando");
        }

        public void Frenar()
        {
            Console.WriteLine("Frenando");
        }

        public void CambioVelocidad()
        {
            Console.WriteLine("Cambio de velocidad");
        }

        public void Informacion()
        {
            Console.WriteLine("Información de la bicicleta:");
            Console.WriteLine("MARCA: {0}",marca);
            Console.WriteLine("MODELO: {0}",modelo);
            Console.WriteLine("COLOR: {0}",color);
            Console.WriteLine("RODADA: {0}",rodada);
            Console.WriteLine("VELOCIDADES: {0}\n",velocidades);
        }


    }
}
