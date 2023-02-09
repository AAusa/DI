namespace Temporizador
{
    partial class EditarCuentaFecha
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
            this.lFecha = new System.Windows.Forms.Label();
            this.lHora = new System.Windows.Forms.Label();
            this.cbSonido = new System.Windows.Forms.ComboBox();
            this.lSonido = new System.Windows.Forms.Label();
            this.bIniciar = new System.Windows.Forms.Button();
            this.cbRepetir = new System.Windows.Forms.CheckBox();
            this.lTitulo = new System.Windows.Forms.Label();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.cbMensaje = new System.Windows.Forms.CheckBox();
            this.bProbar = new CustomControls.RJControls.bEditar();
            this.bCancelar = new CustomControls.RJControls.bReiniciar();
            this.bIniciar2 = new CustomControls.RJControls.bIniciar();
            this.tbFecha = new System.Windows.Forms.TextBox();
            this.tbHora = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lTituloForm
            // 
            this.lTituloForm.AutoSize = true;
            this.lTituloForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lTituloForm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.lTituloForm.ForeColor = System.Drawing.Color.White;
            this.lTituloForm.Location = new System.Drawing.Point(12, 23);
            this.lTituloForm.Name = "lTituloForm";
            this.lTituloForm.Size = new System.Drawing.Size(306, 26);
            this.lTituloForm.TabIndex = 0;
            this.lTituloForm.Text = "Editar temporizador: Fecha";
            this.lTituloForm.Click += new System.EventHandler(this.lTitulo_Click);
            // 
            // lFecha
            // 
            this.lFecha.AutoSize = true;
            this.lFecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.lFecha.ForeColor = System.Drawing.Color.White;
            this.lFecha.Location = new System.Drawing.Point(16, 75);
            this.lFecha.Name = "lFecha";
            this.lFecha.Size = new System.Drawing.Size(47, 15);
            this.lFecha.TabIndex = 3;
            this.lFecha.Text = "Fecha";
            // 
            // lHora
            // 
            this.lHora.AutoSize = true;
            this.lHora.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.lHora.ForeColor = System.Drawing.Color.White;
            this.lHora.Location = new System.Drawing.Point(255, 75);
            this.lHora.Name = "lHora";
            this.lHora.Size = new System.Drawing.Size(39, 15);
            this.lHora.TabIndex = 11;
            this.lHora.Text = "Hora";
            // 
            // cbSonido
            // 
            this.cbSonido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSonido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbSonido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSonido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.cbSonido.ForeColor = System.Drawing.Color.White;
            this.cbSonido.FormatString = "N0";
            this.cbSonido.FormattingEnabled = true;
            this.cbSonido.Location = new System.Drawing.Point(19, 176);
            this.cbSonido.Name = "cbSonido";
            this.cbSonido.Size = new System.Drawing.Size(181, 23);
            this.cbSonido.TabIndex = 20;
            this.cbSonido.SelectedIndexChanged += new System.EventHandler(this.cbSonido_SelectedIndexChanged);
            // 
            // lSonido
            // 
            this.lSonido.AutoSize = true;
            this.lSonido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.lSonido.ForeColor = System.Drawing.Color.White;
            this.lSonido.Location = new System.Drawing.Point(16, 147);
            this.lSonido.Name = "lSonido";
            this.lSonido.Size = new System.Drawing.Size(52, 15);
            this.lSonido.TabIndex = 19;
            this.lSonido.Text = "Sonido";
            // 
            // bIniciar
            // 
            this.bIniciar.BackColor = System.Drawing.Color.Black;
            this.bIniciar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bIniciar.FlatAppearance.BorderSize = 0;
            this.bIniciar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.bIniciar.ForeColor = System.Drawing.Color.White;
            this.bIniciar.Location = new System.Drawing.Point(206, 175);
            this.bIniciar.Name = "bIniciar";
            this.bIniciar.Size = new System.Drawing.Size(42, 23);
            this.bIniciar.TabIndex = 21;
            this.bIniciar.Text = "->";
            this.bIniciar.UseVisualStyleBackColor = false;
            this.bIniciar.Click += new System.EventHandler(this.bIniciar_Click);
            // 
            // cbRepetir
            // 
            this.cbRepetir.AutoSize = true;
            this.cbRepetir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.cbRepetir.ForeColor = System.Drawing.Color.White;
            this.cbRepetir.Location = new System.Drawing.Point(285, 179);
            this.cbRepetir.Name = "cbRepetir";
            this.cbRepetir.Size = new System.Drawing.Size(120, 19);
            this.cbRepetir.TabIndex = 23;
            this.cbRepetir.Text = "Repetir sonido";
            this.cbRepetir.UseVisualStyleBackColor = true;
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.lTitulo.ForeColor = System.Drawing.Color.White;
            this.lTitulo.Location = new System.Drawing.Point(16, 217);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(44, 15);
            this.lTitulo.TabIndex = 24;
            this.lTitulo.Text = "Título";
            // 
            // tbTitulo
            // 
            this.tbTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.tbTitulo.ForeColor = System.Drawing.Color.White;
            this.tbTitulo.Location = new System.Drawing.Point(18, 245);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(230, 23);
            this.tbTitulo.TabIndex = 25;
            this.tbTitulo.TextChanged += new System.EventHandler(this.tbTitulo_TextChanged);
            // 
            // cbMensaje
            // 
            this.cbMensaje.AutoSize = true;
            this.cbMensaje.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.cbMensaje.ForeColor = System.Drawing.Color.White;
            this.cbMensaje.Location = new System.Drawing.Point(19, 287);
            this.cbMensaje.Name = "cbMensaje";
            this.cbMensaje.Size = new System.Drawing.Size(107, 19);
            this.cbMensaje.TabIndex = 26;
            this.cbMensaje.Text = "Ver mensaje";
            this.cbMensaje.UseVisualStyleBackColor = true;
            this.cbMensaje.CheckedChanged += new System.EventHandler(this.cbMensaje_CheckedChanged);
            // 
            // bProbar
            // 
            this.bProbar.BackColor = System.Drawing.Color.MediumBlue;
            this.bProbar.BackgroundColor = System.Drawing.Color.MediumBlue;
            this.bProbar.BorderColor = System.Drawing.Color.MediumBlue;
            this.bProbar.BorderRadius = 20;
            this.bProbar.BorderSize = 3;
            this.bProbar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.bProbar.ForeColor = System.Drawing.Color.White;
            this.bProbar.Location = new System.Drawing.Point(19, 322);
            this.bProbar.Name = "bProbar";
            this.bProbar.Size = new System.Drawing.Size(87, 40);
            this.bProbar.TabIndex = 29;
            this.bProbar.Text = "Probar";
            this.bProbar.TextColor = System.Drawing.Color.White;
            this.bProbar.UseVisualStyleBackColor = false;
            this.bProbar.Click += new System.EventHandler(this.bProbar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.BackColor = System.Drawing.Color.Red;
            this.bCancelar.BackgroundColor = System.Drawing.Color.Red;
            this.bCancelar.BorderColor = System.Drawing.Color.Red;
            this.bCancelar.BorderRadius = 20;
            this.bCancelar.BorderSize = 3;
            this.bCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.bCancelar.ForeColor = System.Drawing.Color.White;
            this.bCancelar.Location = new System.Drawing.Point(312, 322);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(87, 40);
            this.bCancelar.TabIndex = 28;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.TextColor = System.Drawing.Color.White;
            this.bCancelar.UseVisualStyleBackColor = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bIniciar2
            // 
            this.bIniciar2.BackColor = System.Drawing.Color.Green;
            this.bIniciar2.BackgroundColor = System.Drawing.Color.Green;
            this.bIniciar2.BorderColor = System.Drawing.Color.Green;
            this.bIniciar2.BorderRadius = 20;
            this.bIniciar2.BorderSize = 3;
            this.bIniciar2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.bIniciar2.ForeColor = System.Drawing.Color.White;
            this.bIniciar2.Location = new System.Drawing.Point(405, 322);
            this.bIniciar2.Name = "bIniciar2";
            this.bIniciar2.Size = new System.Drawing.Size(87, 40);
            this.bIniciar2.TabIndex = 27;
            this.bIniciar2.Text = "Iniciar";
            this.bIniciar2.TextColor = System.Drawing.Color.White;
            this.bIniciar2.UseVisualStyleBackColor = false;
            this.bIniciar2.Click += new System.EventHandler(this.bIniciar2_Click);
            // 
            // tbFecha
            // 
            this.tbFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbFecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.tbFecha.ForeColor = System.Drawing.Color.White;
            this.tbFecha.Location = new System.Drawing.Point(18, 104);
            this.tbFecha.Name = "tbFecha";
            this.tbFecha.Size = new System.Drawing.Size(191, 23);
            this.tbFecha.TabIndex = 31;
            // 
            // tbHora
            // 
            this.tbHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbHora.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.tbHora.ForeColor = System.Drawing.Color.White;
            this.tbHora.Location = new System.Drawing.Point(258, 103);
            this.tbHora.Name = "tbHora";
            this.tbHora.Size = new System.Drawing.Size(191, 23);
            this.tbHora.TabIndex = 32;
            // 
            // EditarCuentaFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(517, 376);
            this.Controls.Add(this.tbHora);
            this.Controls.Add(this.tbFecha);
            this.Controls.Add(this.bProbar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bIniciar2);
            this.Controls.Add(this.cbMensaje);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.lTitulo);
            this.Controls.Add(this.cbRepetir);
            this.Controls.Add(this.bIniciar);
            this.Controls.Add(this.cbSonido);
            this.Controls.Add(this.lSonido);
            this.Controls.Add(this.lHora);
            this.Controls.Add(this.lFecha);
            this.Controls.Add(this.lTituloForm);
            this.Name = "EditarCuentaFecha";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTituloForm;
        private System.Windows.Forms.Label lFecha;
        private System.Windows.Forms.Label lHora;
        private System.Windows.Forms.ComboBox cbSonido;
        private System.Windows.Forms.Label lSonido;
        private System.Windows.Forms.Button bIniciar;
        private System.Windows.Forms.CheckBox cbRepetir;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.CheckBox cbMensaje;
        private CustomControls.RJControls.bIniciar bIniciar2;
        private CustomControls.RJControls.bReiniciar bCancelar;
        private CustomControls.RJControls.bEditar bProbar;
        private System.Windows.Forms.TextBox tbFecha;
        private System.Windows.Forms.TextBox tbHora;
    }
}