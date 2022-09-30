using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{

    public class Punto
    {
        int coordenadaX, coordenadaY;

        public Punto(int coordenadaX, int coordenadaY)
        {
            this.coordenadaX = coordenadaX;
            this.coordenadaY = coordenadaY;
        }

        public double getCoordenadaX()
        {
            return coordenadaX;
        }

        public void setCoordenadaX(int coordenadaX)
        {
            this.coordenadaX = coordenadaX;
        }

        public double getCoordenadaY()
        {
            return coordenadaY;
        }

        public void setCoordenadaY(int coordenadaY)
        {
            this.coordenadaY = coordenadaY;
        }
    }

}
