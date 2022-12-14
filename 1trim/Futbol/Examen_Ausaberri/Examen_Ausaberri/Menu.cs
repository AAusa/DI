using System;
using System.Globalization;

namespace ConsoleApplication1
{
    class Menu
    {
        public void mostrarMenu()
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

                if (k < 0) k = 3; else if (k > 3) k = 0;

                if (ejecutar)
                {
                    ejecutar = false;
                    switch (k)
                    {
                        case 0:
                            //MaximoGoleador();
                            break;
                        case 1:
                            //masVictorias();
                            break;
                        case 2:
                            //masDerrotas();
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
            Console.WriteLine("Máximo goleador");
            Console.SetCursorPosition(5, 7);
            Console.ForegroundColor = k == 1 ? colorSeleccionado : colorBase;
            Console.WriteLine("Equipo con más victorias");
            Console.SetCursorPosition(5, 9);
            Console.ForegroundColor = k == 2 ? colorSeleccionado : colorBase;
            Console.WriteLine("Equipo con más derrotas");
            Console.SetCursorPosition(5, 11);
            Console.ForegroundColor = k == 3 ? colorSeleccionado : colorBase;
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

        public Jugador MaximoGoleador(Equipo[] equipos) {
            Jugador max = new Jugador(12, "a", 1, 0);
            foreach (Equipo equip in equipos)
            {
                if(equip.MaximoGoleador().Goles > max.Goles)
                {
                    max = equip.MaximoGoleador();
                }
            }
            return max;
        }

        public Equipo masDerrotas(Equipo[] equipos)
        {
            //creacion equipo con mayores victorias y el equipo q tiene menos victorias es el peor
            Jugador[] jugadores = new Jugador[1];
            String[] colores = { "Blue", "Red" };
            Bandera b = new Bandera("a", true, colores);
            Equipo peor = new Equipo(100000000, "a", 1, jugadores, b);
            foreach (Equipo equip in equipos)
            {
                if (equip.Victorias > peor.Victorias)
                {
                    peor = equip;
                }
            }
            return peor;
        }

        public Equipo masVictorias(Equipo[] equipos)
        {
            //creacion equipo con menores victorias y el equipo q tiene mas victorias es el mejor
            Jugador[] jugadores = new Jugador[1];
            String[] colores = { "Blue", "Red" };
            Bandera b = new Bandera("a", true, colores);
            Equipo mejor = new Equipo(0,"a", 1, jugadores, b);
            foreach (Equipo equip in equipos)
            {
                if (equip.Victorias > mejor.Victorias)
                {
                    mejor = equip;
                }
            }
            return mejor;

        }
    }
}