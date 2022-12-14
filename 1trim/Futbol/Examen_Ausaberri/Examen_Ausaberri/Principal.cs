using ConsoleApplication1;
using System.Reflection;

public class Principal
{
    public static void Main(String[]args)
    {
        //Menu m = new Menu();
        //m.mostrarMenu();
        //Pruebas banderas todas en 1,1
        //String[] colores = { "Red", "Yellow", "Red" };
        //Bandera b = new Bandera("a", true, colores);
        //b.mostrarBandera(1, 1);
        //String[] colores2 = { "Blue", "Yellow", "Red" };
        //Bandera b2 = new Bandera("a", true, colores2);
        //b2.mostrarBandera(1, 1);
        //String[] colores3 = { "White", "Red" };
        //Bandera b3 = new Bandera("a", true, colores3);
        //b3.mostrarBandera(1, 1);
        String[] colores4 = { "Red", "Yellow", "Green", "Blue", "Orange", "DarkCyan" };
        Bandera b4 = new Bandera("a", false, colores4);
        b4.mostrarBandera(1, 1);
    }
}