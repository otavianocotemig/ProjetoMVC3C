using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMVC3C.DTO
{
    class tblCategoriaDTO
    {
        private int idCategoria;
        private string descricao;

        public int IdCategoria { get => idCategoria; set => idCategoria = value; }

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
                    throw new Exception("O campo Descrição é obrigatório.");
                }
            }
            get { return this.descricao; }
        }
    }
}
