using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Ej2
{
    public partial class Form1 : Form
    {
        int c1, c2, c3;
        public Form1()
        {
            InitializeComponent();
            this.Icon = new Icon("D:\\Documentos\\VS-DI\\DI\\WindowsForms\\Ej2\\Ej2\\icono.ico");
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            ShowInTaskbar = false;
            Cursor = System.Windows.Forms.Cursors.Hand;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            DialogResult Result;
            Result = MessageBox.Show("¿Desea cerrar el programa?",
                       "Cerrar el programa", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (Result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void bImagen_Click(object sender, EventArgs e)
        {
           try
           {
                this.BackgroundImage = new Bitmap(textBox4.Text);
           }
           catch (System.ArgumentException)
           {
                textBox4.Text = "Intro. path";
           };
        }

        private void cerrar_KeyDown(object sender, KeyEventArgs k)
        {
            if (k.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                DialogResult Result;
                Result = MessageBox.Show("¿Desea cerrar el programa?",
                           "Cerrar el programa", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (Result == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            else if (k.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                try
                {
                    c1 = Int32.Parse(textBox1.Text);
                    c2 = Int32.Parse(textBox2.Text);
                    c3 = Int32.Parse(textBox3.Text);
                    if (c1 > -1 && c1 < 256 && c2 > -1 && c2 < 256 && c3 > -1 && c3 < 256)
                    {
                        this.BackColor = Color.FromArgb(c1, c2, c3);
                    }
                }
                catch (System.FormatException)
                {
                    textBox1.Text = "Introduce colores";
                };
            }
        }

        private void cerrarImagen_KeyDown(object sender, KeyEventArgs k)
        {
            if (k.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                DialogResult Result;
                Result = MessageBox.Show("¿Desea cerrar el programa?",
                           "Cerrar el programa", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (Result == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            else if (k.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                try
                {
                    this.BackgroundImage = new Bitmap(textBox4.Text);
                }
                catch (System.ArgumentException)
                {
                    textBox4.Text = "Intro. path";
                };
            }
        }

        private void bColor_Click(object sender, EventArgs e)
        {
            try
            {
                c1 = Int32.Parse(textBox1.Text);
                c2 = Int32.Parse(textBox2.Text);
                c3 = Int32.Parse(textBox3.Text);
                if (c1 > -1 && c1 < 256 && c2 > -1 && c2 < 256 && c3 > -1 && c3 < 256)
                {
                    this.BackColor = Color.FromArgb(c1, c2, c3);
                }
            }
            catch(System.FormatException)
            {
                textBox1.Text = "Introduce colores";
            };
        }

        private void bCerrar_MouseEnter(object sender, EventArgs k)
        {
            bCerrar.BackColor = Color.Green;
        }

        private void bCerrar_MouseLeave(object sender, EventArgs k)
        {
            bCerrar.BackColor = Color.Gray;
        }

        private void bColor_MouseEnter(object sender, EventArgs k)
        {
            bColor.BackColor = Color.Green;
        }

        private void bColor_MouseLeave(object sender, EventArgs k)
        {
            bColor.BackColor = Color.Gray;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bImagen_MouseEnter(object sender, EventArgs k)
        {
            bImagen.BackColor = Color.Green;
        }

        private void bImagen_MouseLeave(object sender, EventArgs k)
        {
            bImagen.BackColor = Color.Gray;
        }
    }
}