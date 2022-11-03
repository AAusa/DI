using System.Runtime.CompilerServices;
namespace Hundir{
    public class HundirLaFlota
    {
        static void Main(string[] args)
        {
            Tablero tableroUser = Tablero.tableroUser();
            Tablero tableroUsuario = Tablero.tableroMaquina();
            Tablero tableroMaquina = Tablero.tableroMaquina();

            while(true){
                tableroUsuario.juegaUsuario(2,2);
            }

            Console.Clear();
            Dibuja.DibujaCuadro(40,2);
            Dibuja.DibujaFinal(tableroMaquina.Barcos ,40,2);

        }
    }
}