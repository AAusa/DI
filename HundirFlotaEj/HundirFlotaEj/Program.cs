    class Program
{
    static void Main(string[] args)
    {
        //Declaración de variables.
        int horizontal;
        int vertical;
        int barcos = 14;

        //Declaración de matrices y arrays.
        int[,] panel = {{1,1,1,0,0,0,0,0,0,0},
                            {0,0,0,0,0,0,0,0,0,0},
                            {0,0,0,1,1,0,0,1,0,0},
                            {0,0,0,0,0,0,0,1,0,0},
                            {0,0,0,0,0,0,0,0,0,0},
                            {0,0,0,0,0,0,0,0,0,0},
                            {1,0,0,0,0,0,0,0,0,0},
                            {1,0,0,1,1,1,1,0,0,0},
                            {1,0,0,0,0,0,0,0,0,0},
                            {0,0,0,0,0,0,0,0,0,0}};

        string[,] estado = {{"#","#","#","#","#","#","#","#","#","#"},
                                {"#","#","#","#","#","#","#","#","#","#"},
                                {"#","#","#","#","#","#","#","#","#","#"},
                                {"#","#","#","#","#","#","#","#","#","#"},
                                {"#","#","#","#","#","#","#","#","#","#"},
                                {"#","#","#","#","#","#","#","#","#","#"},
                                {"#","#","#","#","#","#","#","#","#","#"},
                                {"#","#","#","#","#","#","#","#","#","#"},
                                {"#","#","#","#","#","#","#","#","#","#"},
                                {"#","#","#","#","#","#","#","#","#","#"}};

        do
        {
            //Imprime el panel de aciertos y fallos
            Console.SetCursorPosition(0, 0); //Coloca el cursor en la posición indicada.
            Console.WriteLine("0123456789"); //Imprime la linea de coordenadas horizontales.
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("{0}", estado[i, j]);//Imprime lo que corresponda (#,T,A).
                }
                Console.WriteLine("{0}", i); //Cada vez que llega al final de una linea imprime el número de linea.
            }
            Console.WriteLine();
            Console.WriteLine("¡¡DISPARA!!");

            //Recoje las coordenadas horizontales.
            do
            {
                do
                {
                    Console.SetCursorPosition(0, 15);
                    Console.WriteLine("Coordenadas horizontales (0-9):");
                    Console.WriteLine("                               "); //Borra la linea escrita anteriormente.
                    Console.SetCursorPosition(0, 16);
                    horizontal = int.Parse(Console.ReadLine());
                } while (horizontal > 10); //Repite en el caso de que horizontal sea MAYOR que 10.
            } while (horizontal < 0); // O bien si es MENOR que 0.

            //Recoje las coordenadas verticales.
            do
            {
                do
                {
                    Console.SetCursorPosition(0, 17);
                    Console.WriteLine("Coordenadas verticales (0-9):");
                    Console.WriteLine("                             "); //Borra la linea escrita anteriormente.
                    Console.SetCursorPosition(0, 18);
                    vertical = int.Parse(Console.ReadLine());
                } while (vertical > 10); //Repite en el caso de que vertical sea MAYOR que 10.
            } while (vertical < 0); // O bien si es MENOR que 0.

            //Comprueba si ha acertado.
            if (panel[vertical, horizontal] == 1)   //Si aciertas...
            {
                Console.WriteLine("¡¡TOCADO!!");    //Muestra "tocado!"...
                panel[vertical, horizontal] = 0;    //deja vacio el lugar del barco.
                estado[vertical, horizontal] = "T"; //cambia el valor de la casilla. 
                barcos--;                           //...y le resta 1 a "barcos" (al llegar a 0 se acaba).
            }
            else if (panel[vertical, horizontal] == 0) //si no...y además el lugar está sin barco...
            {
                Console.WriteLine("¡¡AGUA!!");      //...muestra "agua!".
                estado[vertical, horizontal] = "A"; //cambia el valor de la casilla.
            }

        } while (barcos > 0);

        //Borra la pantalla y muestra el mensaje de que el jugador ha ganado.
        Console.Clear();
        Console.WriteLine("¡¡HAS GANADO!!");

    }
}
