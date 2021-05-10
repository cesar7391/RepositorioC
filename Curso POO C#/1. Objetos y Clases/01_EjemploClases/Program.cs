using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Bicicleta Bicicleta1 = new Bicicleta();

            //objeto.campo_para_acceder = valor;
            Bicicleta1.marca = "Benotto";
            Bicicleta1.modelo = "BMX-45";
            Bicicleta1.color = "Negro";
            Bicicleta1.rodada = 26;
            Bicicleta1.velocidades = 5;

            //objeto.metodo para acceder a los métodos
            Bicicleta1.Acelerar();
            Bicicleta1.Frenar();
            Bicicleta1.CambioVelocidad();
            Bicicleta1.Informacion();

            Console.WriteLine("\n====================\n");

            //Creando un segundo objeto
            Bicicleta Bicicleta2 = new Bicicleta();           

            Bicicleta2.marca = "Factor";
            Bicicleta2.modelo = "X65";
            Bicicleta2.color = "Vino";
            Bicicleta2.rodada = 21;
            Bicicleta2.velocidades = 8;

            Bicicleta2.Informacion();

            Console.WriteLine("\n====================\n");

            Calculadora Calculador1 = new Calculadora();

            Calculador1.n1 = 55;
            Calculador1.n2 = 45;

            Calculador1.Suma();
            Calculador1.Resultado();

        }
    }
}
