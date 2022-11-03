using System.Runtime.CompilerServices;
namespace Hundir{
    
    public class Tablero
    {
        private Barco[] barcos = new Barco[10]; // Representará los barcos del jugador
        private Boolean[,] mar; // Representará las opciones que se van marcando

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


        public Tablero()
        {
            mar = new Boolean[10, 10];
            for (int i = 0; i< 10;i++){
                barcos[i] = new Barco();
            }
        }

        public Tablero(Barco[] barcos){
            mar = new Boolean[10, 10];
            this.barcos=barcos;
        }

        public Tablero(Barco[] barcos, Boolean[, ] tablero){
            this.mar = tablero;
            this.barcos = barcos;
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

            // Creamos 4 barcos de tamaño 1, 3 barcos de tamaño 2, dos de tamaño 3 y 1 de tamaño 1
            
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
            Console.Clear();
            Dibuja.TableroJuego(this,2,2);
            int px=-1;
            int py=-1;
            do{
                Console.SetCursorPosition(x, y+25);
                Console.Write("Introduce posición x (entre 0 y 10): ");
                try{
                    px=Int32.Parse(Console.ReadLine());
                }catch{
                    px = -1; 
                }
                Console.SetCursorPosition(x, y+26);
                Console.Write("Introduce posición x (entre 0 y 10): ");
                try{
                    py=Int32.Parse(Console.ReadLine());
                }catch{
                    py = -1; 
                }
                System.Console.WriteLine(px);
                    System.Console.WriteLine(py);
                if(px != -1 && py != -1){
                    
                    if(Mar[px, py]){
                    Console.SetCursorPosition(x, y+27);
                    Console.Write("Esa coordenada ya está elegida. Presiona una tecla para continuar");
                    Console.ReadKey();
                    }
                }
                    
            }while((px < 0 || py <0 || px > 9 || py > 9) && Mar[px,py]);

            Mar[px,py]=true;
            Dibuja.TableroJuego(this,2,2);
        }

    }
}
