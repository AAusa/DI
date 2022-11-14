using System.Net;
using System.Runtime.CompilerServices;

public class Directivo : Persona, IPastaGansa
{
    private String dpto;
    private double beneficios;
    private int nPersonasAcargo;
    private double PastaGanada;
    Directivo d;//Para decrementar los beneficios con --

    public Directivo(int edad, String nombre, String apellidos, String dni, double beneficios, int nPersonasAcargo, String dpto)
    :base(edad, nombre, apellidos, dni)
    {
        this.nPersonasAcargo = nPersonasAcargo;
        this.beneficios = beneficios;
        this.dpto = dpto;
        d = new Directivo(Edad, Nombre, Apellidos, Dni, beneficios, nPersonasAcargo, dpto);
    }

    public Directivo() : this(0, "", "", "", 0, 0, "")
    {
        d = new Directivo(0, "", "", "", 0, 0, "");
    }

    public override void mostrar()
    {
        base.mostrar();
        System.Console.WriteLine("Dpto: " + dpto + ". Beneficios: " + beneficios + ". nPersonasAcargo: " + nPersonasAcargo);
    }

    public override void introducir()
    {
        base.introducir();
        System.Console.WriteLine("dpto:");
        dpto = Console.ReadLine();
        System.Console.WriteLine("Beneficios:");
        beneficios = Console.Read();
        System.Console.WriteLine("nPersonasAcargo:");
        nPersonasAcargo = Console.Read();
    }

    public override double hacienda()
    {
        return 0.3 * PastaGanada;
    }

    public static Directivo operator --(Directivo d)
    {
        if(d.beneficios > 0) d.beneficios -= 1;
        return d;
    }

    public double ganarPasta(double beneficiosTotales)
    {
        if(beneficiosTotales > 0)
        {
            PastaGanada = beneficios / 100 * beneficiosTotales;
        }
        else
        {
            PastaGanada = 0;
            d--;
        }
        return PastaGanada;
    }
}