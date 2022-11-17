using System;

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

            for (int k = 0; ;)
            {
                PintaMenu(k);
                ConsoleKeyInfo cki = Console.ReadKey(true);

                switch (cki.Key)
                {
                    case ConsoleKey.UpArrow: k--; break;
                    case ConsoleKey.DownArrow: k++; break;
                    case ConsoleKey.Enter: ejecutar = true; break;
                }

                if (k < 0) k = 2; else if (k > 2) k = 0;

                if (ejecutar)
                {
                    ejecutar = false;
                    switch (k)
                    {
                        case 0: Opcion1(); break;
                        case 1: Opcion2(); break;
                        case 2: return;
                    }
                }
            }
        }

        void PintaMenu(int k)
        {
            ConsoleColor cc = ConsoleColor.White;
            ConsoleColor sel = ConsoleColor.Red;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(5, 5);
            Console.ForegroundColor = k == 0 ? sel : cc;
            Console.WriteLine("1. Opción Uno");
            Console.SetCursorPosition(5, 7);
            Console.ForegroundColor = k == 1 ? sel : cc;
            Console.WriteLine("2. Opción Dos");
            Console.SetCursorPosition(5, 9);
            Console.ForegroundColor = k == 2 ? sel : cc;
            Console.WriteLine("3. Salir");
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
}