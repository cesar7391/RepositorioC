using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Seccion8
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            object llave, valor;
            bool encontrado = false;

            Hashtable tabla = new Hashtable();

            do
            {
                Console.WriteLine("1. Agregar elemento");
                Console.WriteLine("2. Quitar elemento");
                Console.WriteLine("3. Clear");
                Console.WriteLine("4. Encontrar Key");
                Console.WriteLine("5. Encontrar Valor");
                Console.WriteLine("6. SALIR");

                Console.Write("Elige una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Introducir llave: ");
                        llave = Console.ReadLine();
                        Console.WriteLine("Introducir valor: ");
                        valor = Console.ReadLine();
                        //SE AGREGA LA PAREJA
                        tabla.Add(llave, valor);
                        break;
                    case 2:
                        Console.WriteLine("Introducir llave para eliminar: ");
                        llave = Console.ReadLine();
                        //SE QUITA LA PAREJA, SEGÚN LLAVE
                        tabla.Remove(llave);
                        break;
                    case 3:
                        tabla.Clear();
                        Console.WriteLine("ELEMENTOS ELIMINADOS");
                        break;
                    case 4:
                        Console.WriteLine("Introducir llave para encontrar: ");
                        llave = Console.ReadLine();
                        //SE BUSCA EL KEY
                        encontrado = tabla.Contains(llave);

                        if (encontrado)
                            Console.WriteLine("PAREJA ENCONTRADA");
                        else
                            Console.WriteLine("PAREJA NO ENCONTRADA");
                        break;
                    case 5:
                        Console.WriteLine("Introducir valor para encontrar: ");
                        valor = Console.ReadLine();
                        //SE BUSCA EL KEY
                        encontrado = tabla.ContainsValue(valor);

                        if (encontrado)
                            Console.WriteLine("VALOR ENCONTRADO");
                        else
                            Console.WriteLine("VALOR NO ENCONTRADO");
                        break;
                    case 6:
                        Console.WriteLine("============\n============");
                        Console.WriteLine("PROGRAMA FINALIZADO");
                        Console.WriteLine("============\n============");
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }

                ImprimirTabla(tabla);

            } while (opcion != 6);
        }

        static void ImprimirTabla(Hashtable tabla)
        {
            Console.WriteLine("============");
            foreach (DictionaryEntry datos in tabla)
                Console.WriteLine("[{0} - {1}]\t",datos.Key,datos.Value);
            Console.WriteLine("============");            
        }
    }
}
