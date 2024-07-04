using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SearchBookDAL
    {
        public static DataTable SearchBooks(string title)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("proc_TimKiem", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@tensach", SqlDbType.NVarChar).Value = title;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
    }
}
