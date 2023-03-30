using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Vi_Pa
{
    public partial class frmwhile : Form
    {
        public frmwhile()
        {
            InitializeComponent();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnumero.Clear();
            txtresultado.Clear();

            txtnumero.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
        }

     
        private void btncalc_Click(object sender, EventArgs e)
        {
            int i, numero, resultado;
            numero = Convert.ToInt32(txtnumero.Text);

            i = 1;

            while (i <= 10)
            {
                resultado = numero * i;

                txtresultado.Text = String.Concat(txtresultado.Text, "\r\n", resultado.ToString());
                i++;
            }
        }
    }
}
