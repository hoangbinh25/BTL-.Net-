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
    public partial class NgonNgu : Form
    {
        public NgonNgu()
        {
            InitializeComponent();
        }

        public void loads_dgv()
        {
            dgv_ds_ngon_ngu.DataSource = NgonNguBUS.getAllNgonNgu();
        }

        private void ClearForm()
        {
            txt_ma_ngon_ngu.Clear();
            txt_ngon_ngu.Clear();
        }


        private void dgv_ds_ngon_ngu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy chỉ số của hàng đang được chọn
            int rowIndex = e.RowIndex;

            // Kiểm tra xem chỉ số có hợp lệ không
            if (rowIndex >= 0 && rowIndex < dgv_ds_ngon_ngu.Rows.Count)
            {
                DataGridViewRow row = dgv_ds_ngon_ngu.Rows[rowIndex];
                txt_ma_ngon_ngu.Text = row.Cells["Mã"].Value.ToString();
                txt_ngon_ngu.Text = row.Cells["Tên ngôn ngữ"].Value.ToString();
            }
        }

        private void btn_dang_xuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                form_dang_nhap form_Dang_Nhap = new form_dang_nhap();
                form_Dang_Nhap.ShowDialog();
            }
        }

        private void btn_the_loai_Click(object sender, EventArgs e)
        {
            QL_The_loai qltl = new QL_The_loai();
            this.Hide();
            qltl.ShowDialog();
        }

        private void btn_ngon_ngu_Click(object sender, EventArgs e)
        {
            NgonNgu ngonngu = new NgonNgu();
            this.Hide();
            ngonngu.ShowDialog();
        }

        private void btn_muon_tra_Click(object sender, EventArgs e)
        {
            QL_TraMuon_Sach qlmt = new QL_TraMuon_Sach();
            this.Hide();
            qlmt.ShowDialog();
        }

        private void btn_doc_gia_Click(object sender, EventArgs e)
        {
            QL_Tai_Khoan_Doc_Gia qldg = new QL_Tai_Khoan_Doc_Gia();
            this.Hide();
            qldg.ShowDialog();
        }

        private void btn_kho_sach_Click(object sender, EventArgs e)
        {
            QL_Kho_Sach qlks = new QL_Kho_Sach();
            this.Hide();
            qlks.ShowDialog();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                String tenNN = txt_ngon_ngu.Text;
                NgonNguBUS.Them_NgonNgu(tenNN);
                MessageBox.Show("Bạn đã thêm " + tenNN + " thành công");
                loads_dgv();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                int maNgonNgu = int.Parse(txt_ma_ngon_ngu.Text);
                String tenNN = txt_ngon_ngu.Text;
                tbNgonNgu ngonNgu = new tbNgonNgu(maNgonNgu, tenNN);
                NgonNguBUS.Sua_NgonNgu(ngonNgu);
                MessageBox.Show("Bạn đã cập nhật " + tenNN + " thành công");
                loads_dgv();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int maNgonNgu = int.Parse(txt_ma_ngon_ngu.Text);
                String tenNN = txt_ngon_ngu.Text;
                tbNgonNgu ngonNgu = new tbNgonNgu(maNgonNgu, tenNN);
                NgonNguBUS.Xoa_NgonNgu(ngonNgu);
                MessageBox.Show("Bạn đã xóa " + tenNN + " thành công");
                loads_dgv();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NgonNgu_Load(object sender, EventArgs e)
        {
            loads_dgv();
        }
    }
}
