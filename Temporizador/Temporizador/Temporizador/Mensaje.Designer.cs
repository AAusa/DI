﻿namespace Temporizador
{
    partial class Mensaje
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
            this.lTituloForm = new System.Windows.Forms.Label();
            this.lTitulo = new System.Windows.Forms.Label();
            this.lTiempo = new System.Windows.Forms.Label();
            this.bAceptar = new CustomControls.RJControls.bReiniciar();
            this.SuspendLayout();
            // 
            // lTituloForm
            // 
            this.lTituloForm.AutoSize = true;
            this.lTituloForm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.lTituloForm.ForeColor = System.Drawing.Color.White;
            this.lTituloForm.Location = new System.Drawing.Point(12, 9);
            this.lTituloForm.Name = "lTituloForm";
            this.lTituloForm.Size = new System.Drawing.Size(162, 26);
            this.lTituloForm.TabIndex = 0;
            this.lTituloForm.Text = "Temporizador";
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitulo.ForeColor = System.Drawing.Color.White;
            this.lTitulo.Location = new System.Drawing.Point(17, 64);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(0, 18);
            this.lTitulo.TabIndex = 1;
            // 
            // lTiempo
            // 
            this.lTiempo.AutoSize = true;
            this.lTiempo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lTiempo.ForeColor = System.Drawing.Color.White;
            this.lTiempo.Location = new System.Drawing.Point(17, 101);
            this.lTiempo.Name = "lTiempo";
            this.lTiempo.Size = new System.Drawing.Size(0, 18);
            this.lTiempo.TabIndex = 2;
            // 
            // bAceptar
            // 
            this.bAceptar.BackColor = System.Drawing.Color.Orange;
            this.bAceptar.BackgroundColor = System.Drawing.Color.Orange;
            this.bAceptar.BorderColor = System.Drawing.Color.Orange;
            this.bAceptar.BorderRadius = 20;
            this.bAceptar.BorderSize = 3;
            this.bAceptar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.bAceptar.ForeColor = System.Drawing.Color.White;
            this.bAceptar.Location = new System.Drawing.Point(112, 144);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(90, 40);
            this.bAceptar.TabIndex = 3;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.TextColor = System.Drawing.Color.White;
            this.bAceptar.UseVisualStyleBackColor = false;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(317, 228);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.lTiempo);
            this.Controls.Add(this.lTitulo);
            this.Controls.Add(this.lTituloForm);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTituloForm;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.Label lTiempo;
        private CustomControls.RJControls.bReiniciar bAceptar;
    }
}