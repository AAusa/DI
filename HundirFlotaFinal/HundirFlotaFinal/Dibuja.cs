using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundir
{
    public class Dibuja
    //Se crean los métodos para dibujar en consola: Tablero usuario, tablero máquina y tablero final
    //Se puede utilizar cualquier método creado en las clases Barco, Tablero
    {

        //Dibuja el entorno del tablero. Recibe dos enteros que representan la posición en la que queremos que quede el tablero
        public static void DibujaCuadro(int x, int y)
        {
            //Opcional. Para dibujar los bordes del tablero. x e y representan la posición en la que quiero que 
            //aparezca el tablero

            // Linea tablero izq.:
            for (int contadorY = 0; contadorY < 21; contadorY++)
            {
                Console.SetCursorPosition(x, contadorY + y);
                System.Console.WriteLine("¡");
            }
            // Linea tablero dcha.:
            for (int contadorY = 0; contadorY < 21; contadorY++)
            {
                Console.SetCursorPosition(x + 11, contadorY + y);
                System.Console.WriteLine("!");
            }

            // Lineas tablero horizontales.:
            for (int contadorY = 0; contadorY < 21; contadorY++)//Mueve ejeY
            {
                if (contadorY % 2 == 0)//En las lineas pares
                {
                    for (int contadorX = 0; contadorX < 10; contadorX++)////Mueve ejeX
                    {
                        Console.SetCursorPosition(contadorX + x + 1, contadorY + y);
                        System.Console.WriteLine("=");
                    }
                }
            }
        }

        //Representa el tablero de juego de un jugador
        public static void TableroJuegoUsuario(Tablero T, int x, int y)
        {
            //Este método se llamaba tableroJuego
            //Debe dibujar: Gris si una coordenada no ha sido elegida por el usuario
            //              Rojo si el usuario ha elegido una coordenada y esa coordenada es barco
            //              Azul si el usuario ha elegido una coordenada y esa coordenada es agua
            //x e y representan la posición en la que quiero que aparezca el tablero


            //Tablero.Mar --> Array bidireccional en donde cada compoente vale true or false en función de 
            //si el usuario ha elegido una coordenada determinada
            //Tablero.Barcos --> Array de barcos

            //Para dibujar agua o barco puede convenir utilizar el método  CoordenadaEnBarcos de la clase Tablero
            DibujaCuadro(x, y);
            // Lineas tablero horizontales.:
            for (int contadorY = 0; contadorY < 10; contadorY++)//Mueve ejeY donde hay huecos
            {
                for (int contadorX = 0; contadorX < 10; contadorX++)////Mueve ejeX
                {
                    Console.SetCursorPosition(contadorX + x + 1, contadorY * 2 + 1 + y);
                    if (T.Mar[contadorX, contadorY] == false)//Coordenada no elegida
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        System.Console.WriteLine(" ");
                    }
                    else
                    {
                        if (T.CoordenadaEnBarcos(contadorX, contadorY))//Si hay barco
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            System.Console.WriteLine(" ");
                        }
                        else//Si no hay barco
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            System.Console.WriteLine(" ");
                        }
                    }
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }

        //Representa el tablero final de un jugador/máquina
        public static void DibujaFinal(Barco[] B, int x, int y)
        {
            //Debe dibujar:
            //              Rojo si una coordenada es barco
            //              Azul si si una coordenada es agua
            //x e y representan la posición en la que quiero que aparezca el tablero

            //B --> Array de barcos

            //Para dibujar agua o barco puede convenir utilizar el método CoordenadaEnBarcos (static) de la clase tablero
            DibujaCuadro(x, y);
            // Lineas tablero horizontales.:
            for (int contadorY = 0; contadorY < 10; contadorY++)//Mueve ejeY donde hay huecos
            {
                for (int contadorX = 0; contadorX < 10; contadorX++)////Mueve ejeX
                {
                    Console.SetCursorPosition(contadorX + x + 1, contadorY * 2 + 1 + y);
                    if (Tablero.CoordenadaEnBarcos(B, contadorX, contadorY) == true)//Barco
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        System.Console.WriteLine(" ");
                    }
                    else//Si no hay barco
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        System.Console.WriteLine(" ");
                    }
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;

        }

        //Representa el tablero de juego de la maquina
        public static void TableroJuegoMaquina(Tablero T, int x, int y)
        //Debe dibujar:
        //              Rojo si una coordenada es barco
        //              Azul si si una coordenada es agua
        //              X si una coordenada ha sido elegida por la máquina
        //x e y representan la posición en la que quiero que aparezca el tablero

        //B --> Array de barcos

        //Para dibujar agua o barco puede convenir utilizar el método creaBarco de la clase Barco
        {

            DibujaCuadro(x, y);
            // Lineas tablero horizontales.:
            for (int contadorY = 0; contadorY < 10; contadorY++)//Mueve ejeY donde hay huecos
            {
                for (int contadorX = 0; contadorX < 10; contadorX++)////Mueve ejeX
                {
                    Console.SetCursorPosition(contadorX + x + 1, contadorY * 2 + 1 + y);
                    if (T.Mar[contadorX, contadorY] == true)//Coordenada elegida
                    {
                        if (T.CoordenadaEnBarcos(contadorX, contadorY))//Si hay barco se escribe X en rojo
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            System.Console.WriteLine("X");
                        }
                        else//No hay barco se escribe X en azul
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            System.Console.WriteLine("X");
                        }
                    }
                    else
                    {
                        if (T.CoordenadaEnBarcos(contadorX, contadorY))//Si hay barco
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            System.Console.WriteLine(" ");
                        }
                        else//Si no hay barco
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            System.Console.WriteLine(" ");
                        }
                    }
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}

