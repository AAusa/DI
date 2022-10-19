using System;

public class Principal
{
    public object tecla { get; private set; }
    String enunciadoJuego1 = "Pedir un número, tirar diez dados e informar al usuario de cuantas veces ha acertado.";
    String enunciadoJuego2 = "Juego adivina un número. El ordenador saca un número aleatorio entre 1 y 100. El usuario tiene 5 intentos para adivinarlo.Se informa mayor/menor en cada intento así como el número de intentos restantes. ";
    String enunciadoJuego3 = "Realizar una quiniela: Se deben dar 14 resultados aleatorios como 1, X ó 2 de forma ponderada. La probabilidad de sacar 1 sea del 60%, la de sacar X sea 25% y la de sacar un 2 sea un 15%. Se debe realizar al menos una función que devuelva un 1 una X o un 2 ponderado de la forma anterior., sacando un número de 1 a 100 y seleccionando el valor devuelto con un switch con clausula when.";
    String enunciadoJuego4 = "Jugar a todos. El programa pasará por los 3 apartados anteriores.";
    String enunciadoJuego5 = "Salir";
    int posicionY = 2;
    int cursor = 5;
    public static void Main(String[] args)
    {
        Principal principal = new Principal();
        Boolean terminar = false;
        
        while (!terminar)
        {
            int posicionY = 3;
            principal.dibujar(posicionY);
            ConsoleKey tecla = Console.ReadKey().Key;

            // x = 8, y = entre 3 y 7 (ambos incluidos)
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
        Console.WriteLine("Fin :)");
    }

    private void dibujar(int posicionY = 3)
    {
        Principal principal = new Principal();
        Console.Clear();
        Console.SetCursorPosition(2, 2);
        principal.dibujarLinea();
        for (int i = 3; i < 8; i++)
        {
            Console.SetCursorPosition(2, i);
            Console.Write("|");
            Console.SetCursorPosition(21, i);
            Console.Write("|");
            Console.SetCursorPosition(8, i);
            if(i == posicionY)
            {
                abrirColorear(posicionY);
                Console.WriteLine("Juego " + (i - 2));
                cerrarColorear(posicionY);
            }
            else
            {
                Console.WriteLine("Juego " + (i-2));
            }
        }
        Console.SetCursorPosition(2, 8);
        principal.dibujarLinea();
    }

    private void cursorOpciones()
    {
        Console.SetCursorPosition(40, cursor);
        if (cursor == 6) cursor = 5;
        cursor++;
    }

        private void menuOpciones()
    {
        int elegirOpcion = 1;//En repetir
        dibujarOpciones(elegirOpcion);
        Console.SetCursorPosition(40, 5);
        ConsoleKey tecla = Console.ReadKey().Key;
        int posicionYmenu = 5;
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
    }
    private void dibujarOpciones(int elegirOpcion)
    {
        Principal principal = new Principal();
        for (int i = 5; i <= 6; i++)
        {
            cursorOpciones();
            if (i == elegirOpcion)
            {
                abrirColorear(elegirOpcion);
                if(i == 5)
                {
                    Console.WriteLine("Repetir");
                }
                else
                {
                    Console.WriteLine("Salir");
                }
                cerrarColorear(elegirOpcion);
            }
            else
            {
                if (i == 6)
                {
                    Console.WriteLine("Repetir");
                }
                else
                {
                    Console.WriteLine("Salir");
                }
            }
        }
    }




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

    private void abrirColorear(int posicionY)
    {
        Console.ForegroundColor = ConsoleColor.Green;
    }
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

    public void jugar(int posicionY)
    {
        Random random = new Random();
        Principal principal = new Principal();
        Boolean terminar = false;
        int repetir = 1, max = 0, aleatorio = 0;
        String jugar = "play";
        Console.Clear();
        //Console.WriteLine(posicionY);
        while (repetir == 1 && !terminar)
        {
            switch (posicionY)
            {
                case 3:
                    Console.WriteLine(enunciadoJuego1);
                    Console.WriteLine("Max:");
                    max = int.Parse(Console.ReadLine());
                    principal.opcion1(max);
                    break;
                case 4:
                    Console.WriteLine(enunciadoJuego2);
                    aleatorio = random.Next(1, 100);
                    principal.opcion2(aleatorio);
                    break;
                case 5:
                    Console.WriteLine(enunciadoJuego3);
                    principal.opcion3();
                    break;
                case 6:
                    Console.WriteLine(enunciadoJuego4);
                    String todos = "todo";
                    switch (todos)
                    {
                        case "f1":
                            Console.WriteLine("Juego1");
                            Console.WriteLine("Max:");
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
                    break;
                case 7:
                    Console.WriteLine(enunciadoJuego5);
                    terminar = true;
                    break;
            }

            menuOpciones();
        }
    }


    //Falta colorear en la opcion seleccionada
    //y que al dar Enter entre en la funcion

    private void opcion1(int max = 6)
    {
        Random random = new Random();
        Console.WriteLine("Número:");
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

    private void opcion2(int aleatorio)
    {
        int contador = 0;
        Boolean ganar = false;
        while (!ganar && contador < 5)
        {
            Console.WriteLine("Número:");
            int num = int.Parse(Console.ReadLine());
            if(num > aleatorio)
            {
                Console.WriteLine("Menor");
            }
            else if (num < aleatorio)
            {
                Console.WriteLine("Mayor");
            }
            else
            {
                ganar = true;
                Console.WriteLine("Acierto!");
            }
            Console.WriteLine("Quedan: " + (5-(contador + 1)) + " intentos");
            contador++;
        }
        Console.WriteLine("Número: " + aleatorio);
    }

    private void opcion3()
    {
        Random random = new Random();
        int max = 14;
        int porcentaje = 0;
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