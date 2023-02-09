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
    public partial class EditarCuentaFecha : Form
    {
        int cbHorasPointer = 0;
        int cbMinPointer = 0;
        int cbSegPointer = 0;
        string[] canciones = { "epic", "guitar", "piano" };
        String rutaSonido = "";
        bool incremento = false;

        public EditarCuentaFecha()
        {
            InitializeComponent();

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


        }

        private void bMinMenos_Click(object sender, EventArgs e)
        {
        }

        private void bMinMas_Click(object sender, EventArgs e)
        {
        }

        private void bSegMas_Click(object sender, EventArgs e)
        {
        }

        private void bSegMenos_Click(object sender, EventArgs e)
        {
        }
        private int pasaraSeg(Int32 horas, Int32 min, Int32 seg)
        {
            Int32 horasSeg = horas * 3600;
            Int32 minSeg = min * 60;
            return horasSeg + minSeg+ seg;
        }
        private void bIniciar2_Click(object sender, EventArgs e)
        {
            /*
            //int prueba = Convert.ToInt32(cbHoras.SelectedValue.ToString());
            int pasaraseg = pasaraSeg(cbHoras.SelectedIndex == -1 ? 0 : cbHoras.SelectedIndex+1,
                                              cbMin.SelectedIndex == -1 ? 0 : cbMin.SelectedIndex+1,
                                              cbSeg.SelectedIndex == -1 ? 0 : cbSeg.SelectedIndex + 1);
            //lTituloForm.Text += ""+cbHoras;
            Temporizador form1 = new Temporizador(pasaraseg, opcionesRadioButton(), tbTitulo.Text, cbMensaje.Checked, cbSonido.SelectedIndex, cbRepetir.Checked);
            form1.Show();
            this.Hide();
            */
            String fecha = tbFecha.Text+" "+tbHora.Text;
            int seg = 0;
            if(EsFecha(fecha))
            {
                seg = getSeg(ConvertToDateTime(tbFecha.Text + " " + tbHora.Text));
                Temporizador form1 = new Temporizador(seg, tbTitulo.Text, cbMensaje.Checked, cbSonido.SelectedIndex, cbRepetir.Checked, incremento);
                form1.Show();
                this.Hide();
            }
            else
            {
                tbFecha.Text = "Revise formato";
                tbHora.Text = "Revise formato";
            }
          
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
            String fecha = tbFecha.Text + " " + tbHora.Text;
            int seg = 0;
            if (EsFecha(fecha))
            {
                seg = getSeg(ConvertToDateTime(tbFecha.Text + " " + tbHora.Text));
                Mensaje form3 = new Mensaje(tbTitulo.Text,seg);
                form3.Show();
            }
            else
            {
                tbFecha.Text = "Revise formato";
                tbHora.Text = "Revise formato";
            }

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

        private DateTime ConvertToDateTime(string value)
        {
            DateTime convertedDate = Convert.ToDateTime("09/02/2023 9:00");
            try
            {
                convertedDate = Convert.ToDateTime(value);
            }
            catch (FormatException)
            {
                Console.WriteLine("'{0}' is not in the proper format.", value);
            }
            return convertedDate;
        }

        private int getSeg(DateTime value)
        {
            int seg = 0;
            if(value < DateTime.Now)//valor introducido menor que ahora
            {
                seg = (int)(DateTime.Now - value).TotalSeconds;//incremento
                incremento = true;

            }
            else
            {
                seg = (int)(value - DateTime.Now).TotalSeconds;//decremento
            }
            return seg;
        }
        public static Boolean EsFecha(String fecha)
        {
            try
            {
                DateTime.Parse(fecha);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void cbSonido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbTitulo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
