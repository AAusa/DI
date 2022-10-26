class Program
{
    static void Main(string[] args)
    {
        new Program().Menu();
    }
    int barcoMaquinaX = 0, barcoMaquinaY = 0;
    int barcoUsuarioX = 0, barcoUsuarioY = 0;
    int coordenadaBarcoMaquinaX = 0, coordenadaBarcoMaquinaY = 0;
    int coordenadaBarcoUsuarioX = 0, coordenadaBarcoUsuarioY = 0;
    bool fijarBarcoMaquina = false;
    bool fijarBarcoUsuario = false;
    int k;
    void Menu()
    {
        bool ejecutar = false;
        //Limites no de tablero sino de juego:
        //      x = 1 - 10
        //      y = 1 - 10 
        int posX = 1, posY = 10;
        for (k = 0; ;k++)
        {
            //if(k == 0) 
            PintaMenu(posX, posY);
            if (k == 0) generarBarco(posX, posY);
            ConsoleKeyInfo cki = Console.ReadKey(true);
            // k se convierta en x,y que se van incrementando y en pintarMenu se controla cual se pinta con setPosition
            switch (cki.Key)
            {
                case ConsoleKey.UpArrow: posY++; break;
                case ConsoleKey.DownArrow: posY--; break;
                case ConsoleKey.RightArrow: posX++; break;
                case ConsoleKey.LeftArrow: posX--; break;
                case ConsoleKey.Enter:
                    Console.WriteLine("Enter");
                    if (!fijarBarcoUsuario) generarBarco(posX, posY); fijarBarcoUsuario = true;
                    //ejecutar = true; 
                    break;
            }
            //limites tablero x e y:
            if (posX > 10) posX = 1;
            if (posX < 1) posX = 10;
            if (posY > 10) posY = 1;
            if (posY < 1) posY = 10;

            if (ejecutar)
            {
                ejecutar = false;
                switch (posY)
                {
                    case 0: Opcion1(); break;
                    case 1: Opcion2(); break;
                    case 2: return;
                }
            }
        }
    }

    /*
     * Limite tablero jugables:
     *      6,6 a 24,6
     *      6,15 a 24,15
     */
    void PintaMenu(int posX, int posY)
    {
        menuHorizontal();
        menuVertical();
        int contX = 1, contY = 10;
        //if(k == 0)
        //{
            //Pinta el fondo de cada celda
            for (int y = 6; y <= 15; y++) // coordenadas ejeY
            {
                for (int x = 6; x <= 24; x += 2)// coordenadas celdas vacias de ejeX
                {
                    Console.SetCursorPosition(x, y);// Todas las posiciones del tablero
                    if (y == coordenadaBarcoUsuarioY && x == coordenadaBarcoUsuarioX)
                    {
                        Console.BackgroundColor = (posX == contX++ && posY == contY) ? Console.BackgroundColor = ConsoleColor.Red : Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("O");
                    }
                    else
                    {
                        Console.BackgroundColor = (posX == contX++ && posY == contY) ? Console.BackgroundColor = ConsoleColor.Red : Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine(" ");
                    }
                }
                contX = 1;
                contY--;
            }
            Console.BackgroundColor = ConsoleColor.Black;
        //}
        /*
        else
        {
            //Pinta el fondo de cada celda
            for (int y = 6; y <= 15; y++) // coordenadas ejeY
            {
                for (int x = 6; x <= 24; x += 2)// coordenadas celdas vacias de ejeX
                {
                    Console.SetCursorPosition(x, y);// Todas las posiciones del tablero
                    if (y == coordenadaBarcoUsuarioY && x == coordenadaBarcoUsuarioX)
                    {
                        Console.WriteLine("O");
                    }
                    else
                    {
                        if(posX == contX++ && posY == contY)
                        {
                            Console.BackgroundColor = (posX == contX++ && posY == contY) ? Console.BackgroundColor = ConsoleColor.Red : Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("");
                        }

                    }
                }
                contX = 1;
                contY--;
            }
        }
        */

        /*
        Console.SetCursorPosition(5, 7);
        Console.ForegroundColor = k == 1 ? sel : cc;
        Console.WriteLine("2. Opción Dos");
        Console.SetCursorPosition(5, 9);
        Console.ForegroundColor = k == 2 ? sel : cc;
        Console.WriteLine("3. Salir");
        */

    }
    /*
     * Usado para generar barco de la maquina y del usuario, ambos aleatorios
     */
    private void generarBarco(int posX, int posY)
    {
        Random aleatorio = new Random();
        int x = aleatorio.Next(1, 19);//PosicionX barco
        int y = aleatorio.Next(8);//PosicionY barco
        if(!fijarBarcoMaquina)
        {
            barcoMaquinaX = x;
            barcoMaquinaY = y;
            coordenadaBarcoMaquinaX = (x % 2 == 0) ? x + 6 : x + 5;
            coordenadaBarcoMaquinaY = y + 6;

            //Traducir posiciones del juego a coordenadas tablero
            //      Y --> Puede generar de posicion 6 a 14
            //      X --> Puede generar de posicion 6 a 24

            Console.SetCursorPosition(coordenadaBarcoMaquinaX, coordenadaBarcoMaquinaY); //if para que no se coloque en las lineas verticales del tablero
            Console.WriteLine("X");
            fijarBarcoMaquina = true;
        }
        else
        {
            //GENERAR BARCO EN EL LUGAR QUE CORRESPONDE, NO ALEATORIO
            //barcoUsuarioX = x;
            //barcoUsuarioY = y;
            //Traducir posiciones del juego a coordenadas tablero
            //      Y --> Puede generar de posicion 6 a 14
            //      X --> Puede generar de posicion 6 a 24
            //coordenadaBarcoUsuarioX = (x % 2 == 0) ? x + 6 : x + 5;
            //coordenadaBarcoUsuarioY = y + 6;
            Console.SetCursorPosition(6 + (posX - 1) * 2, 6 + posY - 1); //if para que no se coloque en las lineas verticales del tablero
            Console.WriteLine("O");
        }

        
    }


    /*
     * Metodo que dibuja las lineas horizontales del menu inicial
     */
    private void menuHorizontal()
    {
        int y = 0; //posicion y de cada linea del tablero
        //Contador para que se ejecute 2 veces
        for (int i = 0; i <= 2; i++)
        {
            if (i == 0) y = 5; // 1º iteracion se dibuja en y = 5
            else if (i == 2) y = 16; // 2º iteracion se dibuja en y = 16
            //Controla el eje x al dibujar
            for (int x = 5; x <= 25; x++)
            {
                Console.SetCursorPosition(x, y);
                if (x == 5 || x == 25)
                {
                    Console.Write("*");
                }
                else
                {
                    if (y == 16) Console.Write("¯");
                    Console.Write("-");
                }
            }
        }
            //}
        //}
    }

    /*
     * Metodo que dibuja las lineas verticales del menu inicial
     */
    private void menuVertical()
    {
        //Controla el eje x al dibujar
        for (int x = 5; x <= 25; x++)
        {
            //En los impares de x se dibuja linea y
            if(x % 2 != 0)
            {
                //Controla el eje y al dibujar
                for (int y = 6; y <= 15; y++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write("|\n");
                }
            }
        }     
    }


    void Opcion1()
    {
        Console.SetCursorPosition(5, 15);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("O P C I Ó N   1");
    }

    void Opcion2()
    {
        Console.SetCursorPosition(5, 15);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("O P C I Ó N   2");
    }

}
