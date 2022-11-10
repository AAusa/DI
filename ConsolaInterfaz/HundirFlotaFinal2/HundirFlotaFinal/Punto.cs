using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundir
{
    public class Punto
    {
        private double coordX;
        private double coordY; 

        public double CoordX{
            get{
                return coordX;
            }
        }

        public double CoordY{
            get{
                return coordY;
            }
        }


        public Punto(double x, double y)
        {
            this.coordX = x;
            this.coordY = y;
        }

        public Boolean sonIguales(Punto p){
            return (this.coordX == p.coordX && this.coordY == p.coordY);
        }

        public override string ToString(){
            return "(" + this.coordX + "," + this.coordY + " )"; 
        }
    }
}
