using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SqlConnectionData
    {
        public static SqlConnection Connect()
        {

            SqlConnection Conn = new SqlConnection(@"Data Source=.;Initial Catalog=QL_THUVIEN;Integrated Security=True;");

            //SqlConnection Conn = new SqlConnection(@"Data Source=THANHTUNG\THANHTUNG;Initial Catalog=QL_THUVIEN;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

            return Conn;
        }
    }
}
