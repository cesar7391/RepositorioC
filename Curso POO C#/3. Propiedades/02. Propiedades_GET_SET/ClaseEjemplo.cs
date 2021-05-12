using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    class ClaseEjemplo
    {
        //Campo Privado
        private int num1;
        //private String nombre;

        //[acceso] [tipo] [nombre]
        public int Num1
        {            
            set { num1 = value; }
            get { return num1; }
        }

        public String Nombre
        {
            //set { nombre = value; }
            //get { return nombre; }
            get; set;
        }
    }
}
