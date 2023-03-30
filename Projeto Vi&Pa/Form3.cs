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
    public partial class frmfor : Form
    {
        public frmfor()
        {
            InitializeComponent();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txtresultado.Clear();

            txtnum.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int i, numero, resultado;
            numero = Convert.ToInt32(txtnum.Text);


            for (i = 1; i <= 10; i++)
            {
                resultado = numero * i;

                txtresultado.Text = String.Concat(txtresultado.Text, "\r\n", resultado.ToString());
            }
        }
    }
}
