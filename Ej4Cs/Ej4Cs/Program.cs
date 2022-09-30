public class Principal
{

    public static void Main(String[] args)
    {
        Principal principal = new Principal();
        Boolean terminar = false;
        while(!terminar)
        {
            Console.WriteLine("1.- Opcion1");
            Console.WriteLine("2.- Opcion2");
            Console.WriteLine("3.- Opcion3");
            Console.WriteLine("4.- Todos");
            Console.WriteLine("5.- Salir");
            int opcion = Console.Read();
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Max:");
                    int max = Console.Read();
                    principal.opcion1(max);
                    break;
                case 2: break;
                case 3: break;
                case 4: break;
                case 5:
                    terminar = true;
                    break;
                default:
 Console.WriteLine("Introduce una opcion entre 0 y 5");
                    break;
            }



        }
    }

    private void opcion1(int max = 6)
    {
        Random random = new Random();
        Console.WriteLine("Número:");
        int num = Console.Read();
        int dado = 0;
        int aciertos = 0;
        for(int i = 0; i < max; i++)
        {
            dado = random.Next(max);
            Console.WriteLine("Dado:" + dado);
            if(dado == num)
            {
                aciertos++;
            } 
        }
        Console.WriteLine("Aciertos: " + aciertos);

    }



}