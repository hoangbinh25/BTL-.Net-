using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;


namespace GUI
{
    public partial class form_dang_nhap : Form
    {
        //public TaiKhoanDAL tkDAL = new TaiKhoanDAL();
        private readonly ITaiKhoan _taiKhoan;
      
        public form_dang_nhap(ITaiKhoan taiKhoan)
        {
            InitializeComponent();
            _taiKhoan = taiKhoan;
        }
        public form_dang_nhap() : this(new TaiKhoanBUS())
        {
        }

        private void btn_dang_nhap_Click_1(object sender, EventArgs e)
        {
            string username = txt_ten_nguoi_dung.Text;
            string password = txt_mat_khau.Text;

                if (_taiKhoan.ValidateUser(username, password))
                {
                    MessageBox.Show("Bạn đã đăng nhập thành công!");

                    QL_Kho_Sach qlks = new QL_Kho_Sach();
                    this.Hide();
                    qlks.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
                }
        }
    }
}
