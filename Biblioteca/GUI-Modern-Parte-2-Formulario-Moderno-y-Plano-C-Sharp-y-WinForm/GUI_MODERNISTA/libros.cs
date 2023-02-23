using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_MODERNISTA
{
    public partial class libros : Form
    {
        public libros()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string titulo = textBox4.Text;
            string autor = textBox3.Text;
            string editorial = textBox1.Text;
            string anoPublicacion = textBox2.Text;
            string isbn = textBox6.Text;
            string numEjemplares = textBox5.Text;
            string numPaginas = textBox7.Text;

            resultado.Text = "Datos introducidos:\n" + titulo + " / " + autor + " / "+ editorial + " /\n " + anoPublicacion +" / "+isbn + " / " + numEjemplares + " / "+ numPaginas;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }
    }
}
