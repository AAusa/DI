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
