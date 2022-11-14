using System;

namespace Ej7Cs
{
    public partial class Form1 : Form
    {
        bool orden = true; // Saber numero a rellenar true: v1, false: v2
        int valor, operacion;
        double resultado = 0;
        public Form1()
        {
            InitializeComponent();
            Text = "Calculadora";
        }

        private void operar()
        {
            switch (operacion)
            {
                case 0: //suma
                    resultado += valor;
                    break;
                case 1: //resta
                    resultado -= valor;
                    break;
                case 2: //multi
                    resultado *= valor;
                    break;
                case 3: //div
                    resultado /= valor;
                    break;
                case 4: //pot
                    resultado *= resultado;
                    break;
                case 5: //raiz
                    resultado = Math.Sqrt(Convert.ToDouble(pantalla.Text));
                    break;
                case 6: //fraccion
                    resultado = 1 / Convert.ToDouble(pantalla.Text);
                    break;
                case 7: //porcentaje
                    resultado = Convert.ToDouble(pantalla.Text) / 100;
                    break;
                case 8: //masMenos
                    resultado = - Convert.ToDouble(pantalla.Text);
                    break;
            }
            pantalla.Clear();
            pantalla.Text = resultado.ToString();
        }

        private void bResultado_Click(object sender, EventArgs e)
        {
            operar();
        }

        private void b0_Click(object sender, EventArgs e)
        {
            valor = 0;
            pantalla.Text += valor.ToString();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            valor = 1;
            pantalla.Text += valor.ToString();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            valor = 2;
            pantalla.Text += valor.ToString();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            valor = 3;
            pantalla.Text += valor.ToString();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            valor = 4;
            pantalla.Text += valor.ToString();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            valor = 5;
            pantalla.Text += valor.ToString();
        }

        private void b6_Click(object sender, EventArgs e)
        {
            valor = 6;
            pantalla.Text += valor.ToString();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            valor = 7;
            pantalla.Text += valor.ToString();
        }

        private void b8_Click(object sender, EventArgs e)
        {
            valor = 8;
            pantalla.Text += valor.ToString();
        }

        private void b9_Click(object sender, EventArgs e)
        {
            valor = 9;
            pantalla.Text += valor.ToString();
        }

        private void bC_Click(object sender, EventArgs e)
        {
            valor = 0;
            resultado = 0;
            pantalla.Text = "";
        }


        private void bCe_Click(object sender, EventArgs e)
        {
            pantalla.Text = "";
            valor = 0;
        }

        private void bRaiz_Click(object sender, EventArgs e)
        {
            operacion = 5;
            operar();
        }

        private void bComa_Click(object sender, EventArgs e)
        {
            pantalla.Text += ",";
        }

        private void bSuma_Click (object sender, EventArgs e)
        {
            resultado = Convert.ToDouble(pantalla.Text);
            pantalla.Text = "";
            operacion = 0;
        }

        private void bRestar_Click(object sender, EventArgs e)
        {
            resultado = Convert.ToDouble(pantalla.Text);
            pantalla.Text = "";
            operacion = 1;       
        }

        private void bMultiplicar_Click(object sender, EventArgs e)
        {
            resultado = Convert.ToDouble(pantalla.Text);
            pantalla.Text = "";
            operacion = 2;
        }

        private void bDivision_Click(object sender, EventArgs e)
        {
            resultado = Convert.ToDouble(pantalla.Text);
            pantalla.Text = "";
            operacion = 3;
        }


        private void bFraccion_Click(object sender, EventArgs e)
        {
            operacion = 6;
            operar();
        }

        private void masMenos_Click(object sender, EventArgs e)
        {
            operacion = 8;
            operar();
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            if (pantalla.Text.Length > 0)
            {
                pantalla.Text = pantalla.Text.Remove(pantalla.Text.Length - 1, 1);
            }
        }

        private void bPotencia_Click(object sender, EventArgs e)
        {
            resultado = Convert.ToDouble(pantalla.Text);
            pantalla.Text = "";
            operacion = 4;
            operar();
        }

        private void bPorcentaje_Click(object sender, EventArgs e)
        {
            operacion = 7;
            operar();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}