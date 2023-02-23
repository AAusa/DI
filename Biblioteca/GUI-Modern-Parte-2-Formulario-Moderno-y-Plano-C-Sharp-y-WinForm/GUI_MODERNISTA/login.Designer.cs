namespace GUI_MODERNISTA
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.lTitulo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lusuario = new System.Windows.Forms.Label();
            this.lcontrasena = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ldescripcion = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.resultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.lTitulo.ForeColor = System.Drawing.Color.White;
            this.lTitulo.Location = new System.Drawing.Point(87, 29);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(107, 33);
            this.lTitulo.TabIndex = 0;
            this.lTitulo.Text = "LOGIN:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.textBox1.Location = new System.Drawing.Point(260, 218);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 33);
            this.textBox1.TabIndex = 1;
            // 
            // lusuario
            // 
            this.lusuario.AutoSize = true;
            this.lusuario.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lusuario.ForeColor = System.Drawing.Color.White;
            this.lusuario.Location = new System.Drawing.Point(94, 221);
            this.lusuario.Name = "lusuario";
            this.lusuario.Size = new System.Drawing.Size(102, 24);
            this.lusuario.TabIndex = 2;
            this.lusuario.Text = "USUARIO:";
            // 
            // lcontrasena
            // 
            this.lcontrasena.AutoSize = true;
            this.lcontrasena.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lcontrasena.ForeColor = System.Drawing.Color.White;
            this.lcontrasena.Location = new System.Drawing.Point(94, 285);
            this.lcontrasena.Name = "lcontrasena";
            this.lcontrasena.Size = new System.Drawing.Size(154, 24);
            this.lcontrasena.TabIndex = 4;
            this.lcontrasena.Text = "CONTRASEÑA:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.textBox2.Location = new System.Drawing.Point(260, 282);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(253, 33);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(98, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(415, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ldescripcion
            // 
            this.ldescripcion.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldescripcion.ForeColor = System.Drawing.Color.White;
            this.ldescripcion.Location = new System.Drawing.Point(89, 95);
            this.ldescripcion.Name = "ldescripcion";
            this.ldescripcion.Size = new System.Drawing.Size(435, 100);
            this.ldescripcion.TabIndex = 8;
            this.ldescripcion.Text = "Para acceder a la interfaz de gestión  de BibliotecAuxa, debes registrarte con us" +
    "uario y contraseña:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(626, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(293, 335);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.resultado.ForeColor = System.Drawing.Color.White;
            this.resultado.Location = new System.Drawing.Point(94, 409);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(0, 24);
            this.resultado.TabIndex = 10;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 612);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ldescripcion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lcontrasena);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lusuario);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Text = "productos";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lusuario;
        private System.Windows.Forms.Label lcontrasena;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ldescripcion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label resultado;
    }
}