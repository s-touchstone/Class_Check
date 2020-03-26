using System;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Chk_Lnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Checklist CL = new Checklist();
            CL.ShowDialog();
            this.Close();
        }

        private void Inv_Lnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Inventory IN = new Inventory();
            IN.ShowDialog();
            this.Close();
        }

        private void Mod_Lnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Inventory IN = new Inventory();
            IN.ShowDialog();
            this.Close();
        }

        private void Rpt_Lnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Report RP = new Report();
            RP.ShowDialog();
            this.Close();
        }

        private void Set_Lnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Settings ST = new Settings();
            ST.ShowDialog();
            this.Close();
        }
    }
}
