using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    //JUEGO DEL GATO
    class Program
    {        
        //Arreglo bidimensional de 3x3 para el tablero del juego
        static int[,] tablero = new int[3,3];
        //Arreglo con las "fichas" del juego, contiene 3 elementos, el espacio en blanco, 'O' y 'X'
        static char[] simbolo = {' ','O','X'};

        static void Main(string[] args)
        {
            bool fin = false;

            Console.WriteLine("JUEGO DEL GATO");
            //Dibuja el tablero inicial
            DibujarTablero();
            Console.WriteLine("JUGADOR 1 = O\nJUGADOR 2 = X");

            do
            {
                //Turno del jugador 1 y se comprueba si hay ganador o hay empate
                Posicionar(1);
                fin = ComprobarGanador();

                if (fin == true)
                    Console.WriteLine("¡GANÓ EL JUGADOR 1!");
                else
                {
                    fin = ComprobarEmpate();

                    if (fin == true)
                        Console.WriteLine("¡EMPATE!");

                    //Si el jugador 1 no ganó ni hubo empate, entonces le toca al jugador 2
                    else
                    {
                        Posicionar(2);
                        fin = ComprobarGanador();

                        if (fin == true)
                            Console.WriteLine("¡GANÓ EL JUGADOR 2!");
                    }
                }
            } while (!fin);
        }

        static void DibujarTablero()
        {
            //Variables para ciclo
            int fila, columna;

            Console.WriteLine();
            Console.WriteLine("============="); //Dibuja la primera línea horizontal
            for (fila = 0; fila < 3; fila++)
            {
                Console.Write("|"); //Dibuja las primeras líneas verticales
                for (columna = 0; columna < 3; columna++)
                {
                    //Asigna un espacio, O o X, según corresponda, luego coloca la línea vertical
                    Console.Write(" {0} |",simbolo[tablero[fila,columna]]);
                }
                Console.WriteLine("\n============="); //Dibuja las siguientes líneas horizontales
            }
            Console.WriteLine();
        }

        //Pregunta dónde escribir y lo dibuja en el tablero
        static void Posicionar(int jugador)
        {
            int fila, columna;

            do
            {
                Console.WriteLine();
                Console.WriteLine("Turno del JUGADOR {0}",jugador);

                //Se pide la fila
                do
                {
                    Console.Write("Fila (1 a 3): ");
                    fila = Convert.ToInt32(Console.ReadLine());

                } while (fila < 1 || fila > 3); //Se repite mientras no se introduzca un valor aceptable

                //Se pide la columna
                do
                {
                    Console.Write("Columna (1 a 3): ");
                    columna = Convert.ToInt32(Console.ReadLine());

                } while (columna < 1 || columna > 3);

                if(tablero[fila-1,columna-1] != 0) //Se comprueba si la posición está ocupada   
                    Console.WriteLine("¡LA CASILLA ESTÁ OCUPADA!");

            } while (tablero[fila - 1, columna - 1] != 0); //Se repite mientras la posición ya esté ocupada

            //Si los datos introducidos son correctos, entonces se asigna la posición
            tablero[fila - 1, columna - 1] = jugador;

            DibujarTablero();
        }

        //Comprueba ganador, devuelve un valor true si hay 3 caracteres iguales en línea (horizontal, vertical o diagonal)
        static bool ComprobarGanador()
        {
            int fila, columna;
            bool gato = false;

            //COMPRUEBA GANADOR POR FILA
            for(fila = 0; fila < 3; fila++)
            {
                //Comprueba si el elemento 0 en la fila sea igual al elemento 1 y 2 de la fila, además de que ese elemento no sea 0
                if ((tablero[fila, 0] == tablero[fila, 1]) && 
                    (tablero[fila, 0] == tablero[fila, 2]) && 
                    (tablero[fila, 0] !=  0))                
                    gato = true;
            }

            //COMPRUEBA GANADOR POR COLUMNA
            for (columna = 0; columna < 3; columna++)
            {
                //Comprueba si el elemento 0 en la columna sea igual al elemento 1 y 2 de la columna, además de que ese elemento no sea 0
                if ((tablero[0, columna] == tablero[1, columna]) &&
                    (tablero[0, columna] == tablero[2, columna]) &&
                    (tablero[0, columna] != 0))
                    gato = true;
            }

            //COMPRUEBA GANADOR POR DIAGONAL 1
            if ((tablero[0, 0] == tablero[1, 1]) &&
                (tablero[0, 0] == tablero[2, 2]) &&
                (tablero[0, 0] != 0))
                gato = true;

            // COMPRUEBA GANADOR POR DIAGONAL 2
            if ((tablero[0, 2] == tablero[1, 1]) &&
                (tablero[0, 2] == tablero[2, 0]) &&
                (tablero[0, 2] != 0))
                gato = true;

            return gato;
        }

        //Comprueba si hay posibilidad de jugar, devuelve true si lo hay
        static bool ComprobarEmpate()
        {
            bool hayEspacio = false;
            int fila, columna;

            for (fila = 0; fila < 3; fila++)
            {
                for (columna = 0; columna < 3; columna++)
                {
                    //Si encuentra un espacio vacío, entonces queda espacio, por lo que se puede seguir jugando
                    if (tablero[fila, columna] == 0)
                        hayEspacio = true;
                }
            }

            //En caso de que no haya espacio (false) entonces devuelve un (true) para "empate" pues ya no se puede jugar más
            return !hayEspacio;
        }
    }
}
