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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exercício1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmex1 fm = new frmex1();
            fm.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exercícío2AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmwhile fm = new frmwhile();
            fm.Show();
        }

        private void exercíToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exercício2BToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmfor fm = new frmfor();
            fm.Show();
        }

        private void exercício2CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmdowhile fm = new frmdowhile();
            fm.Show();
        }
    }
}
