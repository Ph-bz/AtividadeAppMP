using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAppMP
{
    public partial class frmfunc : Form
    {
        public frmfunc()
        {
            InitializeComponent();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double idade, sl, st, acr;
            string nome, gen;
            nome = txtnome.Text;
            gen = txtgen.Text;
            idade = Convert.ToDouble(txtidade.Text);
            sl = Convert.ToDouble(txtsal.Text);
            st = Convert.ToDouble(txtsal.Text);
            if (gen =="M" & idade >= 30) {
                acr = 100;
                st = sl + acr;
            }
            else if (gen == "M" & idade < 30) {
                acr = 50;
                st = sl + acr;
            }
            else if (gen == "F" & idade >= 30) {
                acr = 250;
                st = sl + acr;
            }
            else if (gen == "F" & idade > 30) {
                acr = 150;
                st = sl + acr;
            }
            txtnomeresult.Text = Convert.ToString(nome);
            txtsalresult.Text = Convert.ToString(st);
        }

        private void lblgen_Click(object sender, EventArgs e)
        {

        }

        private void frmfunc_Load(object sender, EventArgs e)
        {

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtnome.Clear();
            txtsal.Clear();
            txtgen.Clear();
            txtidade.Clear();
            txtnomeresult.Clear();
            txtsalresult.Clear();
            txtnome.Focus();
        }

        private void btnvolt_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }
    }
}
