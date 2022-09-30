namespace Ehj2Cs
{
    public partial class Form1 : Form
    {
        int saldo = 50;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(saldo >= 2)
            {
                Random random = new Random();
                int num1 = random.Next(1, 7);
                int num2 = random.Next(1, 7);
                int num3 = random.Next(1, 7);
                textBox1.Text = num1.ToString();
                textBox2.Text = num2.ToString();
                textBox3.Text = num3.ToString();
                saldo = saldo - 2;
                int premio = 0;
                if(num1 == num2 && num2  == num3)
                {
                    premio = 20;
                    saldo = saldo + premio;
                    label1.Text = "Premio: " + premio + "€";
                }
                else if (num1 == num2 || num1 == num3 || num2 == num3)
                {
                    premio = 5;
                    saldo = saldo + premio;
                    label1.Text = "Premio: " + premio + "€";
                }
                else
                {
                    premio = 0;
                    label1.Text = "Premio: " + premio + "€";
                }
                credito.Text = "Crédito: " + saldo + "€";

            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            saldo = saldo + 10;
            credito.Text = "Crédito: " + saldo + "€";
        }
    }
}