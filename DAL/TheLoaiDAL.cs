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
    public class TheLoaiDAL
    {
        public static DataTable getAlltt()
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("proc_selectAllTheLoai", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static void insert_theloai(String theLoai)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand cmd = new SqlCommand("proc_AddTheLoai", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@tentheloai", SqlDbType.NVarChar, 20).Value = theLoai;
            Conn.Open();
            cmd.ExecuteNonQuery();
            Conn.Close();
        }

        public static void update_theloai(tbtheLoai theLoai)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand cmd = new SqlCommand("proc_updateTheLoai", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@matheloai", SqlDbType.Int).Value = theLoai.The_loai_id;
            cmd.Parameters.Add("@tentheloai", SqlDbType.NVarChar, 20).Value = theLoai.The_loai_name;
            Conn.Open();
            cmd.ExecuteNonQuery();
            Conn.Close();
        }

        public static void delete_theloai(tbtheLoai theLoai)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand cmd = new SqlCommand("proc_DeleteTheLoai", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maloaisach", SqlDbType.Int).Value = theLoai.The_loai_id;
            Conn.Open();
            cmd.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
