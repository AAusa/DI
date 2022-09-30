using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    /*
     * Public, ya que no permite que sea protected
     * y si fuera private no permitiría la visión en la herencia
     */
    public interface PropiedadesObjeto
    {
        public double calcularArea();
        public double calcularPerimetro();
    }
}
