using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public interface ITaiKhoan
    {
        bool ValidateUser(string username, string password);
    }

    public class TaiKhoanBUS : ITaiKhoan
    {
        public
            TaiKhoanDAL tkDAL = new TaiKhoanDAL();

        public bool ValidateUser(string username, string password)
        {
            return tkDAL.ValidateUser(username, password);
        }
    }
}
