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
    public partial class frmlanche : Form
    {
        public frmlanche()
        {
            InitializeComponent();
        }

        private void lbltrpbrg_Click(object sender, EventArgs e)
        {

        }

        private void frmlanche_Load(object sender, EventArgs e)
        {

        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double cod, x;
            string erro;
            erro = "Insira um código válido";
            
            cod = Convert.ToDouble(txtcod.Text);
            if (cod == 100)
            {
                x = 25;
                txtresult.Text = Convert.ToString(x);
            }
            else if (cod == 101)
            {
                x = 15;
                txtresult.Text = Convert.ToString(x);
            }
            else if (cod == 102)
            {
                x = 35;
                txtresult.Text = Convert.ToString(x);
            }
            else if (cod == 103)
            {
                x = 47;
                txtresult.Text = Convert.ToString(x);
            }
            else if (cod < 100 || cod > 103)
            {
                txtresult.Text = erro;     
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtcod.Clear();
            txtresult.Clear();
            txtcod.Focus();
        }

        private void btnvolt_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }
    }
}
