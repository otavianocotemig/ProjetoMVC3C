﻿using ProjetoMVC3C.BLL;
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
    public partial class FrmCliente : Form
    {

        // Instanciar as classes de BLL e DTO
        tblClienteBLL bllCliente = new tblClienteBLL();
        tblClienteDTO dtoCliente = new tblClienteDTO();

        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            GridClientes.DataSource = bllCliente.ListarClientes();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                // Passagem dos dados da UI para o DTO
                dtoCliente.Nome_cliente = txtNome.Text.ToString();
                dtoCliente.Sobrenome_cliente = txtSobrenome.Text.ToString();
                dtoCliente.Email_cliente = txtEmail.Text.ToString();
                dtoCliente.Senha_cliente = txtSenha.Text.ToString();
                dtoCliente.Cpf_cliente = txtCpf.Text.ToString();
              

                bllCliente.InserirCliente(dtoCliente);
                MessageBox.Show("Cliente inserido com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridClientes.DataSource = bllCliente.ListarClientes();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void GridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtCodigo.Text = GridClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = GridClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSobrenome.Text = GridClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEmail.Text = GridClientes.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSenha.Text = GridClientes.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtCpf.Text = GridClientes.Rows[e.RowIndex].Cells[5].Value.ToString();
            // Habilitar o botao Excluir
            this.btnExcluir.Enabled = true;


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                  if (MessageBox.Show("Está ação irá deletar o registro selecionado e não poderá ser desfeito, deseja continuar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                  {
                    dtoCliente.Id_cliente = Convert.ToInt32(txtCodigo.Text);
                    bllCliente.ExcluirCliente(dtoCliente);
                    GridClientes.DataSource = bllCliente.ListarClientes();
                  }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
