using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMVC3C.DTO
{
    class tblClienteDTO
    {
        private int id_cliente, tpusuario;
        private string nome_cliente, sobrenome_cliente, email_cliente, senha_cliente, cpf_cliente;

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Tpusuario { get => tpusuario; set => tpusuario = value; }
        public string Nome_cliente { get => nome_cliente; set => nome_cliente = value; }
        public string Sobrenome_cliente { get => sobrenome_cliente; set => sobrenome_cliente = value; }
        public string Cpf_cliente { get => cpf_cliente; set => cpf_cliente = value; }

        // utilizando o DTo para realizar a validação de campos
        public string Email_cliente { 
        
            set
            {
                if (value != string.Empty)
                {
                    this.email_cliente = value;
                }
                else
                {
                    throw new Exception("O campo Email é obrigatório.");
                }
            }
            get { return this.email_cliente; }
            

        }
     
    public string Senha_cliente
    {

        set
        {
            if (value != string.Empty)
            {
                this.senha_cliente = value;
            }
            else
            {
                throw new Exception("O campo Senha é obrigatório.");
            }
        }
        get { return this.senha_cliente; }


    }


}

     
}
