using System;

public class Principal
{
    public object tecla { get; private set; }

    public static void Main(String[] args)
    {
        Principal principal = new Principal();
        Boolean terminar = false;
        
        while (!terminar)
        {
            int posicionY = 3;
            principal.dibujar(posicionY);
            ConsoleKey tecla = Console.ReadKey().Key;

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
    // x = 8, y = entre 3 y 7 (ambos incluidos)
    private void menu()
    {
        
    }

    public void jugar(int posicionY)
    {
        Random random = new Random();
        Principal principal = new Principal();
        Boolean terminar = false;
        int repetir = 1;
        int max = 0, aleatorio = 0;
        String jugar = "play";
        Console.Clear();
        Console.WriteLine(posicionY);
        while (repetir == 1 && !terminar)
        {
            switch (posicionY)
            {
                case 3:
                    Console.WriteLine("Max:");
                    max = int.Parse(Console.ReadLine());
                    principal.opcion1(max);
                    break;
                case 4:
                    aleatorio = random.Next(1, 100);
                    principal.opcion2(aleatorio);
                    break;
                case 5:
                    principal.opcion3();
                    break;
                case 6:
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
                    terminar = true;
                    break;
            }
            Console.WriteLine("Quieres repetir el mismo? 1 -> si / otraNum -> no");
            repetir = int.Parse(Console.ReadLine());
            if (repetir != 1) terminar = true;
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