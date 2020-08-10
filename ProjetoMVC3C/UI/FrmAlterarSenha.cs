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
    public partial class FrmAlterarSenha : Form
    {
        public FrmAlterarSenha()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAlterarSenha_Load(object sender, EventArgs e)
        {
            txtEmail.Text = frmLogin.email_usuario_logado;
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            string Erro = "OK";
            tblClienteBLL bllCliente = new tblClienteBLL();
            if (txtSenhaAtual.Text.ToString() != bllCliente.RecuperaSenha(txtEmail.Text.ToString()))
            {
                MessageBox.Show("A senha atual não confere. Verifique", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Erro = "NOTOK";
            }

            if (txtNovaSenha.Text.ToString() != txtRNovaSenha.Text.ToString())
            {
                MessageBox.Show("A nova senha digitada não são iguais. Verifique", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Erro = "NOTOK";
            }
            if (Erro == "OK")
            {
                bllCliente.AlterarSenha(txtEmail.Text.ToString(), txtNovaSenha.Text.ToString());
                MessageBox.Show("Senha Alterada com Sucesso. ", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

    }
}
