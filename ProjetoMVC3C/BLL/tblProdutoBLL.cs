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
    class tblProdutoBLL
    {
        // Fazer a conexão com o Banco através da DAL
        DALMysql daoBanco = new DALMysql();

        // Metodos do CRUD 
        public void InserirProdutos(tblProdutoDTO dtoproduto)
        {
            string sql = string.Format($@"INSERT INTO tbl_produto VALUES (NULL,'{dtoproduto.NomeProduto}',
                                                                          '{dtoproduto.Descricao}',
                                                                          '{dtoproduto.Preco}',
                                                                          '{dtoproduto.Quantidade}',
                                                                          '{dtoproduto.Peso}',
                                                                           '{dtoproduto.Tbl_categoria_id}',
                                                                           '{dtoproduto.Tbl_fornecedor_id}');");
            daoBanco.executarComando(sql);
            
        }
        // Metodo Utilizado para Listar Produtos
        public DataTable ListarProdutos()
        {
            string sql = string.Format($@"select * from tbl_produto");
            return daoBanco.executarConsulta(sql);
        }

    }
}
