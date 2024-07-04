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
    public class TheLoaiBUS
    {
        public static DataTable getAlltheloai()
        {
            return TheLoaiDAL.getAlltt();
        }
        public static void Them_theloai(String theLoai)
        {
            TheLoaiDAL.insert_theloai(theLoai);
        }

        public static void Sua_NgonNgu(tbtheLoai theLoai)
        {
            TheLoaiDAL.update_theloai(theLoai);
        }
        public static void Xoa_theloai(tbtheLoai theLoai)
        {
            TheLoaiDAL.delete_theloai(theLoai);
        }
    }
}
