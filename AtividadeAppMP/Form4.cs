using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAppMP
{
    public partial class frmestadio : Form
    {
        public frmestadio()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double totp, pop, ger, arq, cad, rdp = 0, rdg = 0, rda = 0, rdc = 0, totr;
            totp = Convert.ToDouble(txtqtdp.Text);
            pop = totp * 0.1;
            ger = totp * 0.5;
            arq = totp * 0.3;
            cad = totp * 0.1;
            if (pop > 0)
                rdp = pop * 5;
            if (ger > 0)
                rdg = ger * 10;
            if (arq > 0)
                rda = arq * 20;
            if (cad > 0)
                rdc = cad * 30;

            totr = rdp + rdg + rda + rdc;
            txting.Text = totr.ToString();

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txting.Clear();
            txtresult.Clear();
            txtqtdp.Clear();
            txting.Focus();
        }

        private void btnvolt_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }

        private void frmestadio_Load(object sender, EventArgs e)
        {

        }
    }
}
