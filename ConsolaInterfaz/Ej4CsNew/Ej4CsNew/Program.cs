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

                if (k < 0) k = 5; else if (k > 5) k = 0;

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
                        case 2: return;
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
            Console.WriteLine("Juego 5");
            Console.SetCursorPosition(5, 15);
            Console.ForegroundColor = k == 5 ? colorSeleccionado : colorBase;
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
    }
}