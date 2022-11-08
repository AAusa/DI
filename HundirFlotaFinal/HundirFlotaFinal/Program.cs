using System.Runtime.CompilerServices;
namespace Hundir{
    public class HundirLaFlota
    {
        static void Main(string[] args)
        {
            //Funcionamiento completo del juego, puede convenir comentar parte del código para comprobar que funcionan los métodos que vamos creando   
            Tablero tableroUsuario = Tablero.tableroUser();
            Tablero tableroMaquina = Tablero.tableroMaquina();
            Dibuja.DibujaCuadro(55, 2);
            Dibuja.TableroJuegoUsuario(tableroUsuario, 55,2);
            /*
            Console.Clear();


            while(tableroUsuario.TotalTocados < 2 && tableroMaquina.TotalTocados < 2 ){
                tableroUsuario.juegaUsuario(2,2);
                tableroMaquina.juegaMaquina(55,2);
            }

            Console.Clear();
            Dibuja.DibujaCuadro(2,2);
            Dibuja.TableroJuegoMaquina(tableroUsuario ,2,2);
            Dibuja.DibujaCuadro(55,2);
            Dibuja.TableroJuegoMaquina(tableroMaquina ,55,2);
            Console.SetCursorPosition(33, 30);
            if(tableroUsuario.TotalTocados ==2 ){
                Console.WriteLine("Enhorabuena, has ganado! ");
            }
            else{
                Console.WriteLine("Lo siento, has perdido! ");
            }
            Console.ReadKey();
            */
        }
    }

}