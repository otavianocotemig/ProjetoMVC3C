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

    }
}
