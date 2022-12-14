using System;
using System.Globalization;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Menu();
        }

        void Menu()
        {
            Random random = new Random();
            bool ejecutar = false;
            bool ejecutarMenu = false;

            for (int k = 0; ;)//k: contador de menu
            {
                int l = 0;//l: contador de menu volver
                PintaMenu(k);
                ConsoleKeyInfo cki = Console.ReadKey(true);

                switch (cki.Key)
                {
                    case ConsoleKey.UpArrow: k--; break;
                    case ConsoleKey.DownArrow: k++; break;
                    case ConsoleKey.Enter: ejecutar = true; break;
                }

                if (k < 0) k = 4; else if (k > 4) k = 0;

                if (ejecutar)
                {
                    ejecutar = false;
                    switch (k)
                    {
                        case 0: Opcion1(6); break;
                        case 1:
                            int aleatorio = random.Next(1, 100);
                            Opcion2(aleatorio);
                            break;
                        case 2:
                            Opcion3();
                            break;
                        case 3:
                            Opcion4();
                            break;
                    }
                    //menuVolver:
                    while (!ejecutarMenu)
                    {
                        PintaVolver(l);
                        cki = Console.ReadKey(true);
                        switch (cki.Key)
                        {
                            case ConsoleKey.LeftArrow: l--; break;
                            case ConsoleKey.RightArrow: l++; break;
                            case ConsoleKey.Enter: ejecutarMenu = true; break;
                        }
                        if (l < 0) l = 1; else if (l > 1) l = 0;
                    }
                    ejecutarMenu = false;
                    Console.Clear();
                    if (l == 1) Environment.Exit(0);//Para salir, en caso de 0, seguirá el for
                }
            }
        }



        void PintaMenu(int k)
        {
            ConsoleColor colorBase = ConsoleColor.White;
            ConsoleColor colorSeleccionado = ConsoleColor.Red;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(5, 5);
            Console.ForegroundColor = k == 0 ? colorSeleccionado : colorBase;
            Console.WriteLine("Juego 1");
            Console.SetCursorPosition(5, 7);
            Console.ForegroundColor = k == 1 ? colorSeleccionado : colorBase;
            Console.WriteLine("Juego 2");
            Console.SetCursorPosition(5, 9);
            Console.ForegroundColor = k == 2 ? colorSeleccionado : colorBase;
            Console.WriteLine("Juego 3");
            Console.SetCursorPosition(5, 11);
            Console.ForegroundColor = k == 3 ? colorSeleccionado : colorBase;
            Console.WriteLine("Juego 4");
            Console.SetCursorPosition(5, 13);
            Console.ForegroundColor = k == 4 ? colorSeleccionado : colorBase;
            Console.WriteLine("Salir");

        }

        void PintaVolver(int l)
        {
            ConsoleColor colorBase = ConsoleColor.White;
            ConsoleColor colorSeleccionado = ConsoleColor.Red;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(50, 7);
            Console.ForegroundColor = l == 0 ? colorSeleccionado : colorBase;
            Console.WriteLine("Volver");
            Console.SetCursorPosition(65, 7);
            Console.ForegroundColor = l == 1 ? colorSeleccionado : colorBase;
            Console.WriteLine("Salir");

        }

        void Opcion1(int max = 6)
        {
            Random random = new Random();
            Console.Clear();
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("Pedir un número, tirar diez dados e informar al usuario de cuantas veces ha acertado:");
            Console.SetCursorPosition(5, 5);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Introduce tu numero:");
            Console.SetCursorPosition(5, 6);
            int num = int.Parse(Console.ReadLine());
            int aciertos = 0;
            for (int i = 0; i < max; i++)
            {
                Console.SetCursorPosition(5, 5+i+2);
                int dado = random.Next(1, max);
                Console.WriteLine("\tDado " + (i + 1) + ": " + dado);
                if (dado == num)
                {
                    aciertos++;
                }
            }
            Console.SetCursorPosition(5, 5+max+2);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Aciertos: " + aciertos);
        }

        void Opcion2(int aleatorio)
        {
            Console.Clear();
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("Juego adivina un número. El ordenador saca un número aleatorio entre 1 y 100. ");
            Console.SetCursorPosition(5, 4);
            Console.WriteLine("El usuario tiene 5 intentos para adivinarlo.");
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("Se informa mayor/menor en cada intento así como el número de intentos restantes. ");

            int contador = 0;
            Boolean ganar = false;
            while (!ganar && contador < 5)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(5, contador*2+6);
                Console.WriteLine("Introduce un numero:");
                Console.SetCursorPosition(25, contador*2 + 6);
                int num = int.Parse(Console.ReadLine());
                if (num > aleatorio)
                {
                    Console.SetCursorPosition(30, contador*2+ 6);
                    Console.WriteLine("Es menor");
                }
                else if (num < aleatorio)
                {
                    Console.SetCursorPosition(30, contador * 2 + 6);
                    Console.WriteLine("Es mayor");
                }
                else
                {
                    ganar = true;
                    Console.SetCursorPosition(30, contador * 2 + 6);
                    Console.WriteLine("Acierto!");
                }
                Console.SetCursorPosition(5, contador * 2 + 7);
                Console.WriteLine("\tQuedan: " + (5 - (contador + 1)) + " intentos"); //(5 - (contador + 1)) --> total - jugadas
                contador++;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(5, contador*2 + 8);
            Console.WriteLine("El numero a acertar era: " + aleatorio);
        }

        private void Opcion3()
        {
            Random random = new Random();
            int max = 14;
            int porcentaje;
            int segundo = 0;
            char resultado = 'a';

            Console.Clear();
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("Realizar una quiniela: Se deben dar 14 resultados aleatorios como 1, X ó 2 de forma ponderada.");
            Console.SetCursorPosition(5, 4);
            Console.WriteLine("La probabilidad de sacar 1 sea del 60%, la de sacar X sea 25% y la de sacar un 2 sea un 15%.");
            for (int i = 0; i < max; i++)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                int primer = random.Next(1, 5);
                porcentaje = random.Next(1, 100);
                Console.SetCursorPosition(5, i+5);
                Console.WriteLine(porcentaje);
                switch (porcentaje)
                {
                    case int x when porcentaje <= 15://Switch con when
                        segundo = random.Next(primer, 10);
                        resultado = '2';
                        break;
                    case int x when porcentaje <= 40:
                        segundo = primer;
                        resultado = 'X';
                        break;
                    case int x when porcentaje <= 100:
                        segundo = random.Next(1, primer);
                        resultado = '1';
                        break;
                    default: break;
                }
                Console.SetCursorPosition(5, i + 6);
                    Console.WriteLine(primer + ", " + segundo + " --> " + resultado);
            }
        }
        private void Opcion4()
        {
            Random random = new Random();
            Console.Clear();
            //switch con goto:
            String todos = "todo";
            switch (todos)
            {
                case "todo":
                    goto case "f1";
                case "f1":
                    Opcion1();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("     Pulse una tecla para seguir");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    goto case "f2";
                case "f2":
                    int aleatorio = random.Next(1, 100);
                    Opcion2(aleatorio);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("     Pulse una tecla para seguir");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    goto case "f3";
                case "f3":
                    Opcion3();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("     Pulse una tecla para seguir");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    break;
                
            }
        }
    }
}