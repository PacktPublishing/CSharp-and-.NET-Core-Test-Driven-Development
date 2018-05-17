using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bad_Code
{
    public class DbQuery
    {

        private SqlConnection conn;
        private SqlCommand com;

        public DbQuery()
        {
            conn = new SqlConnection();
            conn.ConnectionString = ""; //set connection string here
            com = new SqlCommand();
        }
        public void updatetableloginentries()
        {
            com.Connection = conn;
            SqlParameter par1 = new SqlParameter();
            par1.ParameterName = "@username";
            par1.Value = main.username;
            com.Parameters.Add(par1);
            SqlParameter par2 = new SqlParameter();
            par2.ParameterName = "@date";
            par2.Value = main.date;
            com.Parameters.Add(par2);
            SqlParameter par3 = new SqlParameter();
            par3.ParameterName = "@logintime";
            par3.Value = main.logintime;
            com.Parameters.Add(par3);
            SqlParameter par4 = new SqlParameter();
            par4.ParameterName = "@logouttime";
            par4.Value = DateTime.Now.ToShortTimeString(); ;
            com.Parameters.Add(par4);
            com.CommandType = CommandType.Text;
            com.CommandText = "update loginentries set logouttime=@logouttime where username=@username and date=@date and logintime=@logintime";
            openconn();
            com.ExecuteNonQuery();
            closeconn();
        }

        private void openconn()
        {
            conn.Open();
        }

        private void closeconn()
        {
            conn.Close();
        }
    }

    public class main
    {
        public static string username = "";
        public static string date = "";
        public static string logintime = "";
    }
}
