namespace SimonDice
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_puntaje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.p_3 = new System.Windows.Forms.PictureBox();
            this.p_2 = new System.Windows.Forms.PictureBox();
            this.p_1 = new System.Windows.Forms.PictureBox();
            this.p_0 = new System.Windows.Forms.PictureBox();
            this.btn_iniciar = new CustomControls.RJControls.bIniciarJuego();
            ((System.ComponentModel.ISupportInitialize)(this.p_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_0)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_puntaje
            // 
            this.lbl_puntaje.AutoSize = true;
            this.lbl_puntaje.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_puntaje.ForeColor = System.Drawing.Color.White;
            this.lbl_puntaje.Location = new System.Drawing.Point(157, 14);
            this.lbl_puntaje.Name = "lbl_puntaje";
            this.lbl_puntaje.Size = new System.Drawing.Size(39, 38);
            this.lbl_puntaje.TabIndex = 5;
            this.lbl_puntaje.Text = "--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Puntaje:";
            // 
            // p_3
            // 
            this.p_3.Image = global::SimonDice.Properties.Resources.c;
            this.p_3.Location = new System.Drawing.Point(160, 195);
            this.p_3.Name = "p_3";
            this.p_3.Size = new System.Drawing.Size(150, 150);
            this.p_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.p_3.TabIndex = 3;
            this.p_3.TabStop = false;
            this.p_3.Click += new System.EventHandler(this.p_0_Click);
            this.p_3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_3_MouseDown);
            this.p_3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_3_MouseUp);
            // 
            // p_2
            // 
            this.p_2.Image = global::SimonDice.Properties.Resources.d;
            this.p_2.Location = new System.Drawing.Point(26, 195);
            this.p_2.Name = "p_2";
            this.p_2.Size = new System.Drawing.Size(150, 150);
            this.p_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.p_2.TabIndex = 2;
            this.p_2.TabStop = false;
            this.p_2.Click += new System.EventHandler(this.p_0_Click);
            this.p_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_2_MouseDown);
            this.p_2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_2_MouseUp);
            // 
            // p_1
            // 
            this.p_1.Image = global::SimonDice.Properties.Resources.b;
            this.p_1.Location = new System.Drawing.Point(160, 60);
            this.p_1.Name = "p_1";
            this.p_1.Size = new System.Drawing.Size(150, 150);
            this.p_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.p_1.TabIndex = 1;
            this.p_1.TabStop = false;
            this.p_1.Click += new System.EventHandler(this.p_0_Click);
            this.p_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_1_MouseDown);
            this.p_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_1_MouseUp);
            // 
            // p_0
            // 
            this.p_0.Image = global::SimonDice.Properties.Resources.a;
            this.p_0.Location = new System.Drawing.Point(26, 60);
            this.p_0.Name = "p_0";
            this.p_0.Size = new System.Drawing.Size(150, 150);
            this.p_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.p_0.TabIndex = 0;
            this.p_0.TabStop = false;
            this.p_0.Click += new System.EventHandler(this.p_0_Click);
            this.p_0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_0_MouseDown);
            this.p_0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_0_MouseUp);
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.BackColor = System.Drawing.Color.White;
            this.btn_iniciar.FlatAppearance.BorderSize = 5;
            this.btn_iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iniciar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F);
            this.btn_iniciar.ForeColor = System.Drawing.Color.Black;
            this.btn_iniciar.Location = new System.Drawing.Point(26, 351);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(284, 65);
            this.btn_iniciar.TabIndex = 7;
            this.btn_iniciar.Text = "Iniciar juego";
            this.btn_iniciar.UseVisualStyleBackColor = false;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(334, 437);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_puntaje);
            this.Controls.Add(this.p_3);
            this.Controls.Add(this.p_2);
            this.Controls.Add(this.p_1);
            this.Controls.Add(this.p_0);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Simón Dice:";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox p_1;
        private System.Windows.Forms.PictureBox p_2;
        private System.Windows.Forms.PictureBox p_3;
        private System.Windows.Forms.Label lbl_puntaje;
        public System.Windows.Forms.PictureBox p_0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_iniciar;
    }
}

