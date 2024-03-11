using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjLocadora
{
    public partial class frmProdutoras : Form
    {
        String connectionString = @"Server=DARNASSUS\MOTORHEAD; Database=db_230058; User Id=230058; Password=Ra1542687;";
        bool novo;

        public frmProdutoras()
        {
            InitializeComponent();
        }

        private void frmProdutoras_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            TxtProdutora.Enabled = true;
            TxtEmail.Enabled = true;
            TxtTelefoneProdutora.Enabled = true;
            btnExcluir.Enabled = false;
            btnPrimeiro.Enabled = false;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnUltimo.Enabled = false;
            btnAlterar.Enabled = false;
            novo = true;
            TxtProdutora.Focus();



        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (novo)
            {
                string sql = "INSERT INTO tb_produtor (nomeProd, telprod, emailProd)"
                    + "VALUES('" + TxtProdutora.Text + "', '" + TxtTelefoneProdutora.Text + "', '" + TxtEmail.Text + "')";
                MessageBox.Show(sql);
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if(i>0)
                    {
                        MessageBox.Show("Produtora cadastrada com sucesso");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
