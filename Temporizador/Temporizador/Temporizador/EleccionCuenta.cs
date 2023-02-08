using CustomControls.RJControls;
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
    public partial class EleccionCuenta : Form
    {
        public EleccionCuenta()
        {
            InitializeComponent();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (rbCuenta.Checked)//reiniciar
            {
                EditarCuentaAtras eca = new EditarCuentaAtras();
                this.Hide();
                eca.Show();
            }
            if (rbFecha.Checked)//crono
            {
                EditarCuentaFecha ecf = new EditarCuentaFecha();
                this.Hide();
                ecf.Show();  
            }
        }
    }
}
