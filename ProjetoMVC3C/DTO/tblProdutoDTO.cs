using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMVC3C.DTO
{
    class tblProdutoDTO
    {
        private int id, tbl_categoria_id, tbl_fornecedor_id, quantidade;
        private double peso, preco;
        private string nomeProduto, descricao,foto;

        public int Id { get => id; set => id = value; }
        public int Tbl_categoria_id { get => tbl_categoria_id; set => tbl_categoria_id = value; }
        public int Tbl_fornecedor_id { get => tbl_fornecedor_id; set => tbl_fornecedor_id = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Preco { get => preco; set => preco = value; }
        public string NomeProduto { get => nomeProduto; set => nomeProduto = value; }
        public string Foto { get => foto; set => foto = value; }

        public int Quantidade
        {
            set
            {
                if (value != 0)
                {
                    this.quantidade = value;
                }
                else
                {
                    throw new Exception("O campo Quantidade do Produto é obrigatório.");
                }

            }
            get { return this.quantidade; }
        }

        public string Descricao
        {
            set
            {
                if (value != string.Empty)
                {
                    this.descricao = value;
                }
                else
                {
                    throw new Exception("O campo Descrição do Produto é obrigatório.");
                }

            }
            get { return this.descricao; }
        }



    }
}
