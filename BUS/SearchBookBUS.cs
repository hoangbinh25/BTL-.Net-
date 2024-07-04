using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SearchBookBUS
    {
        public static DataTable searchBooks(string title)
        {
            return SearchBookDAL.SearchBooks(title);
        }
    }
}
