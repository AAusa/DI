using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI_MODERNISTA
{
    public partial class prestamos : Form
    {
        public prestamos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isbn = textBox3.Text;
            string nombre = textBox1.Text;
            string fechaInicio = textBox6.Text;
            string fechaFin = textBox5.Text;
            resultado.Text = "Datos introducidos:" + isbn + " / " + nombre + " / " + fechaInicio + " / " + fechaFin;
            textBox1.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
}
