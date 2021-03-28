﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void start_lbl_MouseEnter(object sender, EventArgs e)
        {
            start_lbl.Font = new Font("Snap ITC", 72);
        }

        private void start_lbl_MouseLeave(object sender, EventArgs e)
        {
            start_lbl.Font = new Font("Snap ITC", 48);
        }

        private void exit_lbl_MouseEnter(object sender, EventArgs e)
        {
            exit_lbl.Font = new Font("Snap ITC", 72);
        }

        private void exit_lbl_MouseLeave(object sender, EventArgs e)
        {
            exit_lbl.Font = new Font("Snap ITC", 48);
        }

        private void exit_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void start_lbl_Click(object sender, EventArgs e)
        {
            Joc joc = new Joc();
            this.Hide();
            joc.Closed += (s, args) => this.Close();
            joc.Show();
        }
    }
}
