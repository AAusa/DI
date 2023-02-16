namespace GUI_MODERNISTA
{
    partial class biblioteca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(biblioteca));
            this.ldescripcion = new System.Windows.Forms.Label();
            this.lTitulo = new System.Windows.Forms.Label();
            this.lLibro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lSocios = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ldescripcion
            // 
            this.ldescripcion.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldescripcion.ForeColor = System.Drawing.Color.White;
            this.ldescripcion.Location = new System.Drawing.Point(83, 107);
            this.ldescripcion.Name = "ldescripcion";
            this.ldescripcion.Size = new System.Drawing.Size(435, 100);
            this.ldescripcion.TabIndex = 16;
            this.ldescripcion.Text = "Presiona un subelemento de Biblioteca en el menú vertical para gestionar:";
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.lTitulo.ForeColor = System.Drawing.Color.White;
            this.lTitulo.Location = new System.Drawing.Point(81, 41);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(167, 33);
            this.lTitulo.TabIndex = 10;
            this.lTitulo.Text = "BIBLIOTECA:";
            this.lTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lLibro
            // 
            this.lLibro.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLibro.ForeColor = System.Drawing.Color.White;
            this.lLibro.Location = new System.Drawing.Point(134, 176);
            this.lLibro.Name = "lLibro";
            this.lLibro.Size = new System.Drawing.Size(95, 40);
            this.lLibro.TabIndex = 18;
            this.lLibro.Text = "- Libros";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(134, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 40);
            this.label1.TabIndex = 19;
            this.label1.Text = "- Préstamos";
            // 
            // lSocios
            // 
            this.lSocios.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSocios.ForeColor = System.Drawing.Color.White;
            this.lSocios.Location = new System.Drawing.Point(134, 216);
            this.lSocios.Name = "lSocios";
            this.lSocios.Size = new System.Drawing.Size(95, 40);
            this.lSocios.TabIndex = 20;
            this.lSocios.Text = "- Socios";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(548, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(442, 238);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // biblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1064, 573);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lSocios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lLibro);
            this.Controls.Add(this.ldescripcion);
            this.Controls.Add(this.lTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "biblioteca";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ldescripcion;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.Label lLibro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lSocios;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}