using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Temporizador
{
    public partial class Temporizador : Form
    {
        public int durationInitial;
        private int duration = 0;
        private int opcionesRadioButton = 0;
        private bool cuentaAtras = true;
        private bool mensaje = false;
        String titulo = "";
        int sonido = -1;
        string[] canciones = { "epic", "guitar", "piano"};
        bool repetirMusica = false;
        SoundPlayer sndplayr = null;
        bool pararMusica = false;
        bool incrementoFecha = false;
        bool fecha = false;
        public Temporizador()
        {
            InitializeComponent();
            durationInitial = 3600;
            label1.Text = formateaTiempo(durationInitial);
            duration = durationInitial;
        }

        public Temporizador(int s)
        {
            InitializeComponent();
            durationInitial = s;
            label1.Text = formateaTiempo(durationInitial);
            duration = durationInitial;
        }

        public Temporizador(int s, int opcionRadioButton)
        {
            InitializeComponent();
            durationInitial = s;
            label1.Text = formateaTiempo(durationInitial);
            duration = durationInitial;
            this.opcionesRadioButton = opcionRadioButton;
        }

        public Temporizador(int s, int opcionRadioButton, String titulo)
        {
            InitializeComponent();
            durationInitial = s;
            label1.Text = formateaTiempo(durationInitial);
            duration = durationInitial;
            this.opcionesRadioButton = opcionRadioButton;
            this.titulo = titulo;
            label2.Text = titulo;  
        }

        public Temporizador(int s, int opcionRadioButton, String titulo, bool mensaje)
        {
            InitializeComponent();
            durationInitial = s;
            label1.Text = formateaTiempo(durationInitial);
            duration = durationInitial;
            this.opcionesRadioButton = opcionRadioButton;
            this.titulo = titulo;
            label2.Text = titulo;
            this.mensaje = mensaje;
        }

        public Temporizador(int s, int opcionRadioButton, String titulo, bool mensaje, int sonido)
        {
            InitializeComponent();
            durationInitial = s;
            label1.Text = formateaTiempo(durationInitial);
            duration = durationInitial;
            this.opcionesRadioButton = opcionRadioButton;
            this.titulo = titulo;
            label2.Text = titulo;
            this.mensaje = mensaje;
            this.sonido = sonido;//-1 no musica, 0-2 musica
        }

        public Temporizador(int s, int opcionRadioButton, String titulo, bool mensaje, int sonido, bool repetirMusica)
        {
            InitializeComponent();
            durationInitial = s;
            label1.Text = formateaTiempo(durationInitial);
            duration = durationInitial;
            this.opcionesRadioButton = opcionRadioButton;
            this.titulo = titulo;
            label2.Text = titulo;
            this.mensaje = mensaje;
            this.sonido = sonido;//-1 no musica, 0-2 musica
            this.repetirMusica = repetirMusica;

        }

        public Temporizador(int s, String titulo, bool mensaje, int sonido, bool repetirMusica, bool incremento)
        {
            InitializeComponent();
            durationInitial = s;
            label1.Text = formateaTiempo(durationInitial);
            duration = durationInitial;
            label2.Text = titulo;
            this.mensaje = mensaje;
            this.sonido = sonido;//-1 no musica, 0-2 musica
            this.repetirMusica = repetirMusica;
            incrementoFecha = incremento;
            fecha = true;
            bReiniciar1.Visible = false;
            bIniciar1.Visible = false;
            bIniciar1.BackColor = Color.Red;
            bIniciar1.BorderColor = Color.Red;
            bIniciar1.Text = "Parar";
            timer1.Enabled = true;
            if (!fecha)
            {
                timer1.Tick += new EventHandler(count_down);

            }
            else
            {
                timer1.Tick += new EventHandler(count_downFecha);

            }
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void bIniciar1_Click(object sender, EventArgs e)
        {
         
            if(!timer1.Enabled)//Funcion de iniciar cuando esta parado
            {
                bIniciar1.BackColor = Color.Red;
                bIniciar1.BorderColor = Color.Red;
                bIniciar1.Text = "Parar";
                timer1.Enabled = true;
                if(!fecha)
                {
                    timer1.Tick += new EventHandler(count_down);

                }
                else
                {
                    timer1.Tick += new EventHandler(count_downFecha);

                }
                timer1.Interval = 1000;
                timer1.Start();
            }
            else//Funcion de parar cuando esta iniciado
            {
                if(sndplayr != null)//Para parar la musica hay que darle dos veces seguidas
                {
                    pararMusica = true;
                    sndplayr.Stop();
                }
                bIniciar1.BackColor = Color.Green;
                bIniciar1.BorderColor = Color.Green;
                bIniciar1.Text = "Iniciar";
                timer1.Enabled = false;
                if (!fecha)
                {
                    timer1.Tick -= new EventHandler(count_down);

                }
                else
                {
                    timer1.Tick -= new EventHandler(count_downFecha);

                }

            }
        }

        private void count_down(object sender, EventArgs e)
        {

            if (duration == 0)
            {
                if(sonido > -1 && !pararMusica)
                {
                    ReproducirMusica();
                }
                if (mensaje)
                {
                    Mensaje form3 = new Mensaje(titulo, durationInitial);
                    form3.Show();
                }
                if (opcionesRadioButton == 0)//parar
                {
                    timer1.Stop();
                }
                else if (opcionesRadioButton == 1)//reiniciar
                {
                    duration = durationInitial;
                    label1.Text = formateaTiempo(duration);
                    timer1.Stop();
                    bIniciar1.BackColor = Color.Green;
                    bIniciar1.BorderColor = Color.Green;
                    bIniciar1.Text = "Iniciar";
                    timer1.Enabled = false;

                }
                else if (opcionesRadioButton == 2)//crono
                {
                    duration++;
                    label1.Text = formateaTiempo(duration);
                    cuentaAtras = false;
                }


            }
            else if (duration > 0 && cuentaAtras)//Crono (hacia atras)
            {
                duration--;
                label1.Text = formateaTiempo(duration);
            }
            else if (duration > 0 && !cuentaAtras)//crono (hacia adelante)
            {
                duration++;
                label1.Text = formateaTiempo(duration);
            }
        }

        private void count_downFecha(object sender, EventArgs e)
        {
            if(!incrementoFecha)//si es crono
            {
                if (duration > 0)//va restando
                {
                    duration--;
                    label1.Text = formateaTiempo(duration);
                }
                if (duration == 0)//para
                {
                    if (sonido > -1 && !pararMusica)
                    {
                        ReproducirMusica();
                    }
                    if (mensaje)
                    {
                        Mensaje form3 = new Mensaje(titulo, durationInitial);
                        form3.Show();
                    }
                    timer1.Stop();
                }
            }
            else//si es incremento infinito
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
            EleccionCuenta ec = new EleccionCuenta();
            ec.Show();
            this.Hide();
        }

        public void ReproducirMusica()
        {
            
            String ruta = "Properties.Resources." + canciones[sonido];
            switch (sonido)
            {
                case 0:
                    sndplayr = new SoundPlayer(Properties.Resources.epic2); break;
                case 1:
                    sndplayr = new SoundPlayer(Properties.Resources.guitar); break;
                case 2:
                    sndplayr = new SoundPlayer(Properties.Resources.piano); break;
            }
            if (repetirMusica)
            {
                sndplayr.PlayLooping();
            }
            else 
            {
                sndplayr.Play();
            }
        }
    }
}
