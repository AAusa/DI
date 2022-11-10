public class PerroOld
{
    private int edad;
    public int Edad
    {
        set
        {
            if (value < 0) edad = 0;
            else edad = value;
        }
        get
        {
            return edad;
        }
    }
    private String raza;
    public String Raza
    {
        set
        {
            raza = value;
        }
        get
        {
            return raza;
        }
    }

    public String Nombre { set; get; } = "Perro";

}