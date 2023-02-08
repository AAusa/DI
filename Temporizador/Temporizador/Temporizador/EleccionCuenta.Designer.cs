namespace Temporizador
{
    partial class EleccionCuenta
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
            this.lTitulo = new System.Windows.Forms.Label();
            this.rbCuenta = new System.Windows.Forms.RadioButton();
            this.rbFecha = new System.Windows.Forms.RadioButton();
            this.bAceptar = new CustomControls.RJControls.bIniciar();
            this.SuspendLayout();
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.lTitulo.ForeColor = System.Drawing.Color.White;
            this.lTitulo.Location = new System.Drawing.Point(13, 26);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(242, 26);
            this.lTitulo.TabIndex = 0;
            this.lTitulo.Text = "Edición temporizador";
            // 
            // rbCuenta
            // 
            this.rbCuenta.AutoSize = true;
            this.rbCuenta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.rbCuenta.ForeColor = System.Drawing.Color.White;
            this.rbCuenta.Location = new System.Drawing.Point(42, 79);
            this.rbCuenta.Name = "rbCuenta";
            this.rbCuenta.Size = new System.Drawing.Size(110, 19);
            this.rbCuenta.TabIndex = 1;
            this.rbCuenta.TabStop = true;
            this.rbCuenta.Text = "Cuenta Atrás";
            this.rbCuenta.UseVisualStyleBackColor = true;
            // 
            // rbFecha
            // 
            this.rbFecha.AutoSize = true;
            this.rbFecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.rbFecha.ForeColor = System.Drawing.Color.White;
            this.rbFecha.Location = new System.Drawing.Point(42, 104);
            this.rbFecha.Name = "rbFecha";
            this.rbFecha.Size = new System.Drawing.Size(258, 19);
            this.rbFecha.TabIndex = 2;
            this.rbFecha.TabStop = true;
            this.rbFecha.Text = "Contar hasta (desde) fecha y tiempo";
            this.rbFecha.UseVisualStyleBackColor = true;
            // 
            // bAceptar
            // 
            this.bAceptar.BackColor = System.Drawing.Color.Green;
            this.bAceptar.BackgroundColor = System.Drawing.Color.Green;
            this.bAceptar.BorderColor = System.Drawing.Color.Green;
            this.bAceptar.BorderRadius = 20;
            this.bAceptar.BorderSize = 3;
            this.bAceptar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.bAceptar.ForeColor = System.Drawing.Color.White;
            this.bAceptar.Location = new System.Drawing.Point(119, 158);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(87, 40);
            this.bAceptar.TabIndex = 3;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.TextColor = System.Drawing.Color.White;
            this.bAceptar.UseVisualStyleBackColor = false;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // EleccionCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(325, 214);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.rbFecha);
            this.Controls.Add(this.rbCuenta);
            this.Controls.Add(this.lTitulo);
            this.Name = "EleccionCuenta";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.RadioButton rbCuenta;
        private System.Windows.Forms.RadioButton rbFecha;
        private CustomControls.RJControls.bIniciar bAceptar;
    }
}