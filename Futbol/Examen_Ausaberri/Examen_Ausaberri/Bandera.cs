using System.ComponentModel;
using System.Reflection;

public class Bandera
{
    private String nombre;
    private bool posicion;//true vertical
    ConsoleColor[] todosColores;
    String[] colores;


    public Bandera(String nombre, bool posicion, String[] colores)
    {
        this.nombre = nombre;
        this.posicion = posicion;
        this.colores = colores;
        //colores = {"DarkBlue", "DarkGreen", "DarkCyan", "DarkRed",
        //                           "DarkMagenta", "DarkYellow", "Gray", "DarkGray",
        //                           "Blue", "Green", "Cyan", "Red", "Magenta", "Yellow", "White"};

    }


    public String Nombre
    {
        get
        {
            return nombre;
        }
    }

    public bool Posicion
    {
        get
        {
            return posicion;
        }
    }

    public String[] Colores
    {
        get
        {
            return colores;
        }
    }

    public ConsoleColor[] TodosColores
    {
        get
        {
            return todosColores;
        }
    }




    public void mostrarBandera(int x, int y)
    {
        int parte = 0;//parte de cada color
        int contador = 0;//contador de colores
        todosColores = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));

        if (x > 100 || y > 100 || x < 0 || y < 0)
        {
            throw new Exception("X e y valores incorrectos");
        }

        if (posicion)//vertical
        {
            switch (colores.Length)
            {
                case 6:
                    parte = 36 / 6;
                    break;
                case 4:
                    parte = 36 / 4;
                    break;
                case 3:
                    parte = 36 / 3;
                    break;
                case 2:
                    parte = 36 / 2;
                    break;
            }
            for(int i = 0; i < 36; i++)//horizontal
            {
                for(int j = 0; j < 12; j++)//vertical
                {
                    if (i < parte)//dentro de cada parte que pinte en un color
                    {
                        //Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colores[contador], true);
                        Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colores[contador], true);
                        Console.SetCursorPosition(i + x, j + y);
                        Console.Write(" ");
                    }
                    else//que aumente la parte
                    {
                        parte += parte;
                        Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colores[++contador], true);
                        Console.SetCursorPosition(i + x, j + y);
                        Console.Write(" ");
                    }
                }
            }
        }
        else
        {
            switch (colores.Length)
            {
                case 6:
                    parte = 12 / 6;
                    break;
                case 4:
                    parte = 12 / 4;
                    break;
                case 3:
                    parte = 12 / 3;
                    break;
                case 2:
                    parte = 12 / 2;
                    break;
            }

            for (int i = 0; i < 12; i++)//vertical
            {
                for (int j = 0; j < 36; j++)//horizontal
                {
                    if (i < parte)//dentro de cada parte que pinte en un color
                    {
                        Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colores[contador], true);
                        Console.SetCursorPosition(j + x, i + y);
                        Console.Write(" ");
                    }
                    else//que aumente la parte
                    {
                        parte += parte;
                        Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colores[++contador], true);
                        Console.SetCursorPosition(j + x, i + y);
                        Console.Write(" ");
                    }
                }
            }

        }
    }
}