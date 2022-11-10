using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerosEjercicios
{
    public class PruebaFecha
    {
        public static void Main(String[] args)
        {
            // TODO Auto-generated method stub
            Fecha f1 = Fecha.crearFecha();
            Console.WriteLine("la fecha siguiente a " + f1.toString() + " es: " + f1.diaSiguiente().toString());
            Fecha f2 = Fecha.crearFecha();
            if (f1.esAnterior(f2))
            {
                Console.WriteLine("la fecha " + f1.toString() + " es menor que " + f2.toString());
            }
            else
            {
                Console.WriteLine("la fecha " + f1.toString() + " es mayor o igual que " + f2.toString());
            }
        }
    }
}
