using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundir
{
    public class Barco
    {
        private Punto posicion;
        private Boolean orientacion; // True horizontal, False: vertical
        private int longitud;

        public int Longitud{
            get{
                return longitud;
            }
        }


        public Barco()
        {
            this.posicion = new Punto(0, 0);
            this.orientacion = false;
            this.longitud = 0;
        }

        public Barco(Punto p, Boolean orientacion, int lon){
            this.posicion = p;
            this.orientacion = orientacion;
            this.longitud = lon; 
        }

        

        public static Barco barcoAleatorio(int lon){
            Random r = new Random();
            Boolean orientacion = r.Next(2) == 1;
            int cX , cY;
            if (orientacion){
                cX = r.Next(9-lon+2);
                cY = r.Next(9);
            }else{
                cY = r.Next(9-lon+2);
                cX = r.Next(9);
            }
            return new Barco(new Punto(cX, cY), orientacion, lon);
        }

        // Devuelve los puntos que representa el barco
        public Punto[] aPuntos(){
            Punto[] puntos = new Punto[this.longitud];
            for(int i=0; i< this.longitud; i++){
                if(orientacion){
                    puntos[i] = new Punto(this.posicion.CoordX+i, this.posicion.CoordY);
                }else{
                    puntos[i] = new Punto(this.posicion.CoordX, this.posicion.CoordY+i);
                }
            }
            return puntos; 
        }

        public Barco(int lon)
        {
            this.longitud=lon;
            this.posicion = new Punto(0, 0);
            this.orientacion=true;
        }

        public override string ToString(){
            return "posicion: " + this.posicion.ToString() + ", orientacion: "+ this.orientacion + "longitud: " + this.longitud; 
        }

        public Barco(int lon, Boolean orientacion, Punto p){
            this.posicion = p;
            this.longitud = lon;
            this.orientacion = orientacion;
        }

        public static void limpia(Boolean orientacion, int x, int y){
            if (orientacion){
                Console.SetCursorPosition(x, y);
                Console.Write("Posicion Horizontal                                                  ");
            }else{
                Console.SetCursorPosition(x, y);
                Console.Write("Posicion Vertical                                                  ");
            }
                
            Console.SetCursorPosition(x, y+1);
            Console.Write("                                                                     ");
            Console.SetCursorPosition(x, y+2);
            Console.Write("                                                                     ");
        }

        public static Barco creaBarco (int tamanio, int x, int y ){
            ConsoleKey tecla = ConsoleKey.A; //Inicializo a una letra cualquiera
            do{
                limpia(true, x,y);                
                Console.SetCursorPosition(x, y);
                Console.Write("Introduce orientación del barco (H: Horizontal / V vertical): ");
                tecla = Console.ReadKey().Key;
            }while(tecla != ConsoleKey.H && tecla != ConsoleKey.V );

            Boolean orientacion = (tecla == ConsoleKey.H);
            int cX = -1;
            int cY = -1;

            if(orientacion){
                do{
                    limpia(orientacion, x,y);
                    Console.SetCursorPosition(x, y+1);
                    Console.Write("Introduce coordenada x (x < {0}): ", 9-tamanio+2);
                    try{
                        cX = Int32.Parse(Console.ReadLine());
                    }catch{
                        cX=10;
                    }
                    Console.SetCursorPosition(x, y+2);
                    Console.Write("Introduce coordenada y (y<10): ");
                    try{
                        cY = Int32.Parse(Console.ReadLine());
                    }catch{
                        cY = 10;
                    }
                }while(cX < 0 || cY <0 || cX > 10-tamanio || cY >9);
            }else{
                do{
                    limpia(orientacion, x,y);
                    Console.SetCursorPosition(x, y+1);
                    Console.Write("Introduce coordenada x (x < 10): ");
                    try{
                        cX = Int32.Parse(Console.ReadLine());
                    }catch{
                        cX=10;
                    }
                    Console.SetCursorPosition(x, y+2);
                    Console.Write("Introduce coordenada y (y < {0}): ", 9-tamanio + 2);
                    try{
                        cY = Int32.Parse(Console.ReadLine());
                    }catch{
                        cY = 10;
                    }
                }while(cX < 0 || cY <0 || cX > 9 || cY >10 - tamanio);

            }
            Punto p = new Punto(cX, cY);
            return new Barco(tamanio,orientacion,p);
        }
    

        public Boolean EstaBarco(int x, int y)
        {
            if (orientacion)
            {
                return (y == posicion.CoordY && x >= posicion.CoordX && x < posicion.CoordX + longitud);

            }
            else
            {
                return (x == posicion.CoordX && y >= posicion.CoordY && y < posicion.CoordY + longitud);
            }
        }
    }
}
