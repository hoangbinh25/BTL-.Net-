using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tbMuonTra
    {
        private int phieu_muon_id;
        private int doc_gia_id;
        private DateTime ngay_muon;
        private DateTime ngay_hen_tra;

        public tbMuonTra(int phieu_muon_id, int doc_gia_id, DateTime ngay_muon, DateTime ngay_hen_tra)
        {
            this.Phieu_muon_id = phieu_muon_id;
            this.Doc_gia_id = doc_gia_id;
            this.Ngay_muon = ngay_muon;
            this.Ngay_hen_tra = ngay_hen_tra;
        }

        public int Phieu_muon_id { get => phieu_muon_id; set => phieu_muon_id = value; }
        public int Doc_gia_id { get => doc_gia_id; set => doc_gia_id = value; }
        public DateTime Ngay_muon { get => ngay_muon; set => ngay_muon = value; }
        public DateTime Ngay_hen_tra { get => ngay_hen_tra; set => ngay_hen_tra = value; }
    }

    public class tbChiTietMuonTra
    {
        private int phieu_muon_id;
        private int sach_id;
        private int so_luong;

        public tbChiTietMuonTra(int phieu_muon_id, int sach_id, int so_luong)
        {
            this.Phieu_muon_id = phieu_muon_id;
            this.Sach_id = sach_id;
            this.So_luong = so_luong;
        }

        public int Phieu_muon_id { get => phieu_muon_id; set => phieu_muon_id = value; }
        public int Sach_id { get => sach_id; set => sach_id = value; }
        public int So_luong { get => so_luong; set => so_luong = value; }
    }
}
