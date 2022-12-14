class Animal : ICorredor
{
    public readonly static string definicion = "ser vivo eucariota pluricelular";
    private int edad;
    public string nombreCientifico;
    public Animal(int edad)
    {
        this.edad = edad;
    }
    public Animal()
    : this(0)
    {
    }

    public void MuestraEdad()
    {
        Console.WriteLine(edad.ToString());
    }

    public void correr()
    {
        Console.WriteLine("Correr!!");
    }
}