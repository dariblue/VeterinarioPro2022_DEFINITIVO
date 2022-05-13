﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinarioPro2022
{
    public partial class inicio_cliente : Form
    {

        protected override void OnFormClosing(FormClosingEventArgs e)
        {   //codigo para que al cerrar el form se cierre la aplicacion
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            Application.Exit();
        }

        public inicio_cliente()
        {
            InitializeComponent();
            oculta_primerapag();
        }
        
        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {

        }
        public void oculta_primerapag()
        {
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label12.Hide();
            button10.Hide();
            button13.Hide();
            button11.Hide();
            button12.Hide();
            button9.Hide();
        }
        public void oculta_segundapag()
        {
            button3.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label12.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button8.Hide();

        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            pictureBox5.Show();
            pictureBox6.Show();
            pictureBox7.Show();
            pictureBox8.Show();
            label7.Show();
            label8.Show();
            label9.Show();
            label10.Show();
            label12.Show();
            button9.Show();
            button10.Show();
            button13.Show();
            button11.Show();
            button12.Show();
            oculta_segundapag();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            button3.Show();
            pictureBox1.Show();
            pictureBox2.Show();
            pictureBox3.Show();
            pictureBox4.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            button9.Hide();
            label11.Show();
            button4.Show();
            button5.Show();
            button6.Show();
            button8.Show();
            oculta_primerapag();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            button4.Text = "Comprado";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "Comprado";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = "Comprado";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = "Comprado";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Text = "Comprado";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Text = "Comprado";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Text = "Comprado";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Text = "Comprado";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            datos_animal da = new datos_animal();
            da.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pedir_cita pc = new pedir_cita();
            pc.Show();
            Hide();
        }

    }
}
