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
                        case 1: Opcion2(); break;
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
            Console.SetCursorPosition(30, 5);
            Console.ForegroundColor = l == 0 ? colorSeleccionado : colorBase;
            Console.WriteLine("Volver");
            Console.SetCursorPosition(45, 5);
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

        void Opcion2()
        {
            Console.SetCursorPosition(5, 15);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("O P C I Ó N   2");
        }
    }
}