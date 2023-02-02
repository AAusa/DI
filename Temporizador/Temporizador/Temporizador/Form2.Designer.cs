namespace Temporizador
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbHoras = new System.Windows.Forms.ComboBox();
            this.bHorasMenos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bMinMas = new System.Windows.Forms.Button();
            this.bMinMenos = new System.Windows.Forms.Button();
            this.cbMin = new System.Windows.Forms.ComboBox();
            this.lMin = new System.Windows.Forms.Label();
            this.bSegMas = new System.Windows.Forms.Button();
            this.bSegMenos = new System.Windows.Forms.Button();
            this.cbSeg = new System.Windows.Forms.ComboBox();
            this.lSeg = new System.Windows.Forms.Label();
            this.lenCero = new System.Windows.Forms.Label();
            this.rbReiniciar = new System.Windows.Forms.RadioButton();
            this.rbParar = new System.Windows.Forms.RadioButton();
            this.rbCrono = new System.Windows.Forms.RadioButton();
            this.cbSonido = new System.Windows.Forms.ComboBox();
            this.lSonido = new System.Windows.Forms.Label();
            this.bIniciar = new System.Windows.Forms.Button();
            this.bPuntos = new System.Windows.Forms.Button();
            this.cbRepetir = new System.Windows.Forms.CheckBox();
            this.lTitulo = new System.Windows.Forms.Label();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.cbMensaje = new System.Windows.Forms.CheckBox();
            this.bIniciar2 = new CustomControls.RJControls.bIniciar();
            this.bCancelar = new CustomControls.RJControls.bReiniciar();
            this.bProbar = new CustomControls.RJControls.bEditar();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.rbCuentaAtrasT = new System.Windows.Forms.RadioButton();
            this.rbCuentaFechaT = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gb1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.lTituloForm.Size = new System.Drawing.Size(228, 26);
            this.lTituloForm.TabIndex = 0;
            this.lTituloForm.Text = "Editar temporizador";
            this.lTituloForm.Click += new System.EventHandler(this.lTitulo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Horas";
            // 
            // cbHoras
            // 
            this.cbHoras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbHoras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbHoras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbHoras.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.cbHoras.ForeColor = System.Drawing.Color.White;
            this.cbHoras.FormatString = "N0";
            this.cbHoras.FormattingEnabled = true;
            this.cbHoras.Location = new System.Drawing.Point(64, 164);
            this.cbHoras.Name = "cbHoras";
            this.cbHoras.Size = new System.Drawing.Size(50, 23);
            this.cbHoras.TabIndex = 4;
            this.cbHoras.SelectedIndexChanged += new System.EventHandler(this.cbHoras_SelectedIndexChanged);
            // 
            // bHorasMenos
            // 
            this.bHorasMenos.BackColor = System.Drawing.Color.Black;
            this.bHorasMenos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bHorasMenos.FlatAppearance.BorderSize = 0;
            this.bHorasMenos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.bHorasMenos.ForeColor = System.Drawing.Color.White;
            this.bHorasMenos.Location = new System.Drawing.Point(18, 164);
            this.bHorasMenos.Name = "bHorasMenos";
            this.bHorasMenos.Size = new System.Drawing.Size(42, 23);
            this.bHorasMenos.TabIndex = 5;
            this.bHorasMenos.Text = "<";
            this.bHorasMenos.UseVisualStyleBackColor = false;
            this.bHorasMenos.Click += new System.EventHandler(this.bHorasMenos_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(119, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bMinMas
            // 
            this.bMinMas.BackColor = System.Drawing.Color.Black;
            this.bMinMas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bMinMas.FlatAppearance.BorderSize = 0;
            this.bMinMas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.bMinMas.ForeColor = System.Drawing.Color.White;
            this.bMinMas.Location = new System.Drawing.Point(283, 164);
            this.bMinMas.Name = "bMinMas";
            this.bMinMas.Size = new System.Drawing.Size(42, 23);
            this.bMinMas.TabIndex = 10;
            this.bMinMas.Text = ">";
            this.bMinMas.UseVisualStyleBackColor = false;
            this.bMinMas.Click += new System.EventHandler(this.bMinMas_Click);
            // 
            // bMinMenos
            // 
            this.bMinMenos.BackColor = System.Drawing.Color.Black;
            this.bMinMenos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bMinMenos.FlatAppearance.BorderSize = 0;
            this.bMinMenos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.bMinMenos.ForeColor = System.Drawing.Color.White;
            this.bMinMenos.Location = new System.Drawing.Point(182, 164);
            this.bMinMenos.Name = "bMinMenos";
            this.bMinMenos.Size = new System.Drawing.Size(42, 23);
            this.bMinMenos.TabIndex = 9;
            this.bMinMenos.Text = "<";
            this.bMinMenos.UseVisualStyleBackColor = false;
            this.bMinMenos.Click += new System.EventHandler(this.bMinMenos_Click);
            // 
            // cbMin
            // 
            this.cbMin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.cbMin.ForeColor = System.Drawing.Color.White;
            this.cbMin.FormatString = "N0";
            this.cbMin.FormattingEnabled = true;
            this.cbMin.Location = new System.Drawing.Point(228, 164);
            this.cbMin.Name = "cbMin";
            this.cbMin.Size = new System.Drawing.Size(50, 23);
            this.cbMin.TabIndex = 8;
            // 
            // lMin
            // 
            this.lMin.AutoSize = true;
            this.lMin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.lMin.ForeColor = System.Drawing.Color.White;
            this.lMin.Location = new System.Drawing.Point(179, 136);
            this.lMin.Name = "lMin";
            this.lMin.Size = new System.Drawing.Size(58, 15);
            this.lMin.TabIndex = 7;
            this.lMin.Text = "Minutos";
            // 
            // bSegMas
            // 
            this.bSegMas.BackColor = System.Drawing.Color.Black;
            this.bSegMas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bSegMas.FlatAppearance.BorderSize = 0;
            this.bSegMas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.bSegMas.ForeColor = System.Drawing.Color.White;
            this.bSegMas.Location = new System.Drawing.Point(449, 164);
            this.bSegMas.Name = "bSegMas";
            this.bSegMas.Size = new System.Drawing.Size(42, 23);
            this.bSegMas.TabIndex = 14;
            this.bSegMas.Text = ">";
            this.bSegMas.UseVisualStyleBackColor = false;
            this.bSegMas.Click += new System.EventHandler(this.bSegMas_Click);
            // 
            // bSegMenos
            // 
            this.bSegMenos.BackColor = System.Drawing.Color.Black;
            this.bSegMenos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bSegMenos.FlatAppearance.BorderSize = 0;
            this.bSegMenos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.bSegMenos.ForeColor = System.Drawing.Color.White;
            this.bSegMenos.Location = new System.Drawing.Point(348, 164);
            this.bSegMenos.Name = "bSegMenos";
            this.bSegMenos.Size = new System.Drawing.Size(42, 23);
            this.bSegMenos.TabIndex = 13;
            this.bSegMenos.Text = "<";
            this.bSegMenos.UseVisualStyleBackColor = false;
            this.bSegMenos.Click += new System.EventHandler(this.bSegMenos_Click);
            // 
            // cbSeg
            // 
            this.cbSeg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSeg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbSeg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSeg.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.cbSeg.ForeColor = System.Drawing.Color.White;
            this.cbSeg.FormatString = "N0";
            this.cbSeg.FormattingEnabled = true;
            this.cbSeg.Location = new System.Drawing.Point(394, 164);
            this.cbSeg.Name = "cbSeg";
            this.cbSeg.Size = new System.Drawing.Size(50, 23);
            this.cbSeg.TabIndex = 12;
            // 
            // lSeg
            // 
            this.lSeg.AutoSize = true;
            this.lSeg.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.lSeg.ForeColor = System.Drawing.Color.White;
            this.lSeg.Location = new System.Drawing.Point(345, 136);
            this.lSeg.Name = "lSeg";
            this.lSeg.Size = new System.Drawing.Size(71, 15);
            this.lSeg.TabIndex = 11;
            this.lSeg.Text = "Segundos";
            // 
            // lenCero
            // 
            this.lenCero.AutoSize = true;
            this.lenCero.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.lenCero.ForeColor = System.Drawing.Color.White;
            this.lenCero.Location = new System.Drawing.Point(15, 223);
            this.lenCero.Name = "lenCero";
            this.lenCero.Size = new System.Drawing.Size(59, 15);
            this.lenCero.TabIndex = 15;
            this.lenCero.Text = "En Cero";
            this.lenCero.Click += new System.EventHandler(this.label2_Click);
            // 
            // rbReiniciar
            // 
            this.rbReiniciar.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.rbReiniciar.AutoSize = true;
            this.rbReiniciar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.rbReiniciar.ForeColor = System.Drawing.Color.White;
            this.rbReiniciar.Location = new System.Drawing.Point(177, 255);
            this.rbReiniciar.Name = "rbReiniciar";
            this.rbReiniciar.Size = new System.Drawing.Size(175, 19);
            this.rbReiniciar.TabIndex = 17;
            this.rbReiniciar.TabStop = true;
            this.rbReiniciar.Text = "Reiniciar temporizador";
            this.rbReiniciar.UseVisualStyleBackColor = true;
            this.rbReiniciar.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbParar
            // 
            this.rbParar.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.rbParar.AutoSize = true;
            this.rbParar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.rbParar.ForeColor = System.Drawing.Color.White;
            this.rbParar.Location = new System.Drawing.Point(18, 255);
            this.rbParar.Name = "rbParar";
            this.rbParar.Size = new System.Drawing.Size(153, 19);
            this.rbParar.TabIndex = 16;
            this.rbParar.TabStop = true;
            this.rbParar.Text = "Parar temporizador";
            this.rbParar.UseVisualStyleBackColor = true;
            this.rbParar.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbCrono
            // 
            this.rbCrono.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.rbCrono.AutoSize = true;
            this.rbCrono.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.rbCrono.ForeColor = System.Drawing.Color.White;
            this.rbCrono.Location = new System.Drawing.Point(18, 295);
            this.rbCrono.Name = "rbCrono";
            this.rbCrono.Size = new System.Drawing.Size(274, 19);
            this.rbCrono.TabIndex = 18;
            this.rbCrono.TabStop = true;
            this.rbCrono.Text = "Iniciar como cronómetro (incremento)";
            this.rbCrono.UseVisualStyleBackColor = true;
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
            this.cbSonido.Location = new System.Drawing.Point(18, 363);
            this.cbSonido.Name = "cbSonido";
            this.cbSonido.Size = new System.Drawing.Size(133, 23);
            this.cbSonido.TabIndex = 20;
            // 
            // lSonido
            // 
            this.lSonido.AutoSize = true;
            this.lSonido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.lSonido.ForeColor = System.Drawing.Color.White;
            this.lSonido.Location = new System.Drawing.Point(15, 334);
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
            this.bIniciar.Location = new System.Drawing.Point(158, 363);
            this.bIniciar.Name = "bIniciar";
            this.bIniciar.Size = new System.Drawing.Size(42, 23);
            this.bIniciar.TabIndex = 21;
            this.bIniciar.Text = "->";
            this.bIniciar.UseVisualStyleBackColor = false;
            // 
            // bPuntos
            // 
            this.bPuntos.BackColor = System.Drawing.Color.Black;
            this.bPuntos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bPuntos.FlatAppearance.BorderSize = 0;
            this.bPuntos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.bPuntos.ForeColor = System.Drawing.Color.White;
            this.bPuntos.Location = new System.Drawing.Point(205, 362);
            this.bPuntos.Name = "bPuntos";
            this.bPuntos.Size = new System.Drawing.Size(42, 23);
            this.bPuntos.TabIndex = 22;
            this.bPuntos.Text = "...";
            this.bPuntos.UseVisualStyleBackColor = false;
            // 
            // cbRepetir
            // 
            this.cbRepetir.AutoSize = true;
            this.cbRepetir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.cbRepetir.ForeColor = System.Drawing.Color.White;
            this.cbRepetir.Location = new System.Drawing.Point(284, 366);
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
            this.lTitulo.Location = new System.Drawing.Point(15, 404);
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
            this.tbTitulo.Location = new System.Drawing.Point(17, 432);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(230, 23);
            this.tbTitulo.TabIndex = 25;
            // 
            // cbMensaje
            // 
            this.cbMensaje.AutoSize = true;
            this.cbMensaje.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.cbMensaje.ForeColor = System.Drawing.Color.White;
            this.cbMensaje.Location = new System.Drawing.Point(18, 474);
            this.cbMensaje.Name = "cbMensaje";
            this.cbMensaje.Size = new System.Drawing.Size(107, 19);
            this.cbMensaje.TabIndex = 26;
            this.cbMensaje.Text = "Ver mensaje";
            this.cbMensaje.UseVisualStyleBackColor = true;
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
            this.bIniciar2.Location = new System.Drawing.Point(404, 509);
            this.bIniciar2.Name = "bIniciar2";
            this.bIniciar2.Size = new System.Drawing.Size(87, 40);
            this.bIniciar2.TabIndex = 27;
            this.bIniciar2.Text = "Iniciar";
            this.bIniciar2.TextColor = System.Drawing.Color.White;
            this.bIniciar2.UseVisualStyleBackColor = false;
            this.bIniciar2.Click += new System.EventHandler(this.bIniciar2_Click);
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
            this.bCancelar.Location = new System.Drawing.Point(311, 509);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(87, 40);
            this.bCancelar.TabIndex = 28;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.TextColor = System.Drawing.Color.White;
            this.bCancelar.UseVisualStyleBackColor = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
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
            this.bProbar.Location = new System.Drawing.Point(18, 509);
            this.bProbar.Name = "bProbar";
            this.bProbar.Size = new System.Drawing.Size(87, 40);
            this.bProbar.TabIndex = 29;
            this.bProbar.Text = "Probar";
            this.bProbar.TextColor = System.Drawing.Color.White;
            this.bProbar.UseVisualStyleBackColor = false;
            this.bProbar.Click += new System.EventHandler(this.bProbar_Click);
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.rbCuentaAtrasT);
            this.gb1.Controls.Add(this.rbCuentaFechaT);
            this.gb1.Controls.Add(this.groupBox2);
            this.gb1.Controls.Add(this.groupBox1);
            this.gb1.ForeColor = System.Drawing.SystemColors.Control;
            this.gb1.Location = new System.Drawing.Point(18, 77);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(473, 45);
            this.gb1.TabIndex = 30;
            this.gb1.TabStop = false;
            // 
            // rbCuentaAtrasT
            // 
            this.rbCuentaAtrasT.AutoSize = true;
            this.rbCuentaAtrasT.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.rbCuentaAtrasT.ForeColor = System.Drawing.Color.White;
            this.rbCuentaAtrasT.Location = new System.Drawing.Point(1, 17);
            this.rbCuentaAtrasT.Name = "rbCuentaAtrasT";
            this.rbCuentaAtrasT.Size = new System.Drawing.Size(110, 19);
            this.rbCuentaAtrasT.TabIndex = 34;
            this.rbCuentaAtrasT.TabStop = true;
            this.rbCuentaAtrasT.Text = "Cuenta Atrás";
            this.rbCuentaAtrasT.UseVisualStyleBackColor = true;
            // 
            // rbCuentaFechaT
            // 
            this.rbCuentaFechaT.AutoSize = true;
            this.rbCuentaFechaT.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.rbCuentaFechaT.ForeColor = System.Drawing.Color.White;
            this.rbCuentaFechaT.Location = new System.Drawing.Point(159, 17);
            this.rbCuentaFechaT.Name = "rbCuentaFechaT";
            this.rbCuentaFechaT.Size = new System.Drawing.Size(258, 19);
            this.rbCuentaFechaT.TabIndex = 33;
            this.rbCuentaFechaT.TabStop = true;
            this.rbCuentaFechaT.Text = "Contar hasta (desde) fecha y tiempo";
            this.rbCuentaFechaT.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(0, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 73);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(1, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 59);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(1, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 59);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(517, 561);
            this.Controls.Add(this.bProbar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bIniciar2);
            this.Controls.Add(this.cbMensaje);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.lTitulo);
            this.Controls.Add(this.cbRepetir);
            this.Controls.Add(this.bPuntos);
            this.Controls.Add(this.bIniciar);
            this.Controls.Add(this.cbSonido);
            this.Controls.Add(this.lSonido);
            this.Controls.Add(this.rbCrono);
            this.Controls.Add(this.rbReiniciar);
            this.Controls.Add(this.rbParar);
            this.Controls.Add(this.lenCero);
            this.Controls.Add(this.bSegMas);
            this.Controls.Add(this.bSegMenos);
            this.Controls.Add(this.cbSeg);
            this.Controls.Add(this.lSeg);
            this.Controls.Add(this.bMinMas);
            this.Controls.Add(this.bMinMenos);
            this.Controls.Add(this.cbMin);
            this.Controls.Add(this.lMin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bHorasMenos);
            this.Controls.Add(this.cbHoras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lTituloForm);
            this.Controls.Add(this.gb1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTituloForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbHoras;
        private System.Windows.Forms.Button bHorasMenos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bMinMas;
        private System.Windows.Forms.Button bMinMenos;
        private System.Windows.Forms.ComboBox cbMin;
        private System.Windows.Forms.Label lMin;
        private System.Windows.Forms.Button bSegMas;
        private System.Windows.Forms.Button bSegMenos;
        private System.Windows.Forms.ComboBox cbSeg;
        private System.Windows.Forms.Label lSeg;
        private System.Windows.Forms.Label lenCero;
        private System.Windows.Forms.RadioButton rbReiniciar;
        private System.Windows.Forms.RadioButton rbParar;
        private System.Windows.Forms.RadioButton rbCrono;
        private System.Windows.Forms.ComboBox cbSonido;
        private System.Windows.Forms.Label lSonido;
        private System.Windows.Forms.Button bIniciar;
        private System.Windows.Forms.Button bPuntos;
        private System.Windows.Forms.CheckBox cbRepetir;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.CheckBox cbMensaje;
        private CustomControls.RJControls.bIniciar bIniciar2;
        private CustomControls.RJControls.bReiniciar bCancelar;
        private CustomControls.RJControls.bEditar bProbar;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCuentaFechaT;
        private System.Windows.Forms.RadioButton rbCuentaAtrasT;
    }
}