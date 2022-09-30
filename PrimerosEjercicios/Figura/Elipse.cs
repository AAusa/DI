using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{

    public class Elipse : Figura
    {

    protected double rMayor = 0;
    protected double rMenor = 0;

    public Elipse(double rMayor, double rMenor)
    {
        this.rMayor = rMayor;
        this.rMenor = rMenor;
        nombreForma = "elipse";
    }

    public double getrMayor()
    {
        return rMayor;
    }

    public void setrMayor(double rMayor)
    {
        this.rMayor = rMayor;
    }

    public double getrMenor()
    {
        return rMenor;
    }

    public void setrMenor(double rMenor)
    {
        this.rMenor = rMenor;
    }

    public override double calcularArea()
    {
        return rMayor * rMenor * Math.PI;
    }

    public override double calcularPerimetro()
    {
        return 2 * Math.PI * Math.Sqrt((rMayor * rMayor + rMenor * rMenor) / 2);
    }

    public String toString()
    {
        return nombreForma + " " + color + " de centro (" + centroForma.getCoordenadaX + "," + centroForma.getCoordenadaY + ") área " + calcularArea() + " y perímetro " + calcularPerimetro();
    }

}

}
