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
            bool encontrado = false;
            object valor;

            //Se crea el Stack
            Stack pila = new Stack();

            do
            {
                //Se muestra el menú
                Console.WriteLine("1. Push | 2. Pop | 3. Clear | 4. Contains | 5. Mostrar pila | 6. SALIR");

                Console.WriteLine("Elige una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Introducir valor: ");
                        valor = Console.ReadLine();
                        pila.Push(valor);
                        Console.WriteLine("===============");
                        Console.WriteLine("Valor introducido");
                        Console.WriteLine("===============");
                        break;
                    case 2:
                        valor = pila.Pop();
                        Console.WriteLine("===============");
                        Console.WriteLine("El valor obtenido es: {0}", valor);
                        Console.WriteLine("===============");
                        break;
                    case 3:
                        pila.Clear();
                        Console.WriteLine("===============");
                        Console.WriteLine("Se borraron los elementos de la pila");
                        Console.WriteLine("===============");
                        break;
                    case 4:
                        Console.WriteLine("Introducir valor para encontrar: ");
                        valor = Console.ReadLine();
                        encontrado = pila.Contains(valor);
                        if (encontrado)
                        {
                            Console.WriteLine("===============");
                            Console.WriteLine("ENCONTRADO");
                            Console.WriteLine("===============");
                        }
                        else
                        {
                            Console.WriteLine("===============");
                            Console.WriteLine("NO ENCONTRADO");
                            Console.WriteLine("===============");
                        }                            
                        break;
                    case 5:
                        Console.WriteLine("===============");
                        Console.WriteLine("La pila tiene {0} elemento(s):", pila.Count);
                        ImprimirPila(pila);
                        break;
                    case 6:
                        Console.WriteLine("===============");
                        Console.WriteLine("===============");
                        Console.WriteLine("PROGRAMA FINALIZADO");
                        Console.WriteLine("===============");
                        Console.WriteLine("===============");
                        break;
                    default:
                        Console.WriteLine("===============");
                        Console.WriteLine("Opción no válida");
                        Console.WriteLine("===============");
                        break;
                }
            } while (opcion != 6);
        }

        static void ImprimirPila(Stack pila)
        {
            foreach (object n in pila)
                Console.Write(" {0} ",n);

            Console.WriteLine("\n===============");
        }

    }
}
