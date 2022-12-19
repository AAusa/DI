namespace Ej1
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
        void Form1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.MouseMove += new MouseEventHandler(Form1_MouseMove);
            Text = "x:" + e.X + "y:" + e.Y;

        }

        void Form1_MouseLeave(object sender, EventArgs e)
        {
            Text = "Fuera del formulario";
        }

        private void panel1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    izq.BackColor = Color.Green;
                    break;
                case MouseButtons.Right:
                    dcha.BackColor = Color.Orange;
                    break;
                default:
                    izq.BackColor = Color.Blue;
                    dcha.BackColor = Color.Blue;
                    break;
            }
        }
        //keyChar o keyCode
        private void panel1_KeyDown(object sender, KeyPressEventArgs k)
        {
            switch (k.key)
            {
                case Keys.Escape:
                    Text = "titulo por defecto";
                    break;
                default:
                    Text = "" + k.ToString();
                    break;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.izq = new System.Windows.Forms.Button();
            this.dcha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // izq
            // 
            this.izq.Location = new System.Drawing.Point(98, 142);
            this.izq.Name = "izq";
            this.izq.Size = new System.Drawing.Size(75, 23);
            this.izq.TabIndex = 0;
            this.izq.Text = "izq.";
            this.izq.UseVisualStyleBackColor = true;
            // 
            // dcha
            // 
            this.dcha.Location = new System.Drawing.Point(179, 142);
            this.dcha.Name = "dcha";
            this.dcha.Size = new System.Drawing.Size(75, 23);
            this.dcha.TabIndex = 1;
            this.dcha.Text = "dcha.";
            this.dcha.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dcha);
            this.Controls.Add(this.izq);
            this.Name = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.panel1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        private void Form1_Load_2(object sender, EventArgs e)
        {

        }
    }
}