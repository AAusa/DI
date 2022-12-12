using System.Reflection;

public class Arbitro : Persona
{
    private int totalTarjetas;
    public Arbitro(int edad, String nombre, int totalTarjetas)
    : base(edad, nombre)
    {
        this.totalTarjetas = totalTarjetas;
    }

    public int TotalTarjetas
    {
        get
        {
            return totalTarjetas;
        }
        set
        {
            totalTarjetas = value;
            Console.WriteLine("Nuevas tarjtas: " + totalTarjetas);
        }
    }



    public override String Datos()
    {
        return base.Datos()+ "\tTotalTarjetas: " + totalTarjetas;
    }
}