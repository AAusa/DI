namespace Ej7Cs
{
    public partial class Form1 : Form
    {
        bool orden = true; // Saber numero a rellenar true: v1, false: v2
        int valor1,valor2, resultado, operacion;
        public Form1()
        {
            InitializeComponent();
        }


        private void button12_Click(object sender, EventArgs e)
        {
            switch(operacion)
            {
                case 0:
                    resultado = valor1 + valor2;
                    break;
                case 1:
                    resultado = valor1 - valor2;
                    break;
                case 2:
                    resultado = valor1 * valor2;
                    break;
                case 3:
                    resultado = valor1 / valor2;
                    break;
            }
            pantalla.Clear();
            pantalla.Text = resultado.ToString();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (orden)
            {
                valor1 = 2;
                pantalla.Text = valor1.ToString();
                orden = false;
            }
            else
            {
                valor2 = 2; pantalla.Clear(); pantalla.Text = valor2.ToString();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operacion = 0;
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (orden) 
            {
                valor1 = 1;
                pantalla.Text = valor1.ToString();
                orden = false; 
            }
            else 
            {
                valor2 = 1; pantalla.Clear(); pantalla.Text = valor2.ToString(); 
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (orden)
            {
                valor1 = 5;
                pantalla.Text = valor1.ToString();
                orden = false;
            }
            else
            {
                valor2 = 5; pantalla.Clear(); pantalla.Text = valor2.ToString();
            }
        }

        private void bMultiplicar_Click(object sender, EventArgs e)
        {
            operacion = 2;
        }

        private void bCe_Click(object sender, EventArgs e)
        {

        }

        private void bRaiz_Click(object sender, EventArgs e)
        {

        }

        private void b8_Click(object sender, EventArgs e)
        {
        }

        private void b7_Click(object sender, EventArgs e)
        {
        }

        private void b9_Click(object sender, EventArgs e)
        {
        }

        private void b6_Click(object sender, EventArgs e)
        {
        }

        private void bComa_Click(object sender, EventArgs e)
        {

        }

        private void bRestar_Click(object sender, EventArgs e)
        {
            operacion = 1;
        }

        private void bDivision_Click(object sender, EventArgs e)
        {
            operacion = 2;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (orden)
            {
                valor1 = 4;
                pantalla.Text = valor1.ToString();
                orden = false;
            }
            else
            {
                valor2 = 4; pantalla.Clear(); pantalla.Text = valor2.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bFraccion_Click(object sender, EventArgs e)
        {

        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (orden)
            {
                valor1 = 3;
                pantalla.Text = valor1.ToString();
                orden = false;
            }
            else
            {
                valor2 = 3; pantalla.Clear(); pantalla.Text = valor2.ToString();
            }
        }

        private void b0_Click(object sender, EventArgs e)
        {
            if (orden)
            {
                valor1 = 0;
                pantalla.Text = valor1.ToString();
                orden = false;
            }
            else
            {
                valor2 = 0; pantalla.Clear(); pantalla.Text = valor2.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}