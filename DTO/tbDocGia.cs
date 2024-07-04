using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tbDocGia
    {
        private int maDG;
        private string tenDG;
        private DateTime namsinh;
        private string diachi;
        private string sdt;
        private string cmt;
        private string hanthe;

        public tbDocGia(int maDG, string tenDG, DateTime namsinh, string diachi, string sdt, string cmt, string hanthe)
        {
            this.maDG = maDG;
            this.tenDG = tenDG;
            this.namsinh = namsinh;
            this.diachi = diachi;
            this.sdt = sdt;
            this.cmt = cmt;
            this.hanthe = hanthe;
        }

        public int MaDG { get => maDG; set => maDG = value; }
        public string TenDG { get => tenDG; set => tenDG = value; }
        public DateTime Namsinh { get => namsinh; set => namsinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Cmt { get => cmt; set => cmt = value; }
        public string Hanthe { get => hanthe; set => hanthe = value; }
    }
}
