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
    public partial class frmlivros : Form
    {
        public frmlivros()
        {
            InitializeComponent();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double ul, cl, sl;
            ul = Convert.ToDouble(txtlivro.Text);
            cl = ul * 8;
            sl = ul * 12;
            if (ul > 10)
            {
                txtresult.Text = Convert.ToString(cl);
            }
            else
            {
                txtresult.Text = Convert.ToString(sl);
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtlivro.Clear();
            txtresult.Clear();
            txtlivro.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }
    }
}
