using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblSach
    {
        private int sach_id;
        private String ten_sach;
        private String tac_gia;
        private String loai_sach;
        private String ngon_ngu;
        private DateTime ngay_nhap;
        private String gia_bia;
        private String nha_xb;
        private int soluong;

        public tblSach(int sach_id, string ten_sach, string tac_gia, string loai_sach, string ngon_ngu, DateTime ngay_nhap, string gia_bia, string nha_xb, int soluong)
        {
            this.sach_id = sach_id;
            this.ten_sach = ten_sach;
            this.tac_gia = tac_gia;
            this.loai_sach = loai_sach;
            this.ngon_ngu = ngon_ngu;
            this.ngay_nhap = ngay_nhap;
            this.gia_bia = gia_bia;
            this.nha_xb = nha_xb;
            this.soluong = soluong;
        }

        public int Sach_id { get => sach_id; set => sach_id = value; }
        public string Ten_sach { get => ten_sach; set => ten_sach = value; }
        public string Tac_gia { get => tac_gia; set => tac_gia = value; }
        public string Loai_sach { get => loai_sach; set => loai_sach = value; }
        public string Ngon_ngu { get => ngon_ngu; set => ngon_ngu = value; }
        public DateTime Ngay_nhap { get => ngay_nhap; set => ngay_nhap = value; }
        public string Gia_bia { get => gia_bia; set => gia_bia = value; }
        public string Nha_xb { get => nha_xb; set => nha_xb = value; }
        public int Soluong { get => soluong; set => soluong = value; }
    }
}
