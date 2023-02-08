using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temporizador
{
    public partial class Mensaje : Form
    {
        String titulo = "";
        int s = 0;
        public Mensaje()
        {
            InitializeComponent();
        }

        public Mensaje(String titulo)
        {
            InitializeComponent();
            this.titulo = "Título: " + titulo;
            lTitulo.Text = "Título: "+titulo;
        }
        public Mensaje(String titulo, int s)
        {
            InitializeComponent();
            this.titulo = "Título: " + titulo;
            lTitulo.Text = "Título: " + titulo;
            this.s = s;
            lTiempo.Text = "Tiempo: " + formateaTiempo(s);
        }
        private String formateaTiempo(Int32 tsegundos)
        {
            String salida = "";
            Int32 horas = (tsegundos / 3600);
            Int32 minutos = ((tsegundos - horas * 3600) / 60);
            Int32 segundos = tsegundos - (horas * 3600 + minutos * 60);
            if (horas < 10)
            {
                if (minutos < 10)
                {
                    if (segundos < 10)//h,m,s
                    {
                        if (horas == 0)//si hora es 0 no se muestra
                        {
                            salida = "0" + minutos.ToString() + ":" + "0" + segundos.ToString();
                        }
                        else
                        {
                            salida = "0" + horas.ToString() + ":" + "0" + minutos.ToString() + ":" + "0" + segundos.ToString();
                        }
                    }
                    else//h,m
                    {
                        if (horas == 0)//si hora es 0 no se muestra
                        {
                            salida = "0" + minutos.ToString() + ":" + segundos.ToString();
                        }
                        else
                        {
                            salida = "0" + horas.ToString() + ":" + "0" + minutos.ToString() + ":" + segundos.ToString();
                        }
                    }
                }
                else if (segundos < 10)//h,s
                {
                    if (horas == 0)//si hora es 0 no se muestra
                    {
                        salida = minutos.ToString() + ":" + "0" + segundos.ToString();
                    }
                    else
                    {
                        salida = "0" + horas.ToString() + ":" + minutos.ToString() + ":" + "0" + segundos.ToString();
                    }
                }
                else//h
                {
                    if (horas == 0)//si hora es 0 no se muestra
                    {
                        salida = minutos.ToString() + ":" + segundos.ToString();
                    }
                    else
                    {
                        salida = "0" + horas.ToString() + ":" + minutos.ToString() + ":" + segundos.ToString();
                    }
                }
            }
            else
            {
                if (minutos < 10)
                {
                    if (segundos < 10)//m,s
                    {
                        if (horas == 0)//si hora es 0 no se muestra
                        {
                            salida = "0" + minutos.ToString() + ":" + "0" + segundos.ToString();
                        }
                        else
                        {
                            salida = horas.ToString() + ":" + "0" + minutos.ToString() + ":" + "0" + segundos.ToString();
                        }
                    }
                    else//m
                    {
                        if (horas == 0)//si hora es 0 no se muestra
                        {
                            salida = "0" + minutos.ToString() + ":" + segundos.ToString();
                        }
                        else
                        {
                            salida = horas.ToString() + ":" + "0" + minutos.ToString() + ":" + segundos.ToString();
                        }
                    }
                }
                else//s
                {
                    if (horas == 0)//si hora es 0 no se muestra
                    {
                        salida = minutos.ToString() + ":" + "0" + segundos.ToString();
                    }
                    else
                    {
                        salida = horas.ToString() + ":" + minutos.ToString() + ":" + "0" + segundos.ToString();
                    }
                }
            }
            return salida;
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
