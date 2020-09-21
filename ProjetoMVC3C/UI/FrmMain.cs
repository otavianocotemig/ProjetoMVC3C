using ProjetoMVC3C.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMVC3C.UI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblEmailUsuarioLogado.Text = frmLogin.email_usuario_logado;
            tblClienteBLL bllcliente = new tblClienteBLL();
            if (bllcliente.VerificarTipoUsuario(frmLogin.email_usuario_logado) == "2")
            {
                this.administraçãoToolStripMenuItem.Visible = false;
            }

        }

        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlterarSenha FrmAlterarSenha = new FrmAlterarSenha();
            FrmAlterarSenha.ShowDialog();
        }

        private void manutençãoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente FrmCliente = new FrmCliente();
            FrmCliente.ShowDialog();
        }

        private void manutençãoDeFonecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFornecedor FrmFornecedor = new FrmFornecedor();
            FrmFornecedor.ShowDialog();
        }

        private void manutençãoDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProduto FrmProduto = new FrmProduto();
            FrmProduto.ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategorias FrmCategorias = new FrmCategorias();
            FrmCategorias.ShowDialog();
        }
    }
}
