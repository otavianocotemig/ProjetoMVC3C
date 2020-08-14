using ProjetoMVC3C.BLL;
using ProjetoMVC3C.DTO;
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
        // Instanciar as classes de BLL e DTO
        tblClienteBLL bllCliente = new tblClienteBLL();
        tblClienteDTO dtoCliente = new tblClienteDTO();

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
            // Pesquisando os dados do cliente logado e preenchendo os campos do formulário
            DataTable dtResult = bllCliente.ListarClientes(frmLogin.email_usuario_logado);
            txtCodigoCliente.Text = dtResult.Rows[0]["id_cliente"].ToString();
            txtNome.Text = dtResult.Rows[0]["nome_cliente"].ToString();
            txtSobrenome.Text = dtResult.Rows[0]["sobrenome_cliente"].ToString();
            txtEmail.Text = frmLogin.email_usuario_logado;
            txtCpf.Text = dtResult.Rows[0]["cpf_cliente"].ToString();

        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            try
            {
                // Atualizando os dados doDTo com os campos do formulário

                dtoCliente.Nome_cliente = txtNome.Text;
                dtoCliente.Sobrenome_cliente = txtSobrenome.Text;
                dtoCliente.Cpf_cliente = txtCpf.Text;
                dtoCliente.Email_cliente = txtEmail.Text;
                dtoCliente.Senha_cliente = txtNovaSenha.Text;

                string Erro = "OK";
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
                    bllCliente.AlterarCliente(dtoCliente);
                    MessageBox.Show("Senha Alterada com Sucesso. ", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
