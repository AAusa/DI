using System;

public class Principal
{
    public object tecla { get; private set; }
    String enunciadoJuego1 = "Pedir un número, tirar diez dados e informar al usuario de cuantas veces ha acertado.";
    String enunciadoJuego2 = "Juego adivina un número. El ordenador saca un número aleatorio entre 1 y 100. El usuario tiene 5 intentos para adivinarlo.Se informa mayor/menor en cada intento así como el número de intentos restantes. ";
    String enunciadoJuego3 = "Realizar una quiniela: Se deben dar 14 resultados aleatorios como 1, X ó 2 de forma ponderada. La probabilidad de sacar 1 sea del 60%, la de sacar X sea 25% y la de sacar un 2 sea un 15%.";
    String enunciadoJuego4 = "Jugar a todos. El programa pasará por los 3 apartados anteriores.";
    String enunciadoJuego5 = "Salir";
    int posicionY = 2, cursor = 5;
    Boolean repetir = true, terminar = false;
    /*
     * Metodo que controla el juego. Dibuja y controla los movimientos del menu y lanza los juegos en sí mismos.
     */
    public static void Main(String[] args)
    {
        Principal principal = new Principal();
        while (!principal.terminar)
        {
            int posicionY = 3;
            principal.dibujar(posicionY);
            ConsoleKey tecla = Console.ReadKey().Key;

            // Limites del menu: x = 8, y = entre 3 y 7 (ambos incluidos)
            while (tecla != ConsoleKey.Enter)
            {
                //Mov. al pulsar la tecla de arriba
                if (tecla == ConsoleKey.UpArrow)
                {
                    if (posicionY == 3)
                    {
                        posicionY = 8;
                    }
                    posicionY--;
                }
                //Mov. al pulsar la tecla de abajo
                else if (tecla == ConsoleKey.DownArrow)
                {
                    if (posicionY == 7)
                    {
                        posicionY = 2;
                    }
                    posicionY++;
                }
                principal.dibujar(posicionY);
                tecla = Console.ReadKey().Key;
            }
            principal.jugar(posicionY);
            

        }
    }


    /*
     * Metodo que lanza los juegos creados y el menu al terminar de jugar.
     */
    public void jugar(int posicionY)
    {
        Random random = new Random();
        Principal principal = new Principal();
        int max, aleatorio;
        repetir = true;
        Console.Clear();
        while (repetir)
        {
            switch (posicionY)
            {
                case 3:
                    Console.WriteLine(enunciadoJuego1);
                    Console.WriteLine("Introduce el numero maximo:");
                    max = int.Parse(Console.ReadLine());
                    principal.opcion1(max);
                    menuOpciones();
                    break;
                case 4:
                    Console.WriteLine(enunciadoJuego2);
                    aleatorio = random.Next(1, 100);
                    principal.opcion2(aleatorio);
                    menuOpciones();
                    break;
                case 5:
                    Console.WriteLine(enunciadoJuego3);
                    principal.opcion3();
                    menuOpciones();
                    break;
                case 6:
                    Console.WriteLine(enunciadoJuego4);
                    //switch con goto:
                    String todos = "todo";
                    switch (todos)
                    {
                        case "f1":
                            Console.WriteLine("Juego1");
                            Console.WriteLine("Introduce el numero maximo:");
                            max = int.Parse(Console.ReadLine());
                            principal.opcion1(max);
                            goto case "f2";
                        case "f2":
                            Console.WriteLine("Juego2");
                            aleatorio = random.Next(1, 100);
                            principal.opcion2(aleatorio);
                            goto case "f3";
                        case "f3":
                            Console.WriteLine("Juego3");
                            principal.opcion3();
                            break;
                        case "todo":
                            goto case "f1";
                    }
                    menuOpciones();
                    break;
                case 7:
                    Environment.Exit(1); // Termina la ejecucion
                    break;
            }
        }
    }
    /*
     * Metodo que lanza las opciones de repetir o salir al terminar un juego .
     */
    private void menuOpciones()
    {
        Console.SetCursorPosition(40, 5);
        int posicionYmenu = 5;
        dibujarOpciones(posicionYmenu);
        ConsoleKey tecla = Console.ReadKey().Key;
        // Limites del menu: x = 40, y = entre 5 (repetir) y 6 (salir)
        while (tecla != ConsoleKey.Enter)
        {
            //Mov. al pulsar la tecla de arriba
            if (tecla == ConsoleKey.UpArrow)
            {
                if (posicionYmenu == 5)
                {
                    posicionYmenu = 6;
                }
                posicionYmenu--;
            }
            //Mov. al pulsar la tecla de abajo
            else if (tecla == ConsoleKey.DownArrow)
            {
                if (posicionYmenu == 6)
                {
                    posicionYmenu = 5;
                }
                posicionYmenu++;
            }
            dibujarOpciones(posicionYmenu);
            Console.SetCursorPosition(40, posicionYmenu);
            tecla = Console.ReadKey().Key;
        }
        // Acciones de cada opcion:
        if (posicionYmenu == 5) //repetir
        {
            repetir = false;
        }
        if (posicionYmenu == 6) //salir
        {
            Console.Clear();
            Environment.Exit(1);
        }
    }

    /*
     * Metodo que dibuja el menu inicial del juego
     */
    private void dibujar(int posicionY = 3)
    {
        Principal principal = new Principal();
        Console.Clear();
        Console.SetCursorPosition(2, 2); //Donde se empieza a dibujar
        principal.dibujarLinea();
        for (int i = 3; i < 8; i++)
        {
            //Linea izq: x = 2, y = 3 a 7
            //Linea izq: x = 21, y = 3 a 7
            Console.SetCursorPosition(2, i);
            Console.Write("|");
            Console.SetCursorPosition(21, i);
            Console.Write("|");
            Console.SetCursorPosition(8, i);
            if (i == posicionY)
            {
                abrirColorear(posicionY);
                Console.WriteLine("Juego " + (i - 2)); //Juegos del 1 - 5
                cerrarColorear(posicionY);
            }
            else
            {
                Console.WriteLine("Juego " + (i - 2));
            }
        }
        Console.SetCursorPosition(2, 8);
        principal.dibujarLinea();
    }

    /*
     * Metodo que dibuja el menu de despues de jugar del juego
     */
    private void dibujarOpciones(int posicionYmenu)
    {
        Principal principal = new Principal();
        for (int i = 5; i <= 6; i++)
        {
            //Opciones de verde:
            if (i == posicionYmenu)
            {
                abrirColorear(posicionYmenu);
                if(i == 5)
                {
                    cursor = 5;
                    Console.SetCursorPosition(40, cursor);
                    Console.WriteLine("Repetir");
                }
                else
                {
                    cursor = 6;
                    Console.SetCursorPosition(40, cursor);
                    Console.WriteLine("Salir");
                }
                cerrarColorear(posicionYmenu);
            }
            //Opciones de blanco:
            else
            {
                if (i == 5)
                {
                    cursor = 5;
                    Console.SetCursorPosition(40, cursor);
                    Console.WriteLine("Repetir");
                }
                else
                {
                    cursor = 6;
                    Console.SetCursorPosition(40, cursor);
                    Console.WriteLine("Salir");
                }
            }
        }
    }



    /*
     * Metodo que dibuja las lineas del menu inicial
     */
    private void dibujarLinea()
    {
        for (int i = 1; i <= 20; i++)
        {
            if (i == 1 || i == 20)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write("-");
            }
        }
    }
    /*
     * Metodo que colorea de verde
     */
    private void abrirColorear(int posicionY)
    {
        Console.ForegroundColor = ConsoleColor.Green;
    }
    /*
     * Metodo que colorea de blanco
     */
    private void cerrarColorear(int posicionY)
    {
        Console.ForegroundColor = ConsoleColor.White;
    }
    /*
    private void moverCursorY()
    {
        Console.SetCursorPosition(2, posicionY);
        posicionY++;
    }
    */

    /*
     * Juego1:
     */
    private void opcion1(int max = 6)
    {
        Random random = new Random();
        Console.WriteLine("Introduce tu numero:");
        int num = int.Parse(Console.ReadLine());
        int aciertos = 0;
        for(int i = 0; i < max; i++)
        {
            int dado = random.Next(1, max);
            Console.WriteLine("Dado " + (i+1) + ": " + dado);
            if(dado == num)
            {
                aciertos++;
            } 
        }
        Console.WriteLine("Aciertos: " + aciertos);
    }
    /*
     * Juego2:
     */
    private void opcion2(int aleatorio)
    {
        int contador = 0;
        Boolean ganar = false;
        while (!ganar && contador < 5)
        {
            Console.WriteLine("Introduce un numero:");
            int num = int.Parse(Console.ReadLine());
            if(num > aleatorio)
            {
                Console.WriteLine("Es menor");
            }
            else if (num < aleatorio)
            {
                Console.WriteLine("Es mayor");
            }
            else
            {
                ganar = true;
                Console.WriteLine("Acierto!");
            }
            Console.WriteLine("Quedan: " + (5-(contador + 1)) + " intentos"); //(5 - (contador + 1)) --> total - jugadas
            contador++;
        }
        Console.WriteLine("El numero a acertar era: " + aleatorio);
    }
    /*
     * Juego3:
     */
    private void opcion3()
    {
        Random random = new Random();
        int max = 14;
        int porcentaje;
        int segundo = 0;
        char resultado = 'a';

        for (int i = 0; i < max; i++)
        {
            int primer = random.Next(1, 5);
            porcentaje = random.Next(1, 100);
            Console.WriteLine(porcentaje);
            switch (porcentaje)
            {
                case int when porcentaje <= 15:    
                    segundo = random.Next(primer, 10);
                    resultado = '2';
                    break;
                case int when porcentaje <= 40:
                    segundo = primer;
                    resultado = 'X';
                    break;
                case int when porcentaje <= 100:
                    segundo = random.Next(1, primer);
                    resultado = '1';
                    break;
                default:break;
            }
            Console.WriteLine(primer + ", " + segundo + " --> " + resultado);
        }
    }



}