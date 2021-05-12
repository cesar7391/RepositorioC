using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Matematicas
    {
        private double num1, num2, resultado;

        public double Num1
        {
            get { return num1; }
            set { num1 = value; }
        }

        public double Num2
        {
            get { return num2; }
            set 
            {
                if (value != 0)
                    num2 = value;
                else               
                    Console.WriteLine("No se puede dividir entre 0");                
            }
        }

        public double Resultado
        {
            get { return resultado; }
        }

        public void Suma()
        {
            resultado = num1 + num2;            
        }

        public void Resta()
        {
            resultado = num1 - num2;
        }

        public void Multiplicacion()
        {
            resultado = num1 * num2;
        }

        public void Division()
        {
            resultado = num1 / num2;
        }
    }
}
