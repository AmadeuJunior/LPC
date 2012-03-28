using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LPC_Trabalho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mspNovo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vai Abrir o Form NOVO");
            Novo F = new Novo();
             F.Show();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlterar Fmeu = new FrmAlterar();
            Fmeu.Show();
        }

        private void cauculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void navegadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Chrome");
        }
    }
}
