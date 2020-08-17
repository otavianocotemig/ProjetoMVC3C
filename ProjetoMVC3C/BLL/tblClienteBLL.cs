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
    class tblClienteBLL
    {
        private DALMysql DaoBanco = new DALMysql();

        public Boolean Autenticar(string email, string senha)
        {
            // criação da string para conexão.
           string consulta = string.Format($@"select * from tbl_cliente where email_cliente = '{email}' and senha_cliente = '{senha}';");
           DataTable dt = DaoBanco.executarConsulta(consulta);
           if (dt.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        // Metodo para recuperacao de senha do usuário
        public string RecuperaSenha(string email)
        {
            string consulta = string.Format($@"select * from tbl_cliente where email_cliente = '{email}';");
            DataTable dt = DaoBanco.executarConsulta(consulta);
            if (dt.Rows.Count == 1)
            {
                return dt.Rows[0]["senha_cliente"].ToString();
            }
            else
            {
                return "Senha não Localizada.";
            }

        }

        // Metodo para recuperacao do tipo do usuário
        public string VerificarTipoUsuario(string email)
        {
            string consulta = string.Format($@"select * from tbl_cliente where email_cliente = '{email}';");
            DataTable dt = DaoBanco.executarConsulta(consulta);
            if (dt.Rows.Count == 1)
            {
                return dt.Rows[0]["tp_usuario"].ToString();
            }
            else
            {
                return "Tipo Usuario não localizado";
            }
        }
        // Metodo criado para alterar senha do usuário
        public void AlterarSenha(string email, string senha)
        {
            string sql = string.Format($@"UPDATE TBL_CLIENTE SET senha_cliente = '{senha}' where email_cliente = '{email}';");
            DaoBanco.executarComando(sql);

        }
        // Metodo para Listar dados do clientes pelo email
        public DataTable ListarClientes(string email)
        {
            string sql = string.Format($@"select * from tbl_cliente where email_cliente = '{email}';");
            return DaoBanco.executarConsulta(sql);
        }
        // Metodo para Listar todos os clientes do Banco de Dados
        public DataTable ListarClientes()
        {
            string sql = string.Format($@"select * from tbl_cliente");
            return DaoBanco.executarConsulta(sql);
        }


        //Metodo utilizado para alterar os dados do cliente
        public void AlterarCliente(tblClienteDTO dtocliente)
        {
            string sql = string.Format($@"UPDATE tbl_cliente set nome_cliente = '{dtocliente.Nome_cliente}',
                                                               sobrenome_cliente = '{dtocliente.Sobrenome_cliente}',
                                                               cpf_cliente = '{dtocliente.Cpf_cliente}',
                                                               senha_cliente = '{dtocliente.Senha_cliente}'
                                                 where email_cliente = '{dtocliente.Email_cliente}';");
            DaoBanco.executarComando(sql);                                                                    

        }   
        // Metodo utilizado para Inserir dados do Cliente no Banco de Dados
        public void InserirCliente(tblClienteDTO ObjCliente)
        {
            string sql = string.Format($@"INSERT INTO tbl_cliente VALUES (NULL,'{ObjCliente.Nome_cliente}',
                                                                          '{ObjCliente.Sobrenome_cliente}',
                                                                          '{ObjCliente.Email_cliente}',
                                                                          '{ObjCliente.Senha_cliente}',
                                                                          '{ObjCliente.Cpf_cliente}',
                                                                           '{ObjCliente.Tpusuario}');");
            DaoBanco.executarComando(sql);


        }


    }
}
