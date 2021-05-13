using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO5
{
    class Celular
    {
        double pantalla;
        String color, marca, sO;
        int bateria;
        bool cargaRapida;
        //Campo estático que valdrá lo mismo para todos los objetos
        private static String procesador;

        public Celular(double pantalla, String color, String marca, String sO, int bateria, bool cargaRapida)
        {
            Console.WriteLine("CONSTRUCTOR DE INSTANCIA");
            this.pantalla = pantalla;
            this.color = color;
            this.marca = marca;
            this.sO = sO;
            this.bateria = bateria;
            this.cargaRapida = cargaRapida;
        }

        //Constructor estático
        static Celular()
        {
            Console.WriteLine("CONTRUCTOR ESTÁTICO");
        }

        public String Procesador
        {
            set { procesador = value; }
        }

        public void Informacion()
        {
            Console.WriteLine("Tamaño de la pantalla: {0}\" \nColor: {1}\nMarca: {2},\nSO: {3}\nBateria: {4} mAh\nCarga Rápida: {5}\nProcesador: \n{6} ",pantalla, color, marca, sO,bateria,cargaRapida, procesador);
            Console.WriteLine("=================");
        }

        public static void MetodoEstatico()
        {
            Console.WriteLine(procesador + " Versión 2021");
        }
    }
}
