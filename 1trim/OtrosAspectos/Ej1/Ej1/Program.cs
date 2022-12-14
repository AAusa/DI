using System;
using System.Collections;
using System.Linq.Expressions;
using System.Reflection;

namespace ConsoleApplication1
/**
  * Ejercicio 1
    Crear una tabla hash usando como clave las IPs de ordenadores y como valor la cantidad de
    memoria RAM que tiene el equipo en GB. Se plantea un menú de introducción de datos,
    elimina un dato (por clave), muestra de la colección entera y muestra de un elemento de la
    colección.
    Al pedir datos se debe comprobar que la IP es válida y que la cantidad de RAM es un entero
    positivo.
  * */
{
    class Program
    {
        Hashtable ordenadores = new Hashtable();//ip, memoria
        static void Main(string[] args)
        {
            new Program().Menu();
        }

        void Menu()
        {
            bool ejecutar = false;
            bool ejecutarMenu = false;
            int l = 0;

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

                if (k < 0) k = 4; else if (k > 4) k = 0;

                if (ejecutar)
                {
                    ejecutar = false;
                    switch (k)
                    {
                        case 0: introducir(); break;
                        case 1: eliminar(); break;
                        case 2: mostrar(); break;
                        case 3: mostrarElemento(); break;
                        return;
                    }
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

        void PintaMenu(int k)
        {
            ConsoleColor cc = ConsoleColor.White;
            ConsoleColor sel = ConsoleColor.Red;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(5, 5);
            Console.ForegroundColor = k == 0 ? sel : cc;
            Console.WriteLine("1. introducción de datos");
            Console.SetCursorPosition(5, 7);
            Console.ForegroundColor = k == 1 ? sel : cc;
            Console.WriteLine("2. elimina un dato (por clave)");
            Console.SetCursorPosition(5, 9);
            Console.ForegroundColor = k == 2 ? sel : cc;
            Console.WriteLine("3. muestra de la colección entera");
            Console.SetCursorPosition(5, 11);
            Console.ForegroundColor = k == 3 ? sel : cc;
            Console.WriteLine("4. muestra de un elemento de la colección");
            Console.SetCursorPosition(5, 13);
            Console.ForegroundColor = k == 4 ? sel : cc;
            Console.WriteLine("5. Salir");

        }


        private Boolean validarIP(String ip)
        {
            int correctos = 0;
            string[] partes = ip.Split('.');
            foreach (var parte in partes)
            {
                if(Int32.Parse(parte) > 0 && Int32.Parse(parte) < 256)
                {
                    correctos++; 
                }
            }
            return correctos == 4;
        }

        private Boolean validarRAM(String ram)
        {
            try
            {
                int ramNew = Int32.Parse(ram);
                if(ramNew > 0)
                {
                    return true;
                }

            }
            catch (FormatException ex)
            {
                return false;
            }
            return false;
        }
        void introducir()
        {
            Console.Clear();
            Console.SetCursorPosition(5, 5);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("IP:");
            Console.SetCursorPosition(5, 6);
            String ip = Console.ReadLine();
            Console.SetCursorPosition(5, 7);
            Console.WriteLine("RAM:");
            Console.SetCursorPosition(5, 8);
            String ram = Console.ReadLine();
            if(validarIP(ip) && validarRAM(ram))
            {
                ordenadores.Add(ip, ram);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(5, 9);
                Console.WriteLine("Introducido bien :)");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(5, 9);
                Console.WriteLine("Error de formato");
            }
        }

        void eliminar()
        {
            Console.Clear();
            Console.SetCursorPosition(5, 5);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("IP de ordenador a borrar:");
            Console.SetCursorPosition(5, 6);
            String ip = Console.ReadLine();
            if(ordenadores.Contains(ip))
            {
                ordenadores.Remove(ip);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(5, 7);
                Console.WriteLine("Borrado bien :)");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(5, 7);
                Console.WriteLine("IP no encontrada");
            }
        }

        void mostrar()
        {
            int contador = 5;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            //Recorrer la colección pares clave/valor
            foreach (DictionaryEntry de in ordenadores)
            {
                Console.SetCursorPosition(5, contador++);
                Console.WriteLine("IP: {0} RAM: {1} GB", de.Key, de.Value);
            }

        }
        private void mostrarElemento()
        {
            int contador = 7;
            Console.Clear();
            Console.SetCursorPosition(5, 5);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("IP de ordenador a mostrar:");
            Console.SetCursorPosition(5, 6);
            String ip = Console.ReadLine();
            if (ordenadores.Contains(ip))
            {
                foreach (DictionaryEntry de in ordenadores)
                {
                    Console.SetCursorPosition(5, contador++);
                    if (de.Key.Equals(ip))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("IP: {0} RAM: {1} GB", de.Key, de.Value);
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(5, 7);
                Console.WriteLine("IP no encontrada");
            }
        }
        void Opcion2()
        {
            Console.SetCursorPosition(5, 15);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("O P C I Ó N   2");
        }

    }
}