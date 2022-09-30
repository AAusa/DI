using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerosEjercicios
{
    public class Fecha
    {
        private int dia, mes, anno;

        public Fecha(int dia, int mes, int anno)
        {
            this.dia = dia;
            this.mes = mes;
            this.anno = anno;
        }

        /*
         * Si los datos que se usan en el método son de un objeto ya sea como parámetro o como atributo de clase no static
         * Static:
         * 	esBisiesto -
         * 	toString(int dia, int mes, int anno) -
         * 	ultimoDia
         * 	esAnterior
         * 	crearFecha
         */


        public static Boolean esBisiesto(int anno)
        {
            return (anno % 4 == 0 && (anno % 100 != 0 || anno % 400 == 0));
        }

        private static Boolean validarDia(int dia, int mes, int anno)
        {
            return (dia <= ultimoDia(mes, anno) && dia > 0);
        }

        private static Boolean validarMes(int dia, int mes, int anno)
        {
            const int MESES = 12;
            return (mes <= MESES && mes > 0);
        }

        public static Fecha crearFecha()
        {
            int dia = 0, mes, anno;
            Console.Write("Introduzca el año: ");
            anno = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("Introduzca el mes: ");
                mes = int.Parse(Console.ReadLine());
            }
            while (!validarMes(dia, mes, anno));
            do
            {
                Console.Write("Introduzca el dia: ");
                dia = int.Parse(Console.ReadLine());
            }
            while (!validarDia(dia, mes, anno));
            Fecha fecha = new Fecha(dia, mes, anno);
            return fecha;
        }

        public String toString()
        {
            return dia + "/" + mes + "/" + anno;
        }

        // En caso de una fecha que no es un objeto fecha
        public static String toString(int dia, int mes, int anno)
        {
            return dia + "/" + mes + "/" + anno;
        }

        public static int ultimoDia(int mes, int anno)
        {
            int ultimo = 0;
            if (mes == 2)
            {
                if (esBisiesto(anno))
                {
                    ultimo = 29;
                }
                else
                {
                    ultimo = 28;
                }
            }
            else
            {
                ultimo = (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12) ? 31 : 30;
            }
            return ultimo;
        }

        public Fecha diaSiguiente()
        {
            int diaS = this.dia, mesS = this.mes, annoS = this.anno;
            if (this.dia == ultimoDia(12, this.anno) && this.mes == 12)
            {
                diaS = 1;
                mesS = 1;
                annoS++;
            }
            else if (this.dia == ultimoDia(this.mes, this.anno))
            {
                diaS = 1;
                mesS++;
            }
            else
            {
                diaS++;
            }
            Fecha fecha = new Fecha(diaS, mesS, annoS);
            return fecha;
        }
        

        /*
         * if (this.anno != f.anno) return (this.anno < f.anno)
         * if (rhis.mes != f.mes) return (this.mes < f.mes)
         * return (this.dia < f.dia)
         */
        public Boolean esAnterior(Fecha fecha)
        {
            if (anno < fecha.anno)
            {
                return true;
            }
            else if (fecha.anno == anno && mes < fecha.mes)
            {
                return true;
            }
            else if (fecha.anno == anno && fecha.mes == mes && dia < fecha.dia)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}


