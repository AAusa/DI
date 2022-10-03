public class Principal
{

    public static void Main(String[] args)
    {
        Random random = new Random();
        Principal principal = new Principal();
        Boolean terminar = false; 
        int repetir = 1;
        int max = 0, aleatorio = 0;
        String jugar = "play";
        while (!terminar)
        {
            Console.WriteLine("1.- Opcion1");
            Console.WriteLine("2.- Opcion2");
            Console.WriteLine("3.- Opcion3");
            Console.WriteLine("4.- Todos");
            Console.WriteLine("5.- Salir");
            int opcion = int.Parse(Console.ReadLine());
            while(repetir == 1)
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Max:");
                        max = int.Parse(Console.ReadLine());
                        principal.opcion1(max);
                        break;
                    case 2:
                        aleatorio = random.Next(1, 100);
                        principal.opcion2(aleatorio);
                        break;
                    case 3:
                        principal.opcion3();
                        break;
                    case 4:
                        max = 3;
                        //Mejorar goto
                        switch (max)
                        {
                            case 0:
                                Console.WriteLine("Juego1");
                                Console.WriteLine("Max:");
                                max = int.Parse(Console.ReadLine());
                                principal.opcion1(max);
                                goto case 1;
                                goto case 2; 
                            case 1:
                                Console.WriteLine("Juego2");
                                aleatorio = random.Next(1, 100);
                                principal.opcion2(aleatorio);
                            case 2:
                                Console.WriteLine("Juego3");
                                principal.opcion3();
                                goto case 0;
                                goto case 1; 
                        }
                        break;
                    case 5:
                        terminar = true;
                        break;
                }
                Console.WriteLine("Quieres repetir el mismo? 1 -> si / otraNum -> no");
                repetir = int.Parse(Console.ReadLine());
            }

        }
    }

    private void opcion1(int max = 6)
    {
        Random random = new Random();
        Console.WriteLine("Número:");
        int num = int.Parse(Console.ReadLine());
        int aciertos = 0;
        for(int i = 0; i < max; i++)
        {
            int dado = random.Next(1, max);
            Console.WriteLine("Dado " + (i+1) + ": " + dado);
            if(dado == num)
            {
                aciertos++;
            } 
        }
        Console.WriteLine("Aciertos: " + aciertos);
    }

    private void opcion2(int aleatorio)
    {
        int contador = 0;
        Boolean ganar = false;
        while (!ganar && contador < 5)
        {
            Console.WriteLine("Número:");
            int num = int.Parse(Console.ReadLine());
            if(num > aleatorio)
            {
                Console.WriteLine("Menor");
            }
            else if (num < aleatorio)
            {
                Console.WriteLine("Mayor");
            }
            else
            {
                ganar = true;
                Console.WriteLine("Acierto!");
            }
            Console.WriteLine("Quedan: " + (5-(contador + 1)) + " intentos");
            contador++;
        }
        Console.WriteLine("Número: " + aleatorio);
    }

    private void opcion3()
    {
        Random random = new Random();
        int max = 14;
        int porcentaje = 0;
        int segundo = 0;
        char resultado = 'a';

        for (int i = 0; i < max; i++)
        {
            int primer = random.Next(1, 5);
            porcentaje = random.Next(1, 100);
            Console.WriteLine(porcentaje);
            switch (porcentaje)
            {
                case int when porcentaje <= 15:    
                    segundo = random.Next(primer, 10);
                    resultado = '2';
                    break;
                case int when porcentaje <= 40:
                    segundo = primer;
                    resultado = 'X';
                    break;
                case int when porcentaje <= 100:
                    segundo = random.Next(1, primer);
                    resultado = '1';
                    break;
                default:break;
            }
            Console.WriteLine(primer + ", " + segundo + " --> " + resultado);
        }
    }



}