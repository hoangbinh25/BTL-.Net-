using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BookDAL
    {
        public BookDAL() { }

        public static DataTable select_all_theLoai()
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("proc_loads_the_loai", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }

        public static DataTable select_all_ngon_ngu()
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("proc_loads_ngon_ngu", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }

        public static DataTable select_all_sach()
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("proc_loads_sach", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }

        public static void insert_sach(tblSach sach)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand cmd = new SqlCommand("proc_insert_sach", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sach_id", SqlDbType.Int).Value = sach.Sach_id;
            cmd.Parameters.Add("@loai_sach_id", SqlDbType.Int).Value = sach.Loai_sach;
            cmd.Parameters.Add("@nha_xb", SqlDbType.NVarChar, 100).Value = sach.Nha_xb;
            cmd.Parameters.Add("@ngon_ngu_id", SqlDbType.Int).Value = sach.Ngon_ngu;
            cmd.Parameters.Add("@ten_sach", SqlDbType.NVarChar, 100).Value = sach.Ten_sach;
            cmd.Parameters.Add("@tac_gia", SqlDbType.NVarChar, 100).Value = sach.Tac_gia;
            cmd.Parameters.Add("@so_luong", SqlDbType.Int).Value = sach.Soluong;
            cmd.Parameters.Add("@ngay_nhap", SqlDbType.Date).Value = sach.Ngay_nhap;
            cmd.Parameters.Add("@gia_bia", SqlDbType.Float).Value = sach.Gia_bia;
            Conn.Open();
            cmd.ExecuteNonQuery();
            Conn.Close();
        }

        public static void edit_sach(tblSach sach)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand cmd = new SqlCommand("proc_edit_sach", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sach_id", SqlDbType.Int).Value = sach.Sach_id;
            cmd.Parameters.Add("@loai_sach_id", SqlDbType.Int).Value = sach.Loai_sach;
            cmd.Parameters.Add("@nha_xb", SqlDbType.NVarChar, 100).Value = sach.Nha_xb;
            cmd.Parameters.Add("@ngon_ngu_id", SqlDbType.Int).Value = sach.Ngon_ngu;
            cmd.Parameters.Add("@ten_sach", SqlDbType.NVarChar, 100).Value = sach.Ten_sach;
            cmd.Parameters.Add("@tac_gia", SqlDbType.NVarChar, 100).Value = sach.Tac_gia;
            cmd.Parameters.Add("@so_luong", SqlDbType.Int).Value = sach.Soluong;
            cmd.Parameters.Add("@ngay_nhap", SqlDbType.Date).Value = sach.Ngay_nhap;
            cmd.Parameters.Add("@gia_bia", SqlDbType.Float).Value = sach.Gia_bia;
            Conn.Open();
            cmd.ExecuteNonQuery();
            Conn.Close();
        }
        public static void delete_sach(tblSach sach)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand cmd = new SqlCommand("proc_delete_sach", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sach_id", SqlDbType.Int).Value = sach.Sach_id;
            Conn.Open();
            cmd.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
