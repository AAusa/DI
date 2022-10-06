public class Principal
{
    public object tecla { get; private set; }

    public static void Main(String[] args)
    {
        Random random = new Random();
        Principal principal = new Principal();
        Boolean terminar = false; 
        int repetir = 1;
        int max = 0, aleatorio = 0;
        String jugar = "play";
        while (!terminar)
        {
            principal.dibujaCuadro();
            principal.opcionesMenu();
            int opcion = int.Parse(Console.ReadLine());
            while(repetir == 1 && !terminar)
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Max:");
                        max = int.Parse(Console.ReadLine());
                        principal.opcion1(max);
                        break;
                    case 2:
                        aleatorio = random.Next(1, 100);
                        principal.opcion2(aleatorio);
                        break;
                    case 3:
                        principal.opcion3();
                        break;
                    case 4:
                        String todos = "todo";
                        //Mejorar goto

                        switch (todos)
                        {
                            case "f1":
                                Console.WriteLine("Juego1");
                                Console.WriteLine("Max:");
                                max = int.Parse(Console.ReadLine());
                                principal.opcion1(max);
                                goto case "f2";
                                break;
                            case "f2":
                                Console.WriteLine("Juego2");
                                aleatorio = random.Next(1, 100);
                                principal.opcion2(aleatorio);
                                goto case "f3";
                                break;
                            case "f3":
                                Console.WriteLine("Juego3");
                                principal.opcion3();
                                break;
                            case "todo":
                                goto case "f1";                                
                        }
                        break;
                    case 5:
                        terminar = true;
                        break;
                }
                Console.WriteLine("Quieres repetir el mismo? 1 -> si / otraNum -> no");
                repetir = int.Parse(Console.ReadLine());
                if(repetir != 1) terminar = true;
            }
        }
        Console.WriteLine("Fin :)");
    }

    private void dibujaCuadro()
    {
        Console.Clear();
        Console.SetCursorPosition(2, 2);
        for (int i = 1; i <= 20; i++)
        {
            if(i == 1 || i == 20)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write("-");
            }
        }
        for (int i = 3; i <= 8; i++)
        {
            Console.SetCursorPosition(2, i);
            Console.Write("|");
            Console.SetCursorPosition(21, i);
            Console.Write("|");
            Console.SetCursorPosition(8, i);
            Console.WriteLine("Juego " + (i-2));
        }
        Console.SetCursorPosition(2, 9);
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
    // x = 8, y = entre 3 y 9
    private void opcionesMenu()
    {
        int posicionY = 3;
        colorear(posicionY);
        ConsoleKey tecla = Console.ReadKey().Key;
        while(tecla != ConsoleKey.Enter)
        {
            if (tecla == ConsoleKey.UpArrow)
            {
                if (posicionY == 3)
                {
                    posicionY = 9;
                }
                posicionY--;
                colorear(posicionY);
            }
            else if (tecla == ConsoleKey.DownArrow)
            {
           
                if (posicionY == 8)
                {
                    posicionY = 2;
                }
                posicionY++;
                colorear(posicionY);
            }
            tecla = Console.ReadKey().Key;
        }
    }

        private void colorear(int posicionY)
    {
        Console.SetCursorPosition(8, posicionY);
        Console.ForegroundColor = ConsoleColor.Green;
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