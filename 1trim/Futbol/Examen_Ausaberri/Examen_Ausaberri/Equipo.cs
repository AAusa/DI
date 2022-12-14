using System.Reflection;

public class Equipo
{
    private int victorias;
    private String nombre;
    private int numeroJugadores;
    private Jugador[] jugadores;
    private Bandera bandera;

    public Equipo(int victorias, String nombre, int numeroJugadores, Jugador[] jugadores, Bandera bandera)
    {
        this.victorias = victorias;
        this.nombre = nombre;
        this.numeroJugadores = numeroJugadores;
        this.jugadores = jugadores;
        this.bandera = bandera;
    }

    public int Victorias
    {
        get
        {
            return victorias;
        }
        set
        {
            victorias = value;
            Console.WriteLine("Nuevas victorias: " + victorias);
        }
    }

    public String Nombre
    {
        get
        {
            return nombre;
        }
    }

    public int NumeroJugadores
    {
        get
        {
            return numeroJugadores;
        }
    }

    public Jugador[] Jugadores
    {
        get
        {
            return jugadores;
        }
    }

    public Bandera Bandera
    {
        get
        {
            return bandera;
        }
    }



    public Jugador MaximoGoleador()
    {
        Jugador maximoGoleador = new Jugador(12, "a", 1, 0);//jugadorEstandar
        for(int i = 0; i < jugadores.Length; i++)
        {
            if(jugadores[i].Goles > maximoGoleador.Goles)
            {
                maximoGoleador = jugadores[i];
            }
        }
        return maximoGoleador;
    }

    public void muestraEquipo(int x, int y)
    {
        if(x > 100 || y > 100 || x < 0 || y < 0)
        {
            throw new Exception("X e y valores incorrectos");
        }
        Console.WriteLine("Nombre:"+nombre+"\tMaximoGoleador:"+MaximoGoleador().Nombre+"\tBandera:"+Bandera.Nombre);
    }
}