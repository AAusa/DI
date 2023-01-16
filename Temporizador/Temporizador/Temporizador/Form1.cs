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
        private int duration = 60;
        public Form1()
        {
            InitializeComponent();
        }

        private void bIniciar1_Click(object sender, EventArgs e)
        {
            if(bIniciar1.BackColor == Color.Green)//Funcion de iniciar cuando esta parado
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
            }
        }

        private void count_down(object sender, EventArgs e)
        {

            if (duration == 0)
            {
                timer1.Stop();

            }
            else if (duration > 0)
            {
                duration--;
                label1.Text = duration.ToString()+" "+timer1.Interval;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
