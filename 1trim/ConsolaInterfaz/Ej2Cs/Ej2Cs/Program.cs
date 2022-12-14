#define FRASE
public class Program

{
    public static void Main(String[] args)
    {
        Console.WriteLine("Introduce frase1: ");
        String frase1 = Console.ReadLine();
        Console.WriteLine("Introduce frase2: ");
        String frase2 = Console.ReadLine();
#if FRASE 
        Console.WriteLine("{0}\t{1}", frase1, frase2);
    
#else
    Console.WriteLine("{0}\n{1}", frase1, frase2);
#endif
    }
}