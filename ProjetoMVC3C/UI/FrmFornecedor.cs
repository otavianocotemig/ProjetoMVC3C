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
    public partial class FrmFornecedor : Form
    {
        // Instanciação do DTO e BLL
        tblFornecedorBLL FornecedorBLL = new tblFornecedorBLL();
        tblFornecedorDTO FornecedorDTO = new tblFornecedorDTO();


        public FrmFornecedor()
        {
            InitializeComponent();
        }

        private void FrmFornecedor_Load(object sender, EventArgs e)
        {
            GridFornecedores.DataSource = FornecedorBLL.ListarFornecedores();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                FornecedorDTO.Nome = txtNome.Text;
                FornecedorDTO.Email = txtEmail.Text;
                FornecedorDTO.Telefone = txtTelefone.Text;
                //
                FornecedorBLL.IncluirFornecedor(FornecedorDTO);
                new LimpaForm(this);
                GridFornecedores.DataSource = FornecedorBLL.ListarFornecedores();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = GridFornecedores.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = GridFornecedores.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEmail.Text = GridFornecedores.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTelefone.Text = GridFornecedores.Rows[e.RowIndex].Cells[3].Value.ToString();
            //
            this.btnNovo.Enabled = false;
            this.btnEditar.Enabled = true;
            this.btnExcluir.Enabled = true;

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridFornecedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                FornecedorDTO.Id = int.Parse(txtCodigo.Text);
                FornecedorDTO.Nome = txtNome.Text;
                FornecedorDTO.Email = txtEmail.Text;
                FornecedorDTO.Telefone = txtTelefone.Text;
                //
                FornecedorBLL.AlterarFornecedor(FornecedorDTO);
                new LimpaForm(this);
                GridFornecedores.DataSource = FornecedorBLL.ListarFornecedores();
                this.btnNovo.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnExcluir.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Está ação irá deletar o registro selecionado e não poderá ser desfeito, deseja continuar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    FornecedorDTO.Id = Convert.ToInt32(txtCodigo.Text);
                    FornecedorBLL.ExcluirFornecedor(FornecedorDTO);
                    GridFornecedores.DataSource = FornecedorBLL.ListarFornecedores();
                    new LimpaForm(this);
                    this.btnNovo.Enabled = true;
                    this.btnEditar.Enabled = false;
                    this.btnExcluir.Enabled = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string condicao = "nome like '%" + txtPesquisaFornecedores.Text + "%'" +
                         " or email like '%" + txtPesquisaFornecedores.Text + "%'";

            GridFornecedores.DataSource = FornecedorBLL.ListarFornecedores(condicao);
       }
    }
}
