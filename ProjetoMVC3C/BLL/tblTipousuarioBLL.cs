using ProjetoMVC3C.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMVC3C.BLL
{
    class tblTipousuarioBLL
    {
        // Conexão com o banco de dados - DAL - Data Acess Layer
        private DALMysql daoBanco = new DALMysql();

        public DataTable ListarTipoUsuario()
        {
            string sql = string.Format($@"select * from tbl_tipousuario");
            return daoBanco.executarConsulta(sql);
        }


    }
}
