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

        public DataTable ListarFornecedores(string condicao)
        {
            string sql = string.Format($@"select * from tbl_fornecedor where " + condicao);
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
        // Metodo para Alterar o fornecedor
        public void AlterarFornecedor(tblFornecedorDTO dtoFornecedor)
        {
            string sql = string.Format($@"UPDATE tbl_Fornecedor set nome = '{dtoFornecedor.Nome}',
                                                                email = '{dtoFornecedor.Email}',
                                                                telefone = '{dtoFornecedor.Telefone}'
                                                 where id  = '{dtoFornecedor.Id}';");
            DaoBanco.executarComando(sql);

        }
        //Metodo para Excluir Fornecedor
        public void ExcluirFornecedor(tblFornecedorDTO dtoFornecedor)
        {
            string sql = string.Format($@"DELETE FROM tbl_fornecedor where id = {dtoFornecedor.Id};");
            DaoBanco.executarComando(sql);
        }


    }
}
