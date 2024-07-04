using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class MuonTraBUS
    {
        public static DataTable ds_PhieuMuon()
        {
            return MuonTraDAL.get_all_phieuMuon();
        }

        public static DataTable ds_ChiTietPhieuMuon(String ma)
        {
            return MuonTraDAL.get_all_chiTietPhieuMuon(ma);
        }
        public static DataTable ds_sach()
        {
            return BookDAL.select_all_sach();
        }

        public static DataTable ds_doc_gia()
        {
            return MuonTraDAL.get_all_doc_gia();
        }

        public static void them_pm(tbMuonTra mt)
        {
            MuonTraDAL.insert_phieuMuon(mt);
        }
        public static void sua_pm(tbMuonTra mt)
        {
            MuonTraDAL.edit_phieuMuon(mt);
        }
        public static void xoa_pm(tbMuonTra mt)
        {
            MuonTraDAL.delete_phieuMuon(mt);
        }
        public static void them_ChiTietPM(tbChiTietMuonTra chiTietPM)
        {
            MuonTraDAL.insert_chiTietPM(chiTietPM);
        }
        public static void xoa_ChiTietPM(int idPM, int id_Sach)
        {
            MuonTraDAL.delete_chiTietPM(idPM, id_Sach);
        }
    }
}
