using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class NgonNguDAL
    {
        public static DataTable getAllNN()
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("proc_selectAllNgonNgu", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static void insert_ngonngu(String ngonNgu)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand cmd = new SqlCommand("proc_AddNgonNgu", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@tenngonngu", SqlDbType.NVarChar, 20).Value = ngonNgu;
            Conn.Open();
            cmd.ExecuteNonQuery();
            Conn.Close();
        }

        public static void update_ngonngu(tbNgonNgu ngonNgu)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand cmd = new SqlCommand("proc_updateNgonNgu", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mangonngu", SqlDbType.Int).Value = ngonNgu.Ngon_ngu_id;
            cmd.Parameters.Add("@tenngonngu", SqlDbType.NVarChar, 20).Value = ngonNgu.Ngon_ngu_name;
            Conn.Open();
            cmd.ExecuteNonQuery();
            Conn.Close();
        }

        public static void delete_ngonngu(tbNgonNgu ngonNgu)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand cmd = new SqlCommand("proc_DeleteNgonNgu", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mangonngu", SqlDbType.Int).Value = ngonNgu.Ngon_ngu_id;
            Conn.Open();
            cmd.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
