using System.Net;
using System.Runtime.CompilerServices;

public class Principal
{
    //irpf ver si hay q quitarlo
    public static void getGanancia(Persona p)
    {
        Console.WriteLine("Introduce ganancia de la empresa: ");
        int gananciaEmpresa = Console.Read();
        switch (p)
        {
            case EmpleadoEspecial empleadoEspecial:
                Console.WriteLine("Ganancia: " + empleadoEspecial.ganarPasta(gananciaEmpresa));
                break;

            case Directivo directivo:
                Console.WriteLine("Ganancia: " + directivo.ganarPasta(gananciaEmpresa));
                break;
        }
    }
    public static void Main(String[]args)
    {
        Persona empleado = new Empleado(18, "Juan", "Jimenez Perez", "12312652", 800, "686123123");
        Persona directivo = new Directivo(28, "Pepe", "Perez Marco", "12312332", 12, 3, "Informatica");
        Empleado empleadoEspecial = new EmpleadoEspecial(38, "Jimena", "Jimenez Marques", "14312312", 700, "643334123");

        Console.WriteLine("1.- Visualizar los datos del Directivo");
        Console.WriteLine("2.- Visualizar datos Empleado");
        Console.WriteLine("3.- Visualizar datos EmpleadoEspecial");
        int opcion = Int32.Parse(Console.ReadLine());//Así coge el caracter en entero y no el char que representa
        //int opcion = Console.Read();
        //Console.WriteLine(opcion);
        switch (opcion)
        {
            case 1:
                directivo.mostrar();
                Console.WriteLine("Hacienda: " + directivo.hacienda() + " euros");
                getGanancia(directivo);
                break;
            case 2:
                empleado.mostrar();
                Console.WriteLine("Hacienda: " + empleado.hacienda() + "euros");
                break;
            case 3:
                empleadoEspecial.mostrar();
                Console.WriteLine("Hacienda: " + empleadoEspecial.hacienda() + "euros");
                getGanancia(empleadoEspecial);
                break;
        }
    }
}