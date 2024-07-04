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
    public class DocGiaBUS
    {
        public static DataTable ds_docgia()
        {
            return DocGiaDAL.getallData();
        }

        public static void InsertDocGia(tbDocGia dg)
        {
            DocGiaDAL.insertDocGia(dg);
        }
        public static void UpdateDocGia(tbDocGia dg)
        {
            DocGiaDAL.updateDocGia(dg);
        }
        public static void DeleteDocGia(tbDocGia dg)
        {
            DocGiaDAL.deleteDocGia(dg);
        }
    }
}
