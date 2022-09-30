using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{

    public class Rectangulo : Figura
    {

    protected double lado1 = 0;
    protected double lado2 = 0;


    public Rectangulo(double lado1, double lado2)
    {
        this.lado1 = lado1;
        this.lado2 = lado2;
        nombreForma = "rectángulo";
    }

    
    public override double calcularArea()
    {
        return lado1 * lado2;
    }

    
    public override double calcularPerimetro()
    {
        return 2 * lado1 + 2 * lado2;
    }

    public double getLado1()
    {
        return lado1;
    }

    public void setLado1(double lado1)
    {
        this.lado1 = lado1;
    }

    public double getLado2()
    {
        return lado2;
    }

    public void setLado2(double lado2)
    {
        this.lado2 = lado2;
    }

    public double cambiarTamaño(double escala)
    {
        return escala * calcularArea();
    }

    
    public String toString()
    {
        return nombreForma + " " + color + " de centro (" + centroForma.getCoordenadaX + "," + centroForma.getCoordenadaY + ") área " + calcularArea() + " y perímetro " + calcularPerimetro();
    }
}

}
