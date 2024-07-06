using BUS;
using DAL;
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
    public partial class QL_Kho_Sach : Form
    {
        DataTable dt = new DataTable();
        public QL_Kho_Sach()
        {
            InitializeComponent();
        }

        public void loads_dgv()
        {
            dgv_kho_sach.DataSource = SachBUS.ds_sach();
        }

        public void loads_theloai()
        {
            cbb_the_loai.DataSource = SachBUS.ds_theloai();
            cbb_the_loai.DisplayMember = "ten_loai_sach";
            cbb_the_loai.ValueMember = "loai_sach_id";
        }

        public void loads_ngonngu()
        {
            cbb_ngon_ngu.DataSource = SachBUS.ds_ngon_ngu();
            cbb_ngon_ngu.DisplayMember = "ten_ngon_ngu";
            cbb_ngon_ngu.ValueMember = "ngon_ngu_id";
        }

        public void ClearForm()
        {
            // Xóa sạch các TextBox
            txt_ma_sach.Text = string.Empty;
            txt_ten_sach.Text = string.Empty;
            txt_tac_gia.Text = string.Empty;
            txt_ngay_nhap.Text = string.Empty;
            txt_gia_ban.Text = string.Empty;
            txt_nha_xuat_ban.Text = string.Empty;
            txt_so_luong.Text = string.Empty;

            // Đặt lại giá trị mặc định cho ComboBox
            if (cbb_the_loai.Items.Count > 0)
                cbb_the_loai.SelectedIndex = -1;
            if (cbb_ngon_ngu.Items.Count > 0)
                cbb_ngon_ngu.SelectedIndex = -1;
        }

        private void QL_Kho_Sach_Load(object sender, EventArgs e)
        {
            
            loads_dgv();
            loads_ngonngu();
            loads_theloai();
            ClearForm();
            
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

        private void btn_ngon_ngu_Click(object sender, EventArgs e)
        {
            NgonNgu ngonngu = new NgonNgu();
            this.Hide();
            ngonngu.ShowDialog();
        }

        private void btn_the_loai_Click(object sender, EventArgs e)
        {
            QL_The_loai qltl = new QL_The_loai();
            this.Hide();
            qltl.ShowDialog();
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dgv_kho_sach_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy chỉ số của hàng đang được chọn
            int rowIndex = e.RowIndex;

            // Kiểm tra xem chỉ số có hợp lệ không
            if (rowIndex >= 0 && rowIndex < dgv_kho_sach.Rows.Count)
            {
                DataGridViewRow row = dgv_kho_sach.Rows[rowIndex];
                txt_ma_sach.Text = row.Cells["Mã Sách"].Value.ToString();
                txt_ten_sach.Text = row.Cells["Tên Sách"].Value.ToString();
                txt_tac_gia.Text = row.Cells["Tác Giả"].Value.ToString();
                cbb_the_loai.SelectedValue = row.Cells["Loại Sách"].Selected;
                cbb_ngon_ngu.SelectedValue = row.Cells["Ngôn Ngữ"].Selected;
                txt_ngay_nhap.Text = DateTime.Parse(row.Cells["Ngày Nhập"].Value.ToString()).ToString("yyyy-MM-dd");
                txt_gia_ban.Text = row.Cells["Giá Sách"].Value.ToString();
                txt_nha_xuat_ban.Text = row.Cells["Nhà xuất bản"].Value.ToString();
                txt_so_luong.Text = row.Cells["Số Lượng"].Value.ToString();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int sach_id = int.Parse(txt_ma_sach.Text);
                String ten_sach = txt_ten_sach.Text;
                String tac_gia = txt_tac_gia.Text;
                String loai_sach = cbb_the_loai.SelectedValue.ToString();
                String ngon_ngu = cbb_ngon_ngu.SelectedValue.ToString();
                DateTime ngay_nhap = DateTime.Parse(txt_ngay_nhap.Text);
                String gia_bia = txt_gia_ban.Text;
                String nha_xb = txt_nha_xuat_ban.Text;
                int soluong = int.Parse(txt_so_luong.Text);
                tblSach sach = new tblSach(sach_id, ten_sach, tac_gia, loai_sach, ngon_ngu, ngay_nhap, gia_bia, nha_xb, soluong);
                SachBUS.xoa_sach(sach);
                loads_dgv();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi Load : {ex.Message}");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

            try
            {
                int sach_id = int.Parse(txt_ma_sach.Text);
                String ten_sach = txt_ten_sach.Text;
                String tac_gia = txt_tac_gia.Text;
                String loai_sach = cbb_the_loai.SelectedValue.ToString();
                String ngon_ngu = cbb_ngon_ngu.SelectedValue.ToString();
                DateTime ngay_nhap = DateTime.Parse(txt_ngay_nhap.Text);
                String gia_bia = txt_gia_ban.Text;
                String nha_xb = txt_nha_xuat_ban.Text;
                int soluong = int.Parse(txt_so_luong.Text);
                tblSach sach = new tblSach(sach_id, ten_sach, tac_gia, loai_sach, ngon_ngu, ngay_nhap, gia_bia, nha_xb, soluong);
                SachBUS.sua_sach(sach);
                loads_dgv();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi Load : {ex.Message}");
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                //txt_ma_sach.Text = cbb_ngon_ngu.SelectedValue.ToString();
                int sach_id = int.Parse(txt_ma_sach.Text);
                String ten_sach = txt_ten_sach.Text;
                String tac_gia = txt_tac_gia.Text;
                String loai_sach = cbb_the_loai.SelectedValue.ToString();
                String ngon_ngu = cbb_ngon_ngu.SelectedValue.ToString();
                DateTime ngay_nhap = DateTime.Parse(txt_ngay_nhap.Text);
                String gia_bia = txt_gia_ban.Text;
                String nha_xb = txt_nha_xuat_ban.Text;
                int soluong = int.Parse(txt_so_luong.Text);
                tblSach sach = new tblSach(sach_id, ten_sach, tac_gia, loai_sach, ngon_ngu, ngay_nhap, gia_bia, nha_xb, soluong);
                SachBUS.them_sach(sach);
                loads_dgv();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi Load : {ex.Message}");
            }
        }

        private void btn_doc_gia_Click(object sender, EventArgs e)
        {
            QL_Tai_Khoan_Doc_Gia qldg = new QL_Tai_Khoan_Doc_Gia();
            this.Hide();
            qldg.ShowDialog();
        }

        private void btn_muon_tra_Click(object sender, EventArgs e)
        {
            QL_TraMuon_Sach qlmt = new QL_TraMuon_Sach();
            this.Hide();
            qlmt.ShowDialog();
        }

        private void btn_xuat_bao_cao_Click(object sender, EventArgs e)
        {
            fInBaoCao f = new fInBaoCao();
            f.ShowDialog();
        }
    }
}
