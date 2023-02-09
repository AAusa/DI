using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using RadioButton = System.Windows.Forms.RadioButton;

namespace Temporizador
{
    public partial class EditarCuentaAtras : Form
    {
        int cbHorasPointer = 0;
        int cbMinPointer = 0;
        int cbSegPointer = 0;
        string[] canciones = { "epic", "guitar", "piano" };
        String rutaSonido = "";

        public EditarCuentaAtras()
        {
            InitializeComponent();
            this.cbHoras.Items.AddRange(new object[] {1,
                        2,
                        3,
                        4,
                        5});
            cbHoras.TabIndex = cbHorasPointer;
            cbHoras.Text = cbHorasPointer+"";
            this.cbMin.Items.AddRange(new object[] {1,
                        2,
                        3,
                        4,
                        5});
            cbMin.TabIndex = cbMinPointer;
            cbMin.Text = cbMinPointer + "";
            this.cbSeg.Items.AddRange(new object[] {1,
                        2,
                        3,
                        4,
                        5});
            cbSeg.TabIndex = cbSegPointer;
            cbSeg.Text = cbSegPointer + "";
            this.cbSonido.Items.AddRange(new object[] {"Epic",
                        "Guitar",
                        "Piano"});
            cbSonido.TabIndex = 0;
            cbSonido.Text = "Selecciona canción...";

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void lTitulo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbHoras.TabIndex = ++cbHorasPointer;
            cbHoras.Text = cbHorasPointer + "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bHorasMenos_Click(object sender, EventArgs e)
        {
            cbHoras.TabIndex = --cbHorasPointer;
            cbHoras.Text = cbHorasPointer + "";

        }

        private void bMinMenos_Click(object sender, EventArgs e)
        {
            cbMin.TabIndex = --cbMinPointer;
            cbMin.Text = cbMinPointer + "";
        }

        private void bMinMas_Click(object sender, EventArgs e)
        {
            cbMin.TabIndex = ++cbMinPointer;
            cbMin.Text = cbMinPointer + "";
        }

        private void bSegMas_Click(object sender, EventArgs e)
        {
            cbSeg.TabIndex = ++cbSegPointer;
            cbSeg.Text = cbSegPointer + "";
        }

        private void bSegMenos_Click(object sender, EventArgs e)
        {
            cbSeg.TabIndex = --cbSegPointer;
            cbSeg.Text = cbSegPointer + "";
        }
        private int pasaraSeg(Int32 horas, Int32 min, Int32 seg)
        {
            Int32 horasSeg = horas * 3600;
            Int32 minSeg = min * 60;
            return horasSeg + minSeg+ seg;
        }
        private void bIniciar2_Click(object sender, EventArgs e)
        {
            int pasaraseg = pasaraSeg(cbHoras.SelectedIndex == -1 ? 0 : cbHoras.SelectedIndex+1,
                                              cbMin.SelectedIndex == -1 ? 0 : cbMin.SelectedIndex+1,
                                              cbSeg.SelectedIndex == -1 ? 0 : cbSeg.SelectedIndex + 1);
            Temporizador form1 = new Temporizador(pasaraseg, opcionesRadioButton(), tbTitulo.Text, cbMensaje.Checked, cbSonido.SelectedIndex, cbRepetir.Checked);
            form1.Show();
            this.Hide();
        }
        private int opcionesRadioButton()
        {
            int opcion = 0;//Parar
            if(rbReiniciar.Checked)//reiniciar
            {
                opcion = 1;
            }
            if (rbCrono.Checked)//crono
            {
                opcion = 2;
            }
            return opcion;
        }

        private void cbHoras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbCuentaFecha_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            
            Temporizador form1 = new Temporizador();
            form1.Show();
            this.Hide();
        }

        private void bProbar_Click(object sender, EventArgs e)
        {
            iniciarForm3();
        }

        private void cbMensaje_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void iniciarForm3()
        {
            Mensaje form3 = new Mensaje(tbTitulo.Text, pasaraSeg(cbHoras.SelectedIndex == -1 ? 0 : cbHoras.SelectedIndex + 1,
                                              cbMin.SelectedIndex == -1 ? 0 : cbMin.SelectedIndex + 1,
                                              cbSeg.SelectedIndex == -1 ? 0 : cbSeg.SelectedIndex + 1));
            form3.Show();
        }

        public void ReproducirMusica()
        {
            SoundPlayer sndplayr = null;
            if(cbSonido.SelectedIndex > -1)
            {
                switch (cbSonido.SelectedIndex)
                {
                    case 0:
                        sndplayr = new SoundPlayer(Properties.Resources.epic2); break;
                    case 1:
                        sndplayr = new SoundPlayer(Properties.Resources.guitar); break;
                    case 2:
                        sndplayr = new SoundPlayer(Properties.Resources.piano); break;
                }
                sndplayr.Play();
                
            }
        }

        private void bIniciar_Click(object sender, EventArgs e)
        {
            ReproducirMusica();
        }

        private void bParar_Click(object sender, EventArgs e)
        {
            SoundPlayer sndplayr = new SoundPlayer(rutaSonido);
            sndplayr.Stop();
        }

        private void gb1_Enter(object sender, EventArgs e)
        {

        }
    }
}
