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
    public partial class frmimc : Form
    {
        public frmimc()
        {
            InitializeComponent();
        }

        private void frmimc_Load(object sender, EventArgs e)
        {

        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double al, pe, imc;
            al = Convert.ToDouble(txtalt.Text);
            pe = Convert.ToDouble(txtpeso.Text);
            imc = pe / (al * al);
            if (imc < 17)
            {
                txtimc.Text = "Você possui magreza severa";
            }
            else if (imc >= 17 && imc < 18.5)
            {
                txtimc.Text = "Você possui magreza leve";
            }
            else if (imc >= 18.5 && imc < 25)
            {
                txtimc.Text = "Você possui seu peso normal";
            }
            else if (imc >= 25 &&  imc < 30)
            {
                txtimc.Text = "Você possui sobrepeso";
            }
            else if (imc >= 30 && imc < 35)
            {
                txtimc.Text = "Você possui obesidade classe I";
            }
            else if (imc >= 35 && imc < 40)
            {
                txtimc.Text = "Você possui obesidade classe II";
            }
            else if (imc >= 40)
            {
                txtimc.Text = "Você possui obesidade classe III";
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtalt.Clear();
            txtpeso.Clear();
            txtimc.Clear();
            txtalt.Focus();
        }

        private void btnvolt_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }
    }
}
