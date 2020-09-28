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
                                                                           '{dtoproduto.Tbl_fornecedor_id}',
                                                                           '{dtoproduto.Foto}');");

       

            daoBanco.executarComando(sql);
            
        }
        // Metodo Utilizado para Listar Produtos
        public DataTable ListarProdutos()
        {
            string sql = string.Format($@"select * from tbl_produto");
            return daoBanco.executarConsulta(sql);
        }
        // Metodo para Excluir Produtos
        public void ExcluirProduto(tblProdutoDTO objProduto)
        {
            string sql = string.Format($@"DELETE FROM tbl_produto where id = {objProduto.Id};");
            daoBanco.executarComando(sql);
        }
        // Metodo Para Alterar
        public void AlterarProduto(tblProdutoDTO dtoProduto)
        {
            string sql = string.Format($@"UPDATE tbl_produto set nomeProduto = '{dtoProduto.NomeProduto}',
                                                               descricao =   '{dtoProduto.Descricao}',
                                                               preco  = '{dtoProduto.Preco}',
                                                               Quantidade =  '{dtoProduto.Quantidade}',
                                                               peso =  '{dtoProduto.Peso}',
                                                               tbl_categoria_id =  '{dtoProduto.Tbl_categoria_id}',
                                                               tbl_fornecedor_id =  '{dtoProduto.Tbl_fornecedor_id}'
                                                 where id  = '{dtoProduto.Id}';");
            daoBanco.executarComando(sql);

        }

    }
}
