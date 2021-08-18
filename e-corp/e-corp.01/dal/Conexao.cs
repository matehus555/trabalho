using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_corp._01.dal
{
   public class Conexao
    {
        SqlConnection con = new SqlConnection();
       
        public Conexao()
        {
            con.ConnectionString = @"Data Source=DESKTOP-QHTGJV3\SQLEXPRESS;Initial Catalog=E-corp0.1;Integrated Security=True";

        }
        public SqlConnection conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
