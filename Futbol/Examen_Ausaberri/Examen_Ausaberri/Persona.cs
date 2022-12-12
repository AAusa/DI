using System.Reflection;

public abstract class Persona
{
    private int edad;
    private String nombre;

    public Persona(int edad, String nombre)
    {
        this.edad = edad;
        this.nombre = nombre;
    }
    public int Edad
    {
        get
        {
            return edad;
        }
    }

    public String Nombre
    {
        get
        {
            return nombre;
        }
    }


    public virtual String Datos()
    {
        return "Nombre: " + nombre + "\tEdad:" + edad;
    }
}