using System.Runtime.CompilerServices;
namespace Hundir{
    
    public class Tablero
    {
        private Barco[] barcos = new Barco[10]; // Representará los barcos del jugador
        private Boolean[,] mar; // Representará las opciones que se van marcando
        private int totalTocados; //Representa el número total de barcos que se han tocado

        public Barco[] Barcos{
            get{
                return barcos; 
            }
        }

        public Boolean[,] Mar{
            get{
                return mar;
            }
        }

        public int TotalTocados {
            get{
                return totalTocados;
            }
        }


        public Tablero()
        {
            mar = new Boolean[10, 10];
            for (int i = 0; i< 10;i++){
                barcos[i] = new Barco();
            }
            totalTocados = 0;
        }

        public Tablero(Barco[] barcos){
            mar = new Boolean[10, 10];
            this.barcos=barcos;
            totalTocados = 0;

        }

        public Tablero(Barco[] barcos, Boolean[, ] tablero, int tocados){
            this.mar = tablero;
            this.barcos = barcos;
            this.totalTocados = tocados;
        }

        //Determina si un barco b intersaca o no con los barcos que ya hay creados. True si no intersaca (es decir, cabe)
        public static Boolean cabeBarco(Barco b, Barco[] barcos){
            for(int i = 0; i < 10; i++){
                if(barcos[i].Longitud == 0) continue;
                for(int j = 0; j< barcos[i].Longitud; j++){
                    for(int k = 0; k< b.Longitud; k++){
                        if(barcos[i].aPuntos()[j].sonIguales(b.aPuntos()[k])) return false;
                    }
                }
            }
            return true; 
        }

        //Determina si una coordenada concreta es agua o barco. True barco false agua
        public Boolean CoordenadaEnBarcos(int x, int y){
            Punto p = new Punto(x, y);
            for(int i = 0; i < 10; i++){
                for(int j = 0 ; j < Barcos[i].Longitud; j++){
                    if(Barcos[i].aPuntos()[j].sonIguales(p)) return true; 
                }

             }
             return false; 
        }

        //Determina si una coordenada concreta es agua o barco dado un vector. True barco false agua
        public static Boolean CoordenadaEnBarcos(Barco[] Barcos, int x, int y)
        {
            Punto p = new Punto(x, y);
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < Barcos[i].Longitud; j++)
                {
                    if (Barcos[i].aPuntos()[j].sonIguales(p)) return true;
                }

            }
            return false;
        }

        // Devuelve un Tablero, que representa el tablero del usuario. Se actualiza interactivamente la vista
        public static Tablero tableroUser(){
            Console.Clear();
            Dibuja.DibujaCuadro(2,2);

            Barco[] barcos = new Barco[10];
            for (int i =0 ; i < 10 ; i++){
                barcos[i] = new Barco();
            }

            Dibuja.DibujaFinal(barcos, 2, 2);
            Barco b = new Barco();

            // Creamos 4 barcos de tamaño 1, 3 barcos de tamaño 2, dos de tamaño 3 y 1 de tamaño 4
            
            for(int i =0; i<3 ; i++){
                do{
                    Console.SetCursorPosition(50,10);
                    Console.Write("Introduce coordenadas para el barco {0} de tamaño 1", i+1);
                    b = Barco.creaBarco( 1, 50,11);
                }while(!cabeBarco(b, barcos) );
                barcos[i]=b;
                Dibuja.DibujaFinal(barcos, 2, 2);
            }

            for(int i =0; i<3 ; i++){
                do{
                    Console.SetCursorPosition(50,10);
                    Console.Write("Introduce coordenadas para el barco {0} de tamaño 2", i+1);
                    b = Barco.creaBarco( 2, 50,11);
                }while(!cabeBarco(b, barcos) );
                barcos[i+4]=b;
                Dibuja.DibujaFinal(barcos, 2, 2);
            }

            for(int i =0; i<2 ; i++){
                do{
                    Console.SetCursorPosition(50,10);
                    Console.Write("Introduce coordenadas para el barco {0} de tamaño 3", i+1);
                    b = Barco.creaBarco( 3, 50,11);
                }while(!cabeBarco(b, barcos) );

                barcos[i+7]=b;
                Dibuja.DibujaFinal(barcos, 2, 2);
            }
            
            do{
                Console.SetCursorPosition(50,10);
                Console.Write("Introduce coordenadas para el barco 1 de tamaño 4" );
                b = Barco.creaBarco( 4, 50,11);
            }while(!cabeBarco(b, barcos) );

            barcos[9]=b;
            Dibuja.DibujaFinal(barcos, 2, 2);

            return new Tablero(barcos); 
            
        }

        //Devuelve un tablero creado aleatoriamente (tablero de la máquina)
        public static Tablero tableroMaquina(){
            Barco[] barcos = new Barco[10];
            for (int i =0 ; i < 10 ; i++){
                barcos[i] = new Barco();
            }

            Barco b = new Barco();

            // Creamos 4 barcos de tamaño 1, 3 barcos de tamaño 2, dos de tamaño 3 y 1 de tamaño 1
            for(int i =0; i<3 ; i++){
                do{
                    b = Barco.barcoAleatorio(1);
                }while(!cabeBarco(b, barcos) );
                barcos[i]=b;
            }

            for(int i =0; i<3 ; i++){
                do{
                    b = Barco.barcoAleatorio(2);
                }while(!cabeBarco(b, barcos) );
                barcos[i+4]=b;
            }

            for(int i =0; i<2 ; i++){
                do{
                    b =Barco.barcoAleatorio(3);
                }while(!cabeBarco(b, barcos) );

                barcos[i+7]=b;
            }
            
            do{
                b =Barco.barcoAleatorio(4);
            }while(!cabeBarco(b, barcos) );

            barcos[9]=b;

            return new Tablero(barcos); 
        }

        //Le pide al usuario unas coordenadas y va actualizando el tablero
        public void juegaUsuario(int x, int y ){
            Dibuja.DibujaCuadro(x,y);
            Dibuja.TableroJuegoUsuario(this,x,y);
            Boolean repite = true; 
            int px=-1;
            int py=-1;
            do{
                Console.SetCursorPosition(x, y+25);
                Console.Write("Introduce posición x (entre 0 y 10): ");
                try{
                    px=Int32.Parse(Console.ReadLine());
                }catch{
                    repite = true; 
                }
                Console.SetCursorPosition(x, y+26);
                Console.Write("Introduce posición x (entre 0 y 10): ");
                try{
                    py=Int32.Parse(Console.ReadLine());
                }catch{
                    repite = true;
                }

                if(!(px < 0 || py <0 || px > 9 || py > 9)){
                    
                    if(Mar[px, py]){
                    Console.SetCursorPosition(x, y+27);
                    Console.Write("Esa coordenada ya está elegida. Presiona una tecla para continuar");
                    Console.ReadKey();
                    }
                }
                try{
                    repite = Mar[px, py];
                }catch{
                    repite = true; 
                }
            }while((px < 0 || py <0 || px > 9 || py > 9) || repite);

            Mar[px,py]=true;
            if (CoordenadaEnBarcos(px, py)) totalTocados++;
            Dibuja.TableroJuegoUsuario(this,x,y);
        }

        //genera unas coordenadas aleatorias, y va actualizando el tablero
        public void juegaMaquina(int x, int y){
            Dibuja.DibujaCuadro(x,y);
            int px,py;
            Random r = new Random();
            do{
                px = r.Next(10);
                py = r.Next(10);
            }while(this.Mar[px, py]);
            Mar[px,py] = true; 
            if(CoordenadaEnBarcos(px,py)) totalTocados++;
            Console.SetCursorPosition(x, y+25);
            Console.Write("La máquina escoge el punto ({0} , {1}). Presiona una tecla para continuar", px, py );
            Dibuja.DibujaCuadro(x,y);
            Dibuja.TableroJuegoMaquina(this,x,y);
            Console.SetCursorPosition(x, y+26);
            Console.ReadKey();
            Console.Clear();
            Dibuja.DibujaCuadro(x,y);
            Dibuja.TableroJuegoMaquina(this,x,y);
        }
    }
}
