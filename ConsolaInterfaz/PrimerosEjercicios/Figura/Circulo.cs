using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    public class Circulo : Elipse
    {
    public Circulo(double r) : base(r,r){
            nombreForma = "circulo";
        } 
    }
}
