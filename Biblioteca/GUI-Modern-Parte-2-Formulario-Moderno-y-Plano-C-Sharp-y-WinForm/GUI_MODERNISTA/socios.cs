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
    public partial class socios : Form
    {
        public socios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox4.Text;
            string apellidos = textBox3.Text;
            string fechaNac = textBox1.Text;
            string domicilio = textBox6.Text;
            string tfno = textBox5.Text;
            resultado.Text = "Datos introducidos:" + nombre + " / " + apellidos + " / " + fechaNac + " / " + domicilio + " / " + tfno;
            textBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
}
