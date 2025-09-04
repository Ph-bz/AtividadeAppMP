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
            int ttl1, ttl2, ttl3, x, totalpub, tipoing;
            tipoing = Convert.ToInt32(txting.Text);
            totalpub = Convert.ToInt32(txtqtdp.Text);
            if (tipoing == 1)
            {
                x = totalpub * 50 / 100;
                ttl1 = x * 10;
                txtresult.Text = ttl1.ToString();
            }
            else if (tipoing == 2) {
                x = totalpub * 10/ 100;
            }
        }
    }
}
