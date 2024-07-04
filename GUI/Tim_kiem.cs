using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Tim_kiem : Form
    {
        public Tim_kiem()
        {
            InitializeComponent();
        }

        private void btn_tim_kiem_Click_1(object sender, EventArgs e)
        {
            string searchTerm = txt_tim_kiem.Text;

            if (!string.IsNullOrEmpty(searchTerm))
            {
                DataTable results = SearchBookBUS.searchBooks(searchTerm);
                dgv_ds_tim_kiem.DataSource = results;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm");
            }
        }

        private void btn_dang_xuat_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                form_dang_nhap form_Dang_Nhap = new form_dang_nhap();
                form_Dang_Nhap.ShowDialog();
            }
        }

        private void btn_the_loai_Click_1(object sender, EventArgs e)
        {
            QL_The_loai qltl = new QL_The_loai();
            this.Hide();
            qltl.ShowDialog();
        }

        private void btn_kho_sach_Click_1(object sender, EventArgs e)
        {
            QL_Kho_Sach qlks = new QL_Kho_Sach();
            this.Hide();
            qlks.ShowDialog();
        }

        private void btn_doc_gia_Click_1(object sender, EventArgs e)
        {
            QL_Tai_Khoan_Doc_Gia qldg = new QL_Tai_Khoan_Doc_Gia();
            this.Hide();
            qldg.ShowDialog();
        }

        private void btn_muon_tra_Click_1(object sender, EventArgs e)
        {
            QL_TraMuon_Sach qlmt = new QL_TraMuon_Sach();
            this.Hide();
            qlmt.ShowDialog();
        }

        private void btn_ngon_ngu_Click_1(object sender, EventArgs e)
        {
            NgonNgu ngonngu = new NgonNgu();
            this.Hide();
            ngonngu.ShowDialog();
        }
    }
}
