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
    public class MuonTraDAL
    {
        public static DataTable get_all_phieuMuon()
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("proc_loads_phieuMuon", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }

        public static DataTable get_all_doc_gia()
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

        public static DataTable get_all_chiTietPhieuMuon(String ma)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("proc_loads_chiTietPhieuMuon", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@phieu_muon_id", SqlDbType.Int).Value = int.Parse(ma);
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static void insert_phieuMuon(tbMuonTra muontra)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand cmd = new SqlCommand("proc_insert_phieuMuon", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@doc_gia_id", SqlDbType.Int).Value = muontra.Doc_gia_id;
            cmd.Parameters.Add("@ngay_muon", SqlDbType.Date).Value = muontra.Ngay_muon;
            cmd.Parameters.Add("@ngay_hen_tra", SqlDbType.Date).Value = muontra.Ngay_hen_tra;
            Conn.Open();
            cmd.ExecuteNonQuery();
            Conn.Close();
        }

        public static void edit_phieuMuon(tbMuonTra muontra)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand cmd = new SqlCommand("proc_editPhieuMuon", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@phieu_muon_id", SqlDbType.Int).Value = muontra.Phieu_muon_id;
            cmd.Parameters.Add("@doc_gia_id", SqlDbType.Int).Value = muontra.Doc_gia_id;
            cmd.Parameters.Add("@ngay_muon", SqlDbType.Date).Value = muontra.Ngay_muon;
            cmd.Parameters.Add("@ngay_hen_tra", SqlDbType.Date).Value = muontra.Ngay_hen_tra;
            Conn.Open();
            cmd.ExecuteNonQuery();
            Conn.Close();
        }

        public static void delete_phieuMuon(tbMuonTra muontra)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand cmd = new SqlCommand("proc_DeletePM", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@phieu_muon_id", SqlDbType.Int).Value = muontra.Phieu_muon_id;
            Conn.Open();
            cmd.ExecuteNonQuery();
            Conn.Close();
        }

        public static void insert_chiTietPM(tbChiTietMuonTra chiTietPM)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand cmd = new SqlCommand("proc_themChiTietPM", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sach_id", SqlDbType.Int).Value = chiTietPM.Sach_id;
            cmd.Parameters.Add("@phieu_muon_id", SqlDbType.Int).Value = chiTietPM.Phieu_muon_id;
            cmd.Parameters.Add("@so_luong", SqlDbType.Int).Value = chiTietPM.So_luong;
            Conn.Open();
            cmd.ExecuteNonQuery();
            Conn.Close();
        }

        public static void delete_chiTietPM(int idPM, int id_Sach)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand cmd = new SqlCommand("proc_deleteChiTietPM", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sach_id", SqlDbType.Int).Value = id_Sach;
            cmd.Parameters.Add("@phieu_muon_id", SqlDbType.Int).Value = idPM;
            Conn.Open();
            cmd.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
