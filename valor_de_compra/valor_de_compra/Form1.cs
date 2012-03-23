using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace valor_de_compra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            decimal calculo;


            calculo = Convert.ToDecimal(txtValor_compra.Text) - (Convert.ToDecimal(txtValor_compra.Text) * Convert.ToDecimal(txtValor_desconto.Text)) / 100;
            lblTotal.Text = calculo.ToString();
        }
    }
}
