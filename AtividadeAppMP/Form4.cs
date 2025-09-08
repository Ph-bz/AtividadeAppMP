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
            int ttl1, ttl2, ttl3, ttl, x, totalpub, tipoing;
            tipoing = Convert.ToInt32(txting.Text);
            totalpub = Convert.ToInt32(txtqtdp.Text);
            if (tipoing == 1)
            {
                x = totalpub * 50 / 100;
                ttl1 = x * 10;
                txtresult.Text = ttl1.ToString();
            }
            else if (tipoing == 2)
            {
                x = totalpub * 10 / 100;
                ttl2 = x * 30;
                txtresult.Text = ttl2.ToString();
            }
            else if (tipoing == 3)
            {
                x = totalpub * 30 / 100;
                ttl3 = x * 20;
                txtresult.Text = Convert.ToString(ttl3);
            }
            else if (tipoing == 4) 
            {
                x = totalpub * 10 / 100;
                ttl2 = x * 30;
                txtresult.Text = Convert.ToString(ttl2);
            }

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
    }
}
