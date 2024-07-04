using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaiKhoanDAL
    {
        private SqlConnection conn = SqlConnectionData.Connect();

        public bool ValidateUser(string username, string password)
        {
            using (conn)
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("proc_account", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count == 1;
                }
            }
        }
    }
}
