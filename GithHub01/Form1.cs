﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GithHub01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cislo1 = int.Parse(textBox1.Text);
            int cislo2 = int.Parse(textBox2.Text);

            MessageBox.Show("Součet je " + (cislo1 + cislo2));
            MessageBox.Show("Rozdíl je " + (cislo1 - cislo2));
            MessageBox.Show("Součin je " + (cislo1 * cislo2));
            MessageBox.Show("Podíl je " + (cislo1 / cislo2));
        }
    }
}
