using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{    public class Principal
    {

        public static void Main(String[] args)
        {
            Console.WriteLine("Introduce lado mayor para un rectángulo: ");
            double lM = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduce lado menor para un rectángulo: ");
            double lm = double.Parse(Console.ReadLine());
            Rectangulo r = new Rectangulo(lM, lm);

            Console.WriteLine("Introduce radio mayor para una elipse: ");
            lM = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduce radio menor para un rectángulo: ");
            lm = double.Parse(Console.ReadLine());
            Elipse e = new Elipse(lM, lm);

            Console.WriteLine("Introduce lado  un cuadrado: ");
            lm = double.Parse(Console.ReadLine());
            Cuadrado cu = new Cuadrado(lm);

            Console.WriteLine("Introduce radio para un círculo: ");
            lm = double.Parse(Console.ReadLine());
            Circulo ci = new Circulo(lm);

            Figura[] f = new Figura[4];
            f[0] = r;
            f[1] = e;
            f[2] = cu;
            f[3] = ci;

            /**
             * Debemos crear un método en la clase figura, que tenga como
             * parámetro de entrada un vector de figuras y nos devuelva la 
             * figura con mayor área. El método se llamará mayorArea
             */

            Console.WriteLine("la figura de mayor es " + Figura.mayorArea(f).toString());

        }

    }
}
