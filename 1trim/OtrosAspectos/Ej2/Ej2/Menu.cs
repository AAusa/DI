using System;
using System.Collections;
using System.Globalization;

namespace ConsoleApplication1
{
    class Menu
    {
        public Menu()
        {
            lanzarMenu();
        }

        void lanzarMenu()
        {
            Random random = new Random();
            bool ejecutar = false;
            bool ejecutarMenu = false;
            String[] alumnos = { "a1", "a2", "a3", "a4", "a5", "a6", "a7", "a8", "a9", "a10" };
            ArrayList alumnosA = new ArrayList();
            alumnosA.Add("a1");
            alumnosA.Add("a2");
            alumnosA.Add("a3");
            alumnosA.Add("a4");
            alumnosA.Add("a5");
            alumnosA.Add("a6");
            alumnosA.Add("a7");
            alumnosA.Add("a8");
            alumnosA.Add("a9");
            alumnosA.Add("a10");

            Aula aula = new Aula(alumnos);

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

                if (k < 0) k = 7; else if (k > 7) k = 0;

                if (ejecutar)
                {
                    ejecutar = false;
                    switch (k)
                    {
                        case 0:
                            double sumaNotas = 0, media;
                            for(int i = 0; i < alumnos.Length; i++)
                            {
                                sumaNotas += aula.getMedia(alumnos[i]);
                            }
                            media = sumaNotas / alumnos.Length;
                            Console.Clear();
                            Console.SetCursorPosition(5, 5);
                            Console.WriteLine("MediaTotal: " + media);
                            break;
                        case 1:
                            Console.Clear();
                            Console.SetCursorPosition(5, 5);
                            Console.WriteLine("Nombre alumno: ");
                            Console.SetCursorPosition(5, 6);
                            String nombre = Console.ReadLine();
                            Console.SetCursorPosition(5, 7);
                            Console.WriteLine("La media es " + aula.getMedia(nombre));
                            break;
                        case 2:
                            double suma = 0, mediaAsign;
                            Console.Clear();
                            Console.SetCursorPosition(5, 5);
                            Console.WriteLine("0. Mates");
                            Console.SetCursorPosition(5, 6);
                            Console.WriteLine("1. Lengua");
                            Console.SetCursorPosition(5, 7);
                            Console.WriteLine("2. Ciencia");
                            Console.SetCursorPosition(5, 8);
                            Console.WriteLine("3. Artes");
                            Console.SetCursorPosition(5, 9);
                            int asignatura = Int32.Parse(Console.ReadLine());
                            double[] notas = aula.getNotasAsignatura(asignatura);
                            for(int i = 0; i < notas.Length; i++)
                            {
                                suma += notas[i];
                            }
                            mediaAsign = suma / notas.Length;
                            Console.SetCursorPosition(5, 10);
                            Console.WriteLine("La media es " + mediaAsign);
                            break;
                        case 3:
                            Console.Clear();
                            Console.SetCursorPosition(5, 5);
                            Console.WriteLine("Nombre alumno: ");
                            Console.SetCursorPosition(5, 6);
                            String nombreAlu = Console.ReadLine();
                            Console.SetCursorPosition(5, 7);
                            double[] notasAlu = aula.getNotas(nombreAlu);
                            for (int i = 0; i < notasAlu.Length; i++)
                            {
                                Console.SetCursorPosition(5, 7+i);
                                Console.WriteLine("Nota " + (i + 1) +": " + notasAlu[i]);
                            }
                            break;
                        case 4:
                            Console.Clear();
                            Console.SetCursorPosition(5, 5);
                            Console.WriteLine("0. Mates");
                            Console.SetCursorPosition(5, 6);
                            Console.WriteLine("1. Lengua");
                            Console.SetCursorPosition(5, 7);
                            Console.WriteLine("2. Ciencia");
                            Console.SetCursorPosition(5, 8);
                            Console.WriteLine("3. Artes");
                            Console.SetCursorPosition(5, 9);
                            int nombreAsi = Int32.Parse(Console.ReadLine());
                            Console.SetCursorPosition(5, 10);
                            double[] notasAsi = aula.getNotasAsignatura(nombreAsi);
                            for (int i = 0; i < notasAsi.Length; i++)
                            {
                                Console.SetCursorPosition(5, 11 + i);
                                Console.WriteLine("Nota " + (i + 1) + ": " + notasAsi[i]);
                            }
                            break;
                        case 5:
                            Console.Clear();
                            Console.SetCursorPosition(5, 5);
                            Console.WriteLine("Nombre alumno: ");
                            Console.SetCursorPosition(5, 6);
                            String n = Console.ReadLine();
                            Console.SetCursorPosition(5, 7);
                            Console.WriteLine(aula.getNotasMinMax(n));
                            break;
                        case 6:
                            Console.Clear();
                            Console.SetCursorPosition(5, 5);
                            ArrayList aprobados = aula.getAprobados(alumnosA);
                            for (int i = 0; i < aprobados.Count; i++)
                            {
                                Console.SetCursorPosition(5, 6+i);
                                Console.WriteLine(aprobados[i]);
                            }
                            break;
                        case 7:
                            Console.Clear();
                            Console.SetCursorPosition(5, 5);
                            aula.getAlumnado();
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
            Console.WriteLine("Calcular la media de notas de toda la tabla");
            Console.SetCursorPosition(5, 7);
            Console.ForegroundColor = k == 1 ? colorSeleccionado : colorBase;
            Console.WriteLine("Media de un alumno");
            Console.SetCursorPosition(5, 9);
            Console.ForegroundColor = k == 2 ? colorSeleccionado : colorBase;
            Console.WriteLine("Media de una asignatura");
            Console.SetCursorPosition(5, 11);
            Console.ForegroundColor = k == 3 ? colorSeleccionado : colorBase;
            Console.WriteLine("Visualizar notas de un alumno");
            Console.SetCursorPosition(5, 13);
            Console.ForegroundColor = k == 4 ? colorSeleccionado : colorBase;
            Console.WriteLine("Visualizar notas de una asignatura");
            Console.SetCursorPosition(5, 15);
            Console.ForegroundColor = k == 5 ? colorSeleccionado : colorBase;
            Console.WriteLine("Nota máxima y mínima de un alumno");
            Console.SetCursorPosition(5, 17);
            Console.ForegroundColor = k == 6 ? colorSeleccionado : colorBase;
            Console.WriteLine("Lista de alumnos con todo aprobado");
            Console.SetCursorPosition(5, 19);
            Console.ForegroundColor = k == 7 ? colorSeleccionado : colorBase;
            Console.WriteLine("Visualizar tabla completa");

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
    }
}