using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golden_Ed_shop.Controller
{
    internal class Connection
    {
    
        private SqlConnection con;
        private string Database = "PR2CJ3021998GOLDENED";
        private string Server = "sqlexpress";
        private string Username = "aluno";
        private string Password = "aluno";
        public Connection() {
            string stringconnection =
            @"Data Source = " + Server
                + "; Initial Catalog = " + Database
                + "; User Id = " + Username
                + "; Password = " + Password
                + "; Encrypt = false";

            con = new SqlConnection(stringconnection);
            con.Open();
        }
        public void CloseConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }
        public SqlConnection ReturnConnection()
        {
            return con;
        }
    }
    
}
