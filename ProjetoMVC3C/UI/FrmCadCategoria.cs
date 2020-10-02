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
    public partial class FrmCadCategoria : Form
    {
        tblCategoriaBLL categoriaBLL = new tblCategoriaBLL();
        tblCategoriaDTO categoriaDTO = new tblCategoriaDTO();

        public FrmCadCategoria()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                categoriaDTO.Descricao = txtDescricao.Text;
                categoriaBLL.IncluirCategoria(categoriaDTO);
                MessageBox.Show("Categoria Cadastrada com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
