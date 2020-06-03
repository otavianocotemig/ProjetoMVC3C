using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMVC3C.DAL
{
    class DALMysql
    {
        private MySqlConnection conexao;
        private string string_conexao = "Persist security info = false; " +
                                        "server = localhost; " +
                                        "database = dbmvc; " +
                                        "user = root ; pwd=;";
        public void conectar()
        {
            conexao = new MySqlConnection(string_conexao);
            conexao.Open();
        }



    }
}
