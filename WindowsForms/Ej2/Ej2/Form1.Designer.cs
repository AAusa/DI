namespace Ej2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bCerrar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.bColor = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.bImagen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(110, 230);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(192, 23);
            this.bCerrar.TabIndex = 0;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            this.bCerrar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cerrar_KeyDown);
            this.bCerrar.MouseEnter += new System.EventHandler(this.bCerrar_MouseEnter);
            this.bCerrar.MouseLeave += new System.EventHandler(this.bCerrar_MouseLeave);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cerrar_KeyDown);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 2;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cerrar_KeyDown);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(110, 153);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 3;
            this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cerrar_KeyDown);
            // 
            // bColor
            // 
            this.bColor.Location = new System.Drawing.Point(227, 153);
            this.bColor.Name = "bColor";
            this.bColor.Size = new System.Drawing.Size(75, 23);
            this.bColor.TabIndex = 4;
            this.bColor.Text = "Color";
            this.bColor.UseVisualStyleBackColor = true;
            this.bColor.Click += new System.EventHandler(this.bColor_Click);
            this.bColor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cerrar_KeyDown);
            this.bColor.MouseEnter += new System.EventHandler(this.bColor_MouseEnter);
            this.bColor.MouseLeave += new System.EventHandler(this.bColor_MouseLeave);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(110, 192);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 5;
            this.textBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cerrarImagen_KeyDown);
            // 
            // bImagen
            // 
            this.bImagen.Location = new System.Drawing.Point(227, 192);
            this.bImagen.Name = "bImagen";
            this.bImagen.Size = new System.Drawing.Size(75, 23);
            this.bImagen.TabIndex = 6;
            this.bImagen.Text = "Imagen";
            this.bImagen.UseVisualStyleBackColor = true;
            this.bImagen.Click += new System.EventHandler(this.bImagen_Click);
            this.bImagen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cerrarImagen_KeyDown);
            this.bImagen.MouseEnter += new System.EventHandler(this.bImagen_MouseEnter);
            this.bImagen.MouseLeave += new System.EventHandler(this.bImagen_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "R:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "G:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "B:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Path:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bImagen);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.bColor);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bCerrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cerrar_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bCerrar;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button bColor;
        private TextBox textBox4;
        private Button bImagen;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}