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
                System.Console.WriteLine("|");
            }
            // Linea tablero dcha.:
            for (int contadorY = 0; contadorY < 21; contadorY++)
            {
                Console.SetCursorPosition(x + 11, contadorY + y);
                System.Console.WriteLine("|");
            }
            // Linea tablero arriba.:
            for (int contadorX = 0; contadorX < 10; contadorX++)
            {
                Console.SetCursorPosition(contadorX+x+1, y);
                System.Console.WriteLine("-");
            }
            // Linea tablero abajo:
            for (int contadorX = 0; contadorX < 10; contadorX++)
            {
                Console.SetCursorPosition(contadorX +x+1, y+20);
                System.Console.WriteLine("-");
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
        }

        //Representa el tablero final de un jugador/máquina
        public static void DibujaFinal(Barco [] B, int x, int y)
        {
            //Debe dibujar:
            //              Rojo si una coordenada es barco
            //              Azul si si una coordenada es agua
            //x e y representan la posición en la que quiero que aparezca el tablero

            //B --> Array de barcos

            //Para dibujar agua o barco puede convenir utilizar el método CoordenadaEnBarcos (static) de la clase tablero

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


        }
    }
}
