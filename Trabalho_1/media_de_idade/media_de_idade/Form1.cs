using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace media_de_idade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcule_Click(object sender, EventArgs e)
        {
            int total_dias;
            int total_horas;

            total_dias = Convert.ToInt32(txtIdade.Text) * 365;
            lblResultado_vida_dias.Text = total_dias.ToString();
            total_horas = (Convert.ToInt32(txtIdade.Text) * 365) * 24;
            lblResultado_vida_horas.Text = total_horas.ToString();
        }
    }
}
