using ProjetoMVC3C.DAL;
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
    }
}
