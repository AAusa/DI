using System.Reflection;

public class Jugador : Persona
{
    private int dorsal;
    private int goles;

    public Jugador(int edad, String nombre, int dorsal, int goles)
    : base(edad, nombre)
    {
        this.dorsal = dorsal;
        this.goles = goles;
    }

    public int Dorsal
    {
        get
        {
            return dorsal;
        }
    }

    public int Goles
    {
        get
        {
            return goles;
        }
        set
        {
            goles = value;
            Console.WriteLine("Nuevos goles: " + goles);
        }
    }


    public override String Datos()
    {
        return base.Datos()+ "\tDorsal: " + dorsal + "\tGoles:" + goles;
    }
}