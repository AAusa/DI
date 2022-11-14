public abstract class Persona
{
    private String nombre;
    private String apellidos;
    private int edad;
    private String dni;
    public Persona(int edad, String nombre, String apellidos, String dni)
    {
        this.edad = edad;
        this.nombre = nombre;
        this.apellidos = apellidos;
        this.dni = dni;
    }

    public Persona() : this(0, "", "", "")
    {
    }


    public int Edad
    {
        set
        {
            if (value > 0) edad = value;
            else edad = 0;
        }
        get
        {
            return edad;
        }
    }

    public String Nombre
    {
        set
        {
            nombre = value;

        }
        get
        {
            return nombre;
        }
    }
    public String Apellidos
    {
        set
        {
            apellidos = value;

        }
        get
        {
            return apellidos;
        }
    }
    public String Dni
    {
        set
        {
            dni = value;
  
        }
        get
        {
            Char[] letrasDNI = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };
            return dni + letrasDNI[int.Parse(dni.ToString()) % 23];
        }
    }
    public virtual void mostrar()
    {
        System.Console.WriteLine("Nombre: " + nombre + ". Apellidos: " + apellidos + ". Edad: " + edad + ". Dni: " + dni);
    }

    public virtual void introducir()
    {
        System.Console.WriteLine("Nombre:");
        nombre = Console.ReadLine();
        System.Console.WriteLine("Apellidos:");
        apellidos = Console.ReadLine();
        System.Console.WriteLine("Edad:");
        edad = Console.Read();
        System.Console.WriteLine("Dni:");
        dni = Console.ReadLine();
    }

    public abstract double hacienda();
}