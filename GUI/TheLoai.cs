using BUS;
using DTO;
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
    public partial class QL_The_loai : Form
    {
        public QL_The_loai()
        {
            InitializeComponent();
        }
        public void loads_dgv()
        {
            dgv_ds_the_loai.DataSource = TheLoaiBUS.getAlltheloai();
        }

        private void ClearForm()
        {
            txt_ma_the_loai.Clear();
            txt_the_loai.Clear();
        }

        private void btn_them_Click_1(object sender, EventArgs e)
        {
            try
            {
                int ma = int.Parse(txt_ma_the_loai.Text);
                String ten = txt_the_loai.Text;
                tbtheLoai tb = new tbtheLoai(ma, ten);
                TheLoaiBUS.Them_theloai(ten);
                MessageBox.Show("Bạn đã thêm " + ten + " thành công");
                loads_dgv();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_sua_Click_1(object sender, EventArgs e)
        {
            try
            {
                int ma = int.Parse(txt_ma_the_loai.Text);
                String ten = txt_the_loai.Text;
                tbtheLoai tb = new tbtheLoai(ma, ten);
                TheLoaiBUS.Sua_NgonNgu(tb);
                MessageBox.Show("Bạn đã cập nhật " + ten + " thành công");
                loads_dgv();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_xoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                int ma = int.Parse(txt_ma_the_loai.Text);
                String ten = txt_the_loai.Text;
                tbtheLoai tb = new tbtheLoai(ma, ten);
                TheLoaiBUS.Xoa_theloai(tb);
                MessageBox.Show("Bạn đã xóa " + ten + " thành công");
                loads_dgv();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void QL_The_loai_Load(object sender, EventArgs e)
        {
            loads_dgv();
        }
        private void btn_kho_sach_Click_1(object sender, EventArgs e)
        {
            QL_Kho_Sach qlmt = new QL_Kho_Sach();
            this.Hide();
            qlmt.ShowDialog();
        }

        private void btn_doc_gia_Click_1(object sender, EventArgs e)
        {
            QL_Tai_Khoan_Doc_Gia qlmt = new QL_Tai_Khoan_Doc_Gia();
            this.Hide();
            qlmt.ShowDialog();
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

        private void btn_the_loai_Click_1(object sender, EventArgs e)
        {

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

        private void dgv_ds_the_loai_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            {
                // Lấy chỉ số của hàng đang được chọn
                int rowIndex = e.RowIndex;

                // Kiểm tra xem chỉ số có hợp lệ không
                if (rowIndex >= 0 && rowIndex < dgv_ds_the_loai.Rows.Count)
                {
                    DataGridViewRow row = dgv_ds_the_loai.Rows[rowIndex];
                    txt_ma_the_loai.Text = row.Cells["Mã"].Value.ToString();
                    txt_the_loai.Text = row.Cells["Tên loại sách"].Value.ToString();
                }
            }
        }
    }
}
