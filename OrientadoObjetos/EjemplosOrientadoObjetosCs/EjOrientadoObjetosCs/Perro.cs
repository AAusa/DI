class Perro : Animal, ICorredor
{
    public string raza;
    public string nombreHumano;
    public Perro(int edad, string raza, string nombre_humano)
: base(edad)
    {
        this.raza = raza;
        this.nombreHumano = nombre_humano;
        this.nombreCientifico = "Canis Familiaris";
    }
    public Perro()
    : this(0, "", "")
    {
    }
    public void Ladrar()
    {
        Console.WriteLine("GUAU!!!");
    }
    public void Ladrar(int n)
    {
        for (int i = 0; i < n; i++)
            Console.WriteLine("GUAU!!!");
    }

    public void correr()
    {
        Console.WriteLine("Correr!!");
    }
}
