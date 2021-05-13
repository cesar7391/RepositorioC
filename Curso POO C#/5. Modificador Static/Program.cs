using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando a la clase...
            Celular cel1 = new Celular(5.4, "Negro", "Samsung", "Android", 4300, true);

            cel1.Procesador = "Snapdragon 735";
            cel1.Informacion();            

            //Instanciamos a la clase de nuevo
            Celular cel2 = new Celular(6.2, "Plata", "Xiaomi", "Android", 5000, true);
            //El valor de procesador, al ser estático, se queda
            cel2.Informacion();

            //Instanciamos por 3ra vez
            Celular cel3 = new Celular(7.1, "Oro", "Huawei", "Android", 4000, false);
            //El valor de procesador, al ser estático, se queda
            cel3.Informacion();

            //SE CAMBIA A CEL2
            cel2.Procesador = "Bionic A10";

            //Instanciamos por 4ta vez
            Celular cel4 = new Celular(6.1, "Azul", "IPhone", "IOs", 4500, true);
            //Aunque se cambió el valor de procesador a cel2, como es compartido, es el que se muestra
            cel3.Informacion();

            Console.WriteLine();
            //Método estático, se llama poniendo el nombre de la clase.metodo
            Celular.MetodoEstatico();
        }


    }
}
