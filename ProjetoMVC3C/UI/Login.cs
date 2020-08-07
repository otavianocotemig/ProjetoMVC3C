using ProjetoMVC3C.BLL;
using ProjetoMVC3C.DTO;
using ProjetoMVC3C.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMVC3C
{
    public partial class frmLogin : Form
    {
        // Armazenar o email do usuario logado
        public static string email_usuario_logado;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            try
            {
                //Instanciando o DTO do cliente para armazenar os dados da tela
                tblClienteDTO cliente = new tblClienteDTO();
                cliente.Email_cliente = txtEmail.Text.Trim();
                cliente.Senha_cliente = txtSenha.Text.Trim();
                // Instanciando a BLL para pesquisa do email e senha do cliente no banco
                tblClienteBLL bllCliente = new tblClienteBLL();
                if (bllCliente.Autenticar(cliente.Email_cliente, cliente.Senha_cliente))
                {
                    MessageBox.Show("Seja bemVindo", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Armazenou o valor da variavel global estática para uso no sistema.
                    email_usuario_logado = cliente.Email_cliente;

                    this.Hide();
                    FrmMain FrmPrincipal = new FrmMain();
                    FrmPrincipal.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cliente não Localizado", "Falhou!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void lblEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {

                tblClienteDTO clienteDTO = new tblClienteDTO();
                clienteDTO.Email_cliente = txtEmail.Text;
                tblClienteBLL bllCliente = new tblClienteBLL();
                MessageBox.Show("Senha : "+bllCliente.RecuperaSenha(txtEmail.Text.Trim()), "Senha!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Text = bllCliente.RecuperaSenha(txtEmail.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
