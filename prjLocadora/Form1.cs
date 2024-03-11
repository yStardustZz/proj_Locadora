using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjLocadora
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void produtorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProdutoras produtoras = new frmProdutoras();
            produtoras.MdiParent = this;
            produtoras.Show();
        }

        private void filmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFilmes produtoras = new frmFilmes();
            produtoras.MdiParent = this;
            produtoras.Show();
        }
    }
}
