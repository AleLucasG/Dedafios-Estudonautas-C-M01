﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnOk_Click(object sender, EventArgs e)
        {

            await Task.Delay(1000);
            label1.BackColor = Color.Blue;
            label1.ForeColor = Color.White;
            label1.Visible = true;

            await Task.Delay(1000);
            label2.BackColor = Color.Yellow;
            label2.ForeColor = Color.Green;
            label2.Visible = true;

            await Task.Delay(1000);
            label3.BackColor = Color.Green;
            label3.ForeColor = Color.Yellow;
            label3.Visible = true;
        }
    }
}
