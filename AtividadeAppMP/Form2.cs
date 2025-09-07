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
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void tsmiexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmilivro_Click(object sender, EventArgs e)
        {
            Hide();
            frmlivros livros = new frmlivros();
            livros.Show();

        }

        private void tsmifunc_Click(object sender, EventArgs e)
        {
            Hide();
            frmfunc func = new frmfunc();
            func.Show();
        }

        private void tsmiestadio_Click(object sender, EventArgs e)
        {
            Hide();
            frmestadio estadio = new frmestadio();
            estadio.Show();
        }
    }
}
