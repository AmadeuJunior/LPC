using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Instrucoes_Condicionais
{
    public partial class FrmTabuada : Form
    {
        public FrmTabuada()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            /**MessageBox.Show("testando botão mostrar", "Ops! Mostrou", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Exclamation);
             */
            

         
            int resultado = 0;

            int numero = Convert.ToInt32(txtNumero.Text);
            listResultado.Items.Clear();

            for (int i = 1; i < 10; i++)
            {
                resultado = i * numero;
                listResultado.Items.Add(i + "x" + numero + "=" + resultado);

               

            }
        }
    }
}
