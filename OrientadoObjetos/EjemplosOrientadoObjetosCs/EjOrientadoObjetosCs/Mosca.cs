class Mosca : Animal, ICorredor
{
    public Mosca()
    {
        nombreCientifico = "Drosophila Melanogaster";
    }
    public void MuestraEdad()
    {
        Console.WriteLine("Las moscas no tienen edad");
    }

    public void correr()
    {
        Console.WriteLine("Correr!!");
    }
}