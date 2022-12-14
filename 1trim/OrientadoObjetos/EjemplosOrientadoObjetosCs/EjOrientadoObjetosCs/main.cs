public class main
{
    public static void Main(String[] args)
    {
        //PERROOLD:
        PerroOld objPerro = new PerroOld();
        objPerro.Raza = "Mastín";
        //objPerro.Nombre = "Laika";
        objPerro.Edad = 5;
        Console.WriteLine(objPerro.Nombre);
        Console.WriteLine(objPerro.Raza);
        Console.WriteLine(objPerro.Edad);
        Console.ReadLine();

        //ANIMAL:
        Perro objPerro1 = new Perro(2, "Mastin", "Neo");
        Animal objAnimal;
        objAnimal = objPerro1;
        Console.WriteLine(objAnimal.nombreCientifico);
        if (objAnimal is Perro)
        {
            Console.WriteLine(((Perro)objAnimal).nombreHumano);
        }
        Console.ReadKey();

        switch (objAnimal)
        {
            case Perro p:
                Console.WriteLine(p.nombreHumano);
                break;
            case Mosca m:
                Console.WriteLine("Soy la Mosca!");
                m.MuestraEdad();
                break;
        }
    }
}