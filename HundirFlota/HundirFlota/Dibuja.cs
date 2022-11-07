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
            for (int contadorY = 0; contadorY < 20; contadorY++)
            {
                Console.SetCursorPosition(x, contadorY+y);
                System.Console.WriteLine("|");
            }

            //// Linea tablero dcha.:
            for (int contadorY = 0; contadorY < 20; contadorY++)
            {
                Console.SetCursorPosition(x+11, contadorY + y);
                System.Console.WriteLine("|");
            }
            //// Linea tablero arriba.:
            for (int contadorX = 0; contadorX < 10; contadorX++)
            {
                Console.SetCursorPosition(contadorX + x, y);
                System.Console.WriteLine("-");
            }
            /*
            // Lineas horizontales tablero:
            for (int cY = y; cY < y + 21; cY++)//Va incrmeentando el ejeY
            {
                if (cY % 2 == 0) //En las lineas pares
                {
                    for (int cX = x; cX < x + 12; cX++)//Escribir linea horizontal
                    {
                        Console.SetCursorPosition(cX, cY);
                        if (cX == x || cX == x + 11)//En los extremos se pone *
                        {
                            System.Console.Write("*");
                        }
                        else
                        {
                            System.Console.Write("-");
                        }
                    }
                }
            }
            */
        }

        //Representa el tablero de juego de un jugador
        public static void TableroJuego(Tablero T, int x, int y)
        {
            //Debe dibujar: Gris si una coordenada no ha sido elegida por el usuario
            //              Rojo si el usuario ha elegido una coordenada y esa coordenada es barco
            //              Azul si el usuario ha elegido una coordenada y esa coordenada es agua
            //x e y representan la posición en la que quiero que aparezca el tablero


            //Tablero.Mar --> Array bidireccional en donde cada compoente vale true or false en función de 
            //si el usuario ha elegido una coordenada determinada
            //Tablero.Barcos --> Array de barcos

            //Para dibujar agua o barco puede convenir utilizar el método creaBarco de la clase Barco

            
            for (int cY = y; cY < y + 21; cY++)//Va incrmeentando el ejeY
            {
                if (cY % 2 != 0) //En las lineas impares
                {
                    for (int cX = x + 1; cX < x + 11; cX++)//Escribir linea horizontal
                    {
                        Console.SetCursorPosition(cX, cY);
                        System.Console.Write("x");
                    }
                }
            }
            
            /*
            INTENTO CON MAR
            for (int cY = y; cY < y + 21; cY++)//Va incrmeentando el ejeY
            {
                if (cY % 2 != 0) //En las lineas impares
                {
                    for (int cX = x+1; cX < x + 11; cX++)//Escribir linea horizontal
                    {
                        Console.SetCursorPosition(cX, cY);
                        if(T.Mar[cX, cY] == false)
                        {
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.Write(" ");
                        }
                    }
                }
            }
            */
        }


        //Representa el tablero final de un jugador/máquina
        public static void DibujaFinal(Barco[] B, int x, int y)
        {

            //Debe dibujar:
            //              Rojo si el usuario ha elegido una coordenada y esa coordenada es barco
            //              Azul si el usuario ha elegido una coordenada y esa coordenada es agua
            //x e y representan la posición en la que quiero que aparezca el tablero

            //B --> Array de barcos

            //Para dibujar agua o barco puede convenir utilizar el método creaBarco de la clase Barco
        }

    }
}
