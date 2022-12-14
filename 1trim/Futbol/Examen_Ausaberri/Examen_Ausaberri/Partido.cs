using System.Reflection;
using System.Security;

public class Partido
{
    private Equipo local;
    private Equipo visitante;
    private Arbitro arbitro;
    private int golesLocal, golesVisitante, totalTarjetas;

    public Partido(Equipo local, Equipo visitante, Arbitro arbitro, int golesLocal, int golesVisitante, int totalTarjetas)
    {
        this.local = local;
        this.visitante = visitante;
        this.arbitro = arbitro;
        this.golesLocal = golesLocal;
        this.golesVisitante = golesVisitante;
        this.totalTarjetas = totalTarjetas;

    }

    public Equipo Local
    {
        get
        {
            return local;
        }
    }

    public Equipo Visitante
    {
        get
        {
            return visitante;
        }
    }

    public Arbitro Arbitro
    {
        get
        {
            return arbitro;
        }
    }

    public int GolesLocal
    {
        get
        {
            return golesLocal;
        }
    }

    public int GolesVisitante
    {
        get
        {
            return golesVisitante;
        }
    }
    public int TotalTarjetas
    {
        get
        {
            return totalTarjetas;
        }
    }




    public static String simulaResultado(Equipo local, Equipo visitante, Arbitro arbitro)
    {
        Random random = new Random();
        int probVisit = random.Next(0, 100), probLocal = random.Next(0, 100), golesLocal = 0, golesVisit = 0;
        int probEquipo = random.Next(0, 11), numTarjetas = random.Next(0, 10);


        switch (probVisit)
        {
            case <= 35:
                golesVisit = 0;
                break;
            case <= 60:
                golesVisit = 1;
                break;
            case <= 80:
                golesVisit = 2;
                break;
            case <= 90:
                golesVisit = 3;
                break;
            case <= 100:
                golesVisit = random.Next(4,10);
               break;
        }

        switch (probLocal)
        {
            case <= 30:
                golesLocal = 0;
                break;
            case <= 55:
                golesLocal = 1;
                break;
            case <= 70:
                golesLocal = 2;
                break;
            case <= 85:
                golesLocal = 3;
                break;
            case <= 100:
                golesLocal = random.Next(4, 10);
                break;
        }
        local.Jugadores[probEquipo].Goles = golesLocal;
        visitante.Jugadores[probEquipo].Goles = golesVisit;
        arbitro.TotalTarjetas = numTarjetas;
        return golesLocal + "-" + golesVisit;
    }
}