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
    public partial class frmdowhile : Form
    {
        public frmdowhile()
        {
            InitializeComponent();
        }

        private void lblresult_Click(object sender, EventArgs e)
        {

        }

        private void lblnum_Click(object sender, EventArgs e)
        {

        }

        private void txtresultado_TextChanged(object sender, EventArgs e)
        {

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
            i = 1;

            do
            {
                resultado = numero * i;
                txtresultado.Text = String.Concat(txtresultado.Text, "\r\n", resultado.ToString());
                i++;
            } while (i <= 10);
        }
    }
}
