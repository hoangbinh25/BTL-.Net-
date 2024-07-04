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
    public class NgonNguBUS
    {
        public static DataTable getAllNgonNgu()
        {
            return NgonNguDAL.getAllNN();
        }
        public static void Them_NgonNgu(String ngonNgu)
        {
            NgonNguDAL.insert_ngonngu(ngonNgu);
        }

        public static void Sua_NgonNgu(tbNgonNgu ngonNgu)
        {
            NgonNguDAL.update_ngonngu(ngonNgu);
        }
        public static void Xoa_NgonNgu(tbNgonNgu ngonNgu)
        {
            NgonNguDAL.delete_ngonngu(ngonNgu);
        }
    }
}
