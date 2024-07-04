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
    public class DocGiaDAL
    {
        public static DataTable getallData()
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("proc_docGia", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }

        public static void insertDocGia(tbDocGia dg)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand cmd = new SqlCommand("proc_InsertDocGia", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaDocGia", SqlDbType.Int).Value = dg.MaDG;
            cmd.Parameters.Add("@TenDocGia", SqlDbType.NVarChar, 100).Value = dg.TenDG;
            cmd.Parameters.Add("@NamSinh", SqlDbType.Date).Value = dg.Namsinh;
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 100).Value = dg.Diachi;
            cmd.Parameters.Add("@SoDienThoai", SqlDbType.VarChar).Value = dg.Sdt;
            cmd.Parameters.Add("@SoCMT", SqlDbType.VarChar, 50).Value = dg.Cmt;
            cmd.Parameters.Add("@HanThe", SqlDbType.VarChar, 20).Value = dg.Hanthe;
            Conn.Open();
            cmd.ExecuteNonQuery();
            Conn.Close();
        }

        public static void updateDocGia(tbDocGia dg)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand cmd = new SqlCommand("proc_UpdateDocGia", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaDocGia", SqlDbType.Int).Value = dg.MaDG;
            cmd.Parameters.Add("@TenDocGia", SqlDbType.NVarChar, 100).Value = dg.TenDG;
            cmd.Parameters.Add("@NamSinh", SqlDbType.Date).Value = dg.Namsinh;
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 100).Value = dg.Diachi;
            cmd.Parameters.Add("@SoDienThoai", SqlDbType.VarChar).Value = dg.Sdt;
            cmd.Parameters.Add("@SoCMT", SqlDbType.VarChar, 50).Value = dg.Cmt;
            cmd.Parameters.Add("@HanThe", SqlDbType.VarChar, 20).Value = dg.Hanthe;
            Conn.Open();
            cmd.ExecuteNonQuery();
            Conn.Close();
        }

        public static void deleteDocGia(tbDocGia dg)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand cmd = new SqlCommand("proc_DeleteDocGia", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaDocGia", SqlDbType.Int).Value = dg.MaDG;
            Conn.Open();
            cmd.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
