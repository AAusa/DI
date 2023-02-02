namespace Temporizador
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bIniciar1 = new CustomControls.RJControls.bIniciar();
            this.bReiniciar1 = new CustomControls.RJControls.bReiniciar();
            this.bEditar1 = new CustomControls.RJControls.bEditar();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(110, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 75);
            this.label1.TabIndex = 3;
            // 
            // bIniciar1
            // 
            this.bIniciar1.BackColor = System.Drawing.Color.Green;
            this.bIniciar1.BackgroundColor = System.Drawing.Color.Green;
            this.bIniciar1.BorderColor = System.Drawing.Color.Green;
            this.bIniciar1.BorderRadius = 20;
            this.bIniciar1.BorderSize = 3;
            this.bIniciar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bIniciar1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.bIniciar1.ForeColor = System.Drawing.Color.White;
            this.bIniciar1.Location = new System.Drawing.Point(328, 286);
            this.bIniciar1.Name = "bIniciar1";
            this.bIniciar1.Size = new System.Drawing.Size(90, 40);
            this.bIniciar1.TabIndex = 2;
            this.bIniciar1.Text = "Iniciar";
            this.bIniciar1.TextColor = System.Drawing.Color.White;
            this.bIniciar1.UseVisualStyleBackColor = false;
            this.bIniciar1.Click += new System.EventHandler(this.bIniciar1_Click);
            // 
            // bReiniciar1
            // 
            this.bReiniciar1.BackColor = System.Drawing.Color.Orange;
            this.bReiniciar1.BackgroundColor = System.Drawing.Color.Orange;
            this.bReiniciar1.BorderColor = System.Drawing.Color.Orange;
            this.bReiniciar1.BorderRadius = 20;
            this.bReiniciar1.BorderSize = 3;
            this.bReiniciar1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.bReiniciar1.ForeColor = System.Drawing.Color.White;
            this.bReiniciar1.Location = new System.Drawing.Point(210, 286);
            this.bReiniciar1.Name = "bReiniciar1";
            this.bReiniciar1.Size = new System.Drawing.Size(90, 40);
            this.bReiniciar1.TabIndex = 1;
            this.bReiniciar1.Text = "Reiniciar";
            this.bReiniciar1.TextColor = System.Drawing.Color.White;
            this.bReiniciar1.UseVisualStyleBackColor = false;
            this.bReiniciar1.Click += new System.EventHandler(this.bReiniciar1_Click);
            // 
            // bEditar1
            // 
            this.bEditar1.BackColor = System.Drawing.Color.MediumBlue;
            this.bEditar1.BackgroundColor = System.Drawing.Color.MediumBlue;
            this.bEditar1.BorderColor = System.Drawing.Color.MediumBlue;
            this.bEditar1.BorderRadius = 20;
            this.bEditar1.BorderSize = 3;
            this.bEditar1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEditar1.ForeColor = System.Drawing.Color.White;
            this.bEditar1.Location = new System.Drawing.Point(92, 286);
            this.bEditar1.Name = "bEditar1";
            this.bEditar1.Size = new System.Drawing.Size(90, 40);
            this.bEditar1.TabIndex = 0;
            this.bEditar1.Text = "Editar";
            this.bEditar1.TextColor = System.Drawing.Color.White;
            this.bEditar1.UseVisualStyleBackColor = false;
            this.bEditar1.Click += new System.EventHandler(this.bEditar1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(85, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 32);
            this.label2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bIniciar1);
            this.Controls.Add(this.bReiniciar1);
            this.Controls.Add(this.bEditar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.bEditar bEditar1;
        private CustomControls.RJControls.bReiniciar bReiniciar1;
        private CustomControls.RJControls.bIniciar bIniciar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

