using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoMVC3C.BLL;
using ProjetoMVC3C.DTO;

namespace ProjetoMVC3C.UI
{
    public partial class FrmCategorias : Form
    {
        tblCategoriaBLL bllCategoria = new tblCategoriaBLL();
        tblCategoriaDTO dtoCategoria = new tblCategoriaDTO();

        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {

            string condicao = "descricao like '%" + txt_Pesquisar.Text + "%'";
            DataTable dt = bllCategoria.PesquisarCategoria(condicao);
            if (dt.Rows.Count >= 1)
            {
                dgv_Categoria.DataSource = dt;
            }
            else 
            {
                MessageBox.Show("Nenhuma Categoria encontrada!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                dgv_Categoria.DataSource = bllCategoria.ListarCategoria();
                //Firulas do Design
                txt_Pesquisar.Clear();
                txt_Pesquisar.Focus();
            }
            

        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
                dgv_Categoria.DataSource = bllCategoria.ListarCategoria();

        }
    }
}
