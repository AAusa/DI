using System.Net;
using System.Runtime.CompilerServices;

public class Principal
{
/*
 * Hacer funcion estatica (duda obj de interfaz) y hacienda
 * 
 */
    public static void Main(String[]args)
    {
        Persona empleado = new Empleado(18, "Juan", "Jimenez Perez", "12312312K", 800, 2, "686123123");
        Persona directivo = new Directivo(28, "Pepe", "Perez Marco", "12312332K", 12, 3, "Informatica");
        Empleado empleadoEspecial = new EmpleadoEspecial(38, "Jimena", "Jimenez Marques", "14312312K", 700, 1, "643334123");

        Console.WriteLine("1.- Visualizar los datos del Directivo");
        Console.WriteLine("2.- Visualizar datos Empleado");
        Console.WriteLine("3.- Visualizar datos EmpleadoEspecial");
        int opcion = Console.Read();

        switch(opcion)
        {
            
            case 1:
                directivo.mostrar();
                break;
            case 2:
                empleado.mostrar();
                break;
            case 3:
                empleadoEspecial.mostrar();
                break;

        }

    }
}
}