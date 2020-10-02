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
    public partial class FrmProduto : Form
    {
        //instanciar Blls e DTO
        tblProdutoBLL bllProduto = new tblProdutoBLL();
        tblProdutoDTO dtoProduto = new tblProdutoDTO();
        tblCategoriaBLL bllCategoria = new tblCategoriaBLL();
        tblFornecedorBLL bllFornecedor = new tblFornecedorBLL();

        public FrmProduto()
        {
            InitializeComponent();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            GridProdutos.DataSource = bllProduto.ListarProdutos();
            PreencheCategoria();
            PreencheFornecedor();
        }

        public void PreencheCategoria()
        {
            cmbCategoria.DataSource = bllCategoria.ListarCategoria();
            // Indicar o campo que o usuario verá no combo
            cmbCategoria.DisplayMember = "descricao";
            //Indicar o campo que será gravado no banco
            cmbCategoria.ValueMember = "id";
        }
        public void PreencheFornecedor()
        {
            cmbFornecedor.DataSource = bllFornecedor.ListarFornecedores();
            // Indicar o campo que o usuario verá no combo
            cmbFornecedor.DisplayMember = "nome";
            //Indicar o campo que será gravado no banco
            cmbFornecedor.ValueMember = "id";
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {

                dtoProduto.NomeProduto = txtNome.Text.ToString();
                dtoProduto.Descricao = txtDescricao.Text.ToString();
                dtoProduto.Peso = double.Parse(txtPeso.Text.ToString());
                dtoProduto.Quantidade = int.Parse(txtQuantidade.Text.ToString());
                dtoProduto.Preco = double.Parse(txtPreco.Text.ToString());
                dtoProduto.Tbl_categoria_id = int.Parse(cmbCategoria.SelectedValue.ToString());
                dtoProduto.Tbl_fornecedor_id = int.Parse(cmbFornecedor.SelectedValue.ToString());
                dtoProduto.Foto = "Sem Foto";
                //
                bllProduto.InserirProdutos(dtoProduto);
                GridProdutos.DataSource = bllProduto.ListarProdutos();
                // Limpar os Campos
                new LimpaForm(this);



            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void GridProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = GridProdutos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = GridProdutos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDescricao.Text = GridProdutos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPreco.Text = GridProdutos.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtQuantidade.Text = GridProdutos.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtPeso.Text = GridProdutos.Rows[e.RowIndex].Cells[5].Value.ToString();
            cmbCategoria.SelectedValue = GridProdutos.Rows[e.RowIndex].Cells[6].Value.ToString();
            cmbFornecedor.SelectedValue = GridProdutos.Rows[e.RowIndex].Cells[7].Value.ToString();

            // Desabilitar e Habilitar os botoes
            btnNovo.Enabled = false;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Está ação irá deletar o registro selecionado e não poderá ser desfeito, deseja continuar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    dtoProduto.Id = int.Parse(txtCodigo.Text.ToString());
                    bllProduto.ExcluirProduto(dtoProduto);
                    GridProdutos.DataSource = bllProduto.ListarProdutos();
                    // Limpar os Campos
                    new LimpaForm(this);
                    // Desabilitar e Habilitar os botoes
                    btnNovo.Enabled = true;
                    btnEditar.Enabled = false;
                    btnExcluir.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {

                dtoProduto.NomeProduto = txtNome.Text.ToString();
                dtoProduto.Descricao = txtDescricao.Text.ToString();
                dtoProduto.Peso = double.Parse(txtPeso.Text.ToString());
                dtoProduto.Quantidade = int.Parse(txtQuantidade.Text.ToString());
                dtoProduto.Preco = double.Parse(txtPreco.Text.ToString());
                dtoProduto.Tbl_categoria_id = int.Parse(cmbCategoria.SelectedValue.ToString());
                dtoProduto.Tbl_fornecedor_id = int.Parse(cmbFornecedor.SelectedValue.ToString());
                dtoProduto.Id = int.Parse(txtCodigo.Text.ToString());

                //
                bllProduto.AlterarProduto(dtoProduto);
                GridProdutos.DataSource = bllProduto.ListarProdutos();
                // Limpar os Campos
                new LimpaForm(this);

                // Desabilitar e Habilitar os botoes
                btnNovo.Enabled = true;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCadCategoria FrmCadCategoria = new FrmCadCategoria();
            FrmCadCategoria.ShowDialog();
            this.PreencheCategoria();
        }
    }
}
