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

        }
    }
}
