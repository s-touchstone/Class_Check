﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Check
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Hom_Lnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Main MN = new Main();
            MN.ShowDialog();
            this.Close();
        }
    }
}
