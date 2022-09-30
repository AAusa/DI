using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{

    public abstract class Figura : PropiedadesObjeto
    {

    protected String nombreForma, color = "blanco";
    protected Punto centroForma = new Punto(0, 0);

    public String getNombreForma()
    {
        return nombreForma;
    }
    public void setNombreForma(String nombreForma)
    {
        this.nombreForma = nombreForma;
    }

    public static Figura mayorArea(Figura[] figuras)
    {
        Figura resultado = figuras[0];
        double mayor = figuras[0].calcularArea();
        for (int i = 1; i < figuras.Length; i++)
        {
            if (figuras[i].calcularArea() > mayor)
            {
                resultado = figuras[i];
            }
        }
        return resultado;
    }
    public abstract double calcularArea();
    public abstract double calcularPerimetro();

        public String toString()
    {
        return nombreForma + " " + color + " de centro (" + centroForma.getCoordenadaX() + "," + centroForma.getCoordenadaY() + ") área " + calcularArea() + " y perímetro " + calcularPerimetro();
    }
}

}
