namespace Ej1Cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double valor1 = double.Parse(textBox1.Text);
                double valor2 = double.Parse(textBox2.Text);
                double solucion = valor1 + valor2;
                label2.Text = "= " + solucion.ToString();
            } catch (FormatException)
            {
                label2.Text = "= Introduzca números";
            }
        }
    }
}