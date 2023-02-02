﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using RadioButton = System.Windows.Forms.RadioButton;

namespace Temporizador
{
    public partial class Form2 : Form
    {
        int cbHorasPointer = 0;
        int cbMinPointer = 0;
        int cbSegPointer = 0;


        public Form2()
        {
            InitializeComponent();
            this.cbHoras.Items.AddRange(new object[] {1,
                        2,
                        3,
                        4,
                        5});
            cbHoras.TabIndex = cbHorasPointer;
            cbHoras.Text = cbHorasPointer+"";
            this.cbMin.Items.AddRange(new object[] {1,
                        2,
                        3,
                        4,
                        5});
            cbMin.TabIndex = cbMinPointer;
            cbMin.Text = cbMinPointer + "";
            this.cbSeg.Items.AddRange(new object[] {1,
                        2,
                        3,
                        4,
                        5});
            cbSeg.TabIndex = cbSegPointer;
            cbSeg.Text = cbSegPointer + "";

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void lTitulo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbHoras.TabIndex = ++cbHorasPointer;
            cbHoras.Text = cbHorasPointer + "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bHorasMenos_Click(object sender, EventArgs e)
        {
            cbHoras.TabIndex = --cbHorasPointer;
            cbHoras.Text = cbHorasPointer + "";

        }

        private void bMinMenos_Click(object sender, EventArgs e)
        {
            cbMin.TabIndex = --cbMinPointer;
            cbMin.Text = cbMinPointer + "";
        }

        private void bMinMas_Click(object sender, EventArgs e)
        {
            cbMin.TabIndex = ++cbMinPointer;
            cbMin.Text = cbMinPointer + "";
        }

        private void bSegMas_Click(object sender, EventArgs e)
        {
            cbSeg.TabIndex = ++cbSegPointer;
            cbSeg.Text = cbSegPointer + "";
        }

        private void bSegMenos_Click(object sender, EventArgs e)
        {
            cbSeg.TabIndex = --cbSegPointer;
            cbSeg.Text = cbSegPointer + "";
        }
        private int pasaraSeg(Int32 horas, Int32 min, Int32 seg)
        {
            Int32 horasSeg = horas * 3600;
            Int32 minSeg = min * 60;
            return horasSeg + minSeg+ seg;
        }
        private void bIniciar2_Click(object sender, EventArgs e)
        {
            //int prueba = Convert.ToInt32(cbHoras.SelectedValue.ToString());
            int pasaraseg = pasaraSeg(cbHoras.SelectedIndex == -1 ? 0 : cbHoras.SelectedIndex+1,
                                              cbMin.SelectedIndex == -1 ? 0 : cbMin.SelectedIndex+1,
                                              cbSeg.SelectedIndex == -1 ? 0 : cbSeg.SelectedIndex + 1);
            //lTituloForm.Text += ""+cbHoras;

            Form1 form1 = new Form1(pasaraseg, opcionesRadioButton(), tbTitulo.Text);
            form1.Show();
            this.Hide();
        }
        private int opcionesRadioButton()
        {
            int opcion = 0;//Parar
            if(rbReiniciar.Checked)
            {
                opcion = 1;
            }
            if (rbCrono.Checked)
            {
                opcion = 2;
            }
            return opcion;
        }

        private void cbHoras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbCuentaFecha_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void bProbar_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(tbTitulo.Text, pasaraSeg(cbHoras.SelectedIndex == -1 ? 0 : cbHoras.SelectedIndex + 1,
                                              cbMin.SelectedIndex == -1 ? 0 : cbMin.SelectedIndex + 1,
                                              cbSeg.SelectedIndex == -1 ? 0 : cbSeg.SelectedIndex + 1));
            form3.Show();
        }
    }
}
