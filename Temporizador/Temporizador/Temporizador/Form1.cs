using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Temporizador
{
    public partial class Form1 : Form
    {
        public int durationInitial;
        private int duration = 0;
        private int opcionesRadioButton = 0;
        private bool cuentaAtras = true;
        String titulo = "";
        public Form1()
        {
            InitializeComponent();
            durationInitial = 3600;
            label1.Text = formateaTiempo(durationInitial);
            duration = durationInitial;
        }

        public Form1(int s)
        {
            InitializeComponent();
            durationInitial = s;
            label1.Text = formateaTiempo(durationInitial);
            duration = durationInitial;
        }

        public Form1(int s, int opcionRadioButton)
        {
            InitializeComponent();
            durationInitial = s;
            label1.Text = formateaTiempo(durationInitial);
            duration = durationInitial;
            this.opcionesRadioButton = opcionRadioButton;
        }

        public Form1(int s, int opcionRadioButton, String titulo)
        {
            InitializeComponent();
            durationInitial = s;
            label1.Text = formateaTiempo(durationInitial);
            duration = durationInitial;
            this.opcionesRadioButton = opcionRadioButton;
            this.titulo = titulo;
            label2.Text = titulo;  
        }

        private void bIniciar1_Click(object sender, EventArgs e)
        {
            if(!timer1.Enabled)//Funcion de iniciar cuando esta parado
            {
                bIniciar1.BackColor = Color.Red;
                bIniciar1.BorderColor = Color.Red;
                bIniciar1.Text = "Parar";
                timer1.Enabled = true;
                timer1.Tick += new EventHandler(count_down);
                timer1.Interval = 1000;
                //biniciar1.click += new eventhandler(biniciar1_click);
                timer1.Start();
            }
            else//Funcion de parar cuando esta iniciado
            {
                bIniciar1.BackColor = Color.Green;
                bIniciar1.BorderColor = Color.Green;
                bIniciar1.Text = "Iniciar";
                timer1.Enabled = false;
                timer1.Tick -= new EventHandler(count_down);

            }
        }

        private void count_down(object sender, EventArgs e)
        {

            if (duration == 0)
            {
                if(opcionesRadioButton == 0)
                {
                    timer1.Stop();
                }
                else if (opcionesRadioButton == 1)
                {
                    duration = durationInitial;
                    label1.Text = formateaTiempo(duration);
                    timer1.Stop();
                    bIniciar1.BackColor = Color.Green;
                    bIniciar1.BorderColor = Color.Green;
                    bIniciar1.Text = "Iniciar";
                    timer1.Enabled = false;

                }
                else if (opcionesRadioButton == 2)
                {
                    duration++;
                    label1.Text = formateaTiempo(duration);
                    cuentaAtras = false;
                }


            }
            else if (duration > 0 && cuentaAtras)
            {
                duration--;
                label1.Text = formateaTiempo(duration);
            }
            else if (duration > 0 && !cuentaAtras)
            {
                duration++;
                label1.Text = formateaTiempo(duration);
            }
        }

        private String formateaTiempo(Int32 tsegundos)
        {
            String salida = "";
            Int32 horas = (tsegundos / 3600);
            Int32 minutos = ((tsegundos - horas * 3600) / 60);
            Int32 segundos = tsegundos - (horas * 3600 + minutos * 60);
            if(horas < 10)
            {
                if(minutos < 10)
                {
                    if (segundos < 10)//h,m,s
                    {
                        if(horas == 0)//si hora es 0 no se muestra
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
                        salida = minutos.ToString() + ":" +"0"+ segundos.ToString();
                    }
                    else
                    {
                        salida = horas.ToString() + ":" + minutos.ToString() + ":" + "0"+segundos.ToString();
                    }
                }
            }
            return salida;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bReiniciar1_Click(object sender, EventArgs e)
        {
            duration = durationInitial;
            label1.Text = formateaTiempo(duration);
        }

        private void bEditar1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }
    }
}
