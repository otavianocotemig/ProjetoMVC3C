using ProjetoMVC3C.DAL;
using ProjetoMVC3C.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMVC3C.BLL
{
    class tblFornecedorBLL
    {
        // integração da BLL com a DAL
        DALMysql DaoBanco = new DALMysql();

        // Metodos do CRUD
        // Listar Fornecedores
        public DataTable ListarFornecedores()
        {
              string sql = string.Format($@"select * from tbl_fornecedor");
              return DaoBanco.executarConsulta(sql);
        }
        // Incluir Fornecedores
        public void IncluirFornecedor(tblFornecedorDTO dtoFornecedor)
        {
            string sql = string.Format($@"INSERT INTO tbl_fornecedor VALUES (NULL,'{dtoFornecedor.Nome}',
                                                                               '{dtoFornecedor.Email}',
                                                                                '{dtoFornecedor.Telefone}');");
            DaoBanco.executarComando(sql);

        }



    }
}
