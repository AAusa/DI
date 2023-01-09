namespace Ej5Cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            DialogResult a;
            a = MessageBox.Show("Quieres establecer " + text + " como título?", "Cambiar titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (a == DialogResult.Yes)
            {
                Text = text;
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}