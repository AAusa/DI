class Program
{
    static void Main(string[] args)
    {
        new Program().Menu();
    }

    void Menu()
    {
        bool ejecutar = false;
        int posX = 1, posY = 10;
        for (int k = 0; ;)
        {
            PintaMenu(posX, posY);
            ConsoleKeyInfo cki = Console.ReadKey(true);
            // k se convierta en x,y que se van incrementando y en pintarMenu se controla cual se pinta con setPosition
            switch (cki.Key)
            {
                case ConsoleKey.UpArrow: posY++; break;
                case ConsoleKey.DownArrow: posY--; break;
                case ConsoleKey.RightArrow: posX++; break;
                case ConsoleKey.LeftArrow: posX--; break;
                case ConsoleKey.Enter: ejecutar = true; break;
            }
            //LIMITES TABLERO
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
     *      6,6 a 6,24
     *      15,6 a 15,24
     */
    void PintaMenu(int posX, int posY)
    {
        ConsoleColor cc = ConsoleColor.White;
        ConsoleColor sel = ConsoleColor.Red;
        menuHorizontal();
        menuVertical();
        int contX = 1, contY = 10;
        //Pinta el fondo de cada celda
        for (int y = 6; y <= 15; y++) // coordenadas ejeY
        {
            for (int x = 6; x <= 24; x += 2)// coordenadas celdas vacias de ejeX
            {
                Console.SetCursorPosition(x, y);// Todas las posiciones del tablero
                Console.BackgroundColor = (posX == contX++ && posY == contY) ? Console.BackgroundColor = ConsoleColor.Red : Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(" ");
            }
            contX = 1;
            contY--;
        }
        Console.BackgroundColor = ConsoleColor.Black;
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
