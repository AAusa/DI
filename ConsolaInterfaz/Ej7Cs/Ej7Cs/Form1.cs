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
            //if (orden)
            //{
            //    valor = 0;
            //    pantalla.Text = valor.ToString();
            //}
            //else
            //{
            //    valor = 0; pantalla.Clear(); pantalla.Text = valor.ToString();
            //}
        }

        private void b1_Click(object sender, EventArgs e)
        {
            valor = 1;
            pantalla.Text += valor.ToString();
            //if (orden)
            //{
            //    valor = 1;
            //    pantalla.Text = valor.ToString();
            //}
            //else
            //{
            //    valor = 1; pantalla.Clear(); pantalla.Text = valor.ToString();
            //}
        }

        private void b2_Click(object sender, EventArgs e)
        {
            valor = 2;
            pantalla.Text += valor.ToString();
            //if (orden)
            //{
            //    valor = 2;
            //    pantalla.Text = valor.ToString();
            //}
            //else
            //{
            //    valor = 2; pantalla.Clear(); pantalla.Text = valor.ToString();
            //}
        }

        private void b3_Click(object sender, EventArgs e)
        {
            valor = 3;
            pantalla.Text += valor.ToString();
            //if (orden)
            //{
            //    valor = 3;
            //    pantalla.Text = valor.ToString();
            //}
            //else
            //{
            //    valor = 3; pantalla.Clear(); pantalla.Text = valor.ToString();
            //}
        }

        private void b4_Click(object sender, EventArgs e)
        {
            valor = 4;
            pantalla.Text += valor.ToString();
            //if (orden)
            //{
            //    valor = 4;
            //    pantalla.Text = valor.ToString();
            //}
            //else
            //{
            //    valor = 4; pantalla.Clear(); pantalla.Text = valor.ToString();
            //}
        }

        private void b5_Click(object sender, EventArgs e)
        {
            valor = 5;
            pantalla.Text += valor.ToString();
            //if (orden)
            //{
            //    valor = 5;
            //    pantalla.Text = valor.ToString();
            //}
            //else
            //{
            //    valor = 5; pantalla.Clear(); pantalla.Text = valor.ToString();
            //}
        }

        private void b6_Click(object sender, EventArgs e)
        {
            valor = 6;
            pantalla.Text += valor.ToString();
            //if (orden)
            //{
            //    valor = 6;
            //    pantalla.Text = valor.ToString();
            //}
            //else
            //{
            //    valor = 6; pantalla.Clear(); pantalla.Text = valor.ToString();
            //}
        }

        private void b7_Click(object sender, EventArgs e)
        {
            valor = 7;
            pantalla.Text += valor.ToString();
            //if (orden)
            //{
            //    valor = 7;
            //    pantalla.Text = valor.ToString();
            //}
            //else
            //{
            //    valor = 7; pantalla.Clear(); pantalla.Text = valor.ToString();
            //}
        }

        private void b8_Click(object sender, EventArgs e)
        {
            valor = 8;
            pantalla.Text += valor.ToString();
            //if (orden)
            //{
            //    valor = 8;
            //    pantalla.Text = valor.ToString();
            //}
            //else
            //{
            //    valor = 8; pantalla.Clear(); pantalla.Text = valor.ToString();
            //}
        }

        private void b9_Click(object sender, EventArgs e)
        {
            valor = 9;
            pantalla.Text += valor.ToString();
            //if (orden)
            //{
            //    valor = 9;
            //    pantalla.Text = valor.ToString();
            //}
            //else
            //{
            //    valor = 9; pantalla.Clear(); pantalla.Text = valor.ToString();
            //}
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

        }

        private void bComa_Click(object sender, EventArgs e)
        {

        }

        private void bSuma_Click(object sender, EventArgs e)
        {
            resultado = int.Parse(pantalla.Text);//Resultado tiene el primer digito
            pantalla.Text = "";
            operacion = 0;
            //orden = false;
            //operar();

        }

        private void bRestar_Click(object sender, EventArgs e)
        {
            resultado = int.Parse(pantalla.Text);//Resultado tiene el primer digito
            pantalla.Text = "";
            operacion = 1;
            //orden = false;
            //operacion = 1;
            //if (resultado > 0)
            //{
            //    operar();
            //}
            //else
            //{
            //    resultado = valor;
            //}        
        }

        private void bMultiplicar_Click(object sender, EventArgs e)
        {
            resultado = int.Parse(pantalla.Text);//Resultado tiene el primer digito
            pantalla.Text = "";
            operacion = 2;
            //orden = false;
            //operacion = 2;
            //if (resultado > 0)
            //{
            //    operar();
            //}
            //else
            //{
            //    resultado = valor;
            //}
        }

        private void bDivision_Click(object sender, EventArgs e)
        {
            resultado = int.Parse(pantalla.Text);//Resultado tiene el primer digito
            pantalla.Text = "";
            operacion = 3;
            //orden = false;
            //operacion = 3;
            //if (resultado > 0)
            //{
            //    operar();
            //}
            //else
            //{
            //    resultado = valor;
            //}
        }


        private void bFraccion_Click(object sender, EventArgs e)
        {

        }

        private void masMenos_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}