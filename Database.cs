using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace REDNA_BANK
{
    class Database
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        SqlDataReader dreader;

        public Database()
        {
            con = new SqlConnection("Data Source=rednabank.database.windows.net;Initial Catalog=RednaBank_DB;Persist Security Info=True;User ID=lakshan;Password=Redna@12");
        }
        public SqlCommand command(string command)
        {
            con.Open();
            cmd = new SqlCommand(command);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            return cmd;
        }
        public SqlDataAdapter Adapter(string command)
        {
            con.Open();
            adpt = new SqlDataAdapter(command, con);
            con.Close();
            return adpt;
        }
        public SqlDataReader dataReader(string command)
        {
            con.Open();
            cmd = new SqlCommand(command, con);
            SqlDataReader da = cmd.ExecuteReader();
            con.Close();
            cmd.Dispose();
            return da;  
        }
        public String dataScalar(string command)
        {
            con.Open();
            cmd = new SqlCommand(command, con);
            var data = cmd.ExecuteScalar() as String; 
            con.Close();
            cmd.Dispose();
            return data;
        }
    }
}
