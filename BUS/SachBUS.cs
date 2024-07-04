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
    /*   public interface BookService
       {
           DataTable ds_theloai();
           DataTable ds_ngon_ngu();
           DataTable ds_sach();
           void them_sach(tblSach sach);
           void sua_sach(tblSach sach);
           void xoa_sach(tblSach sach);

       }
    */

    public class SachBUS
    {
        public static DataTable ds_theloai()
        {
            return BookDAL.select_all_theLoai();
        }

        public static DataTable ds_ngon_ngu()
        {
            return BookDAL.select_all_ngon_ngu();
        }
        public static DataTable ds_sach()
        {
            return BookDAL.select_all_sach();
        }
        public static void them_sach(tblSach sach)
        {
            BookDAL.insert_sach(sach);
        }
        public static void sua_sach(tblSach sach)
        {
            BookDAL.edit_sach(sach);
        }
        public static void xoa_sach(tblSach sach)
        {
            BookDAL.delete_sach(sach);
        }
    }
}
