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

        public FrmProduto()
        {
            InitializeComponent();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            GridProdutos.DataSource = bllProduto.ListarProdutos();
        }
    }
}
