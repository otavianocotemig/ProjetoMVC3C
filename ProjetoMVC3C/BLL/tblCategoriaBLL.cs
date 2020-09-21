using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProjetoMVC3C.DAL;
using ProjetoMVC3C.DTO;

namespace ProjetoMVC3C.BLL
{
    class tblCategoriaBLL
    {
        private DALMysql DaoBanco = new DALMysql();

        public DataTable ListarCategoria()
        {
            string sql = string.Format($@"select * from tbl_categoria");
            return DaoBanco.executarConsulta(sql);
            //Remover a varíável foi idéia do Yuri.
        }

        public DataTable PesquisarCategoria(string condicao)
        {
            string sql = string.Format($@"select * from tbl_categoria where " + condicao);
            return DaoBanco.executarConsulta(sql);
        }

    }
}
