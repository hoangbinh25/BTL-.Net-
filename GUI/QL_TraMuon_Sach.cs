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
    public partial class QL_TraMuon_Sach : Form
    {
        public QL_TraMuon_Sach()
        {
            InitializeComponent();
        }

        public void Loads_phieuMuon()
        {
            dgv_ds_muon_tra.DataSource = MuonTraBUS.ds_PhieuMuon();
        }
        public void Loads_chiTietPhieuMuon(String ma)
        {
            dgv_ds_chitietmuontra.DataSource = MuonTraBUS.ds_ChiTietPhieuMuon(ma);
        }
        public void clearFormPM()
        {
            if (cbb_doc_gia.Items.Count > 0)
                cbb_doc_gia.SelectedIndex = -1;
            txt_ma_the_muon.Text = "";
            txt_ngay_muon.Text = "";
            txt_ngay_tra.Text = "";
        }




        public void loads_sachs()
        {
            cbb_ten_sach.DataSource = MuonTraBUS.ds_sach();
            cbb_ten_sach.DisplayMember = "Tên Sách";
            cbb_ten_sach.ValueMember = "Mã Sách";
        }
        public void loads_member()
        {
            cbb_doc_gia.DataSource = MuonTraBUS.ds_doc_gia();
            cbb_doc_gia.DisplayMember = "Tên Độc Giả";
            cbb_doc_gia.ValueMember = "Mã Độc Giả";
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

        private void dgv_ds_chitietmuontra_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy chỉ số của hàng đang được chọn
            int rowIndex = e.RowIndex;

            // Kiểm tra xem chỉ số có hợp lệ không
            if (rowIndex >= 0 && rowIndex < dgv_ds_chitietmuontra.Rows.Count)
            {
                DataGridViewRow row = dgv_ds_chitietmuontra.Rows[rowIndex];
                cbb_ten_sach.SelectedValue = row.Cells["Mã Sách"].Value;
                txt_so_luong.Text = row.Cells["Số Lượng"].Value.ToString();
            }
        }

        private void btn_ngon_ngu_Click(object sender, EventArgs e)
        {
            NgonNgu ngonngu = new NgonNgu();
            this.Hide();
            ngonngu.ShowDialog();
        }

        private void btn_xoa_sach_Click(object sender, EventArgs e)
        {
            int phieu_muon_id = int.Parse(txt_ma_the_muon.Text);
            int sach_id = int.Parse(cbb_ten_sach.SelectedValue.ToString());
            MuonTraBUS.xoa_ChiTietPM(phieu_muon_id, sach_id);
            Loads_phieuMuon();
            clearFormPM();
        }

        private void btn_them_sach_Click(object sender, EventArgs e)
        {
            int phieu_muon_id = int.Parse(txt_ma_the_muon.Text);
            int sach_id = int.Parse(cbb_ten_sach.SelectedValue.ToString());
            int so_luong = int.Parse(txt_so_luong.Text);
            tbChiTietMuonTra chiTietphieumuon = new tbChiTietMuonTra(phieu_muon_id, sach_id, so_luong);
            MuonTraBUS.them_ChiTietPM(chiTietphieumuon);
            Loads_phieuMuon();
            clearFormPM();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            int phieu_muon_id = int.Parse(txt_ma_the_muon.Text);
            int doc_gia_id = int.Parse(cbb_doc_gia.SelectedValue.ToString());
            DateTime ngay_muon = DateTime.Parse(txt_ngay_muon.Text);
            DateTime ngay_hen_tra = DateTime.Parse(txt_ngay_tra.Text);
            tbMuonTra tbMuontra = new tbMuonTra(phieu_muon_id, doc_gia_id, ngay_muon, ngay_hen_tra);
            MuonTraBUS.sua_pm(tbMuontra);
            Loads_phieuMuon();
            clearFormPM();
        }

        private void btn_bo_qua_Click(object sender, EventArgs e)
        {
            cbb_doc_gia.Enabled = true;
            txt_ma_the_muon.Enabled = true;
            txt_ngay_muon.Enabled = true;
            txt_ngay_tra.Enabled = true;
            btn_them.Enabled = true;
            btn_tra.Enabled = true;
            btn_xem.Enabled = true;
            clearFormPM();
        }

        private void btn_tra_Click(object sender, EventArgs e)
        {
            int phieu_muon_id = int.Parse(txt_ma_the_muon.Text);
            int doc_gia_id = int.Parse(cbb_doc_gia.SelectedValue.ToString());
            DateTime ngay_muon = DateTime.Parse(txt_ngay_muon.Text);
            DateTime ngay_hen_tra = DateTime.Parse(txt_ngay_tra.Text);
            tbMuonTra tbMuontra = new tbMuonTra(phieu_muon_id, doc_gia_id, ngay_muon, ngay_hen_tra);
            MuonTraBUS.xoa_pm(tbMuontra);
            Loads_phieuMuon();
            clearFormPM();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            txt_ngay_muon.Enabled = true;
            txt_ngay_tra.Enabled = true;
            btn_them.Enabled = false;
            btn_tra.Enabled = false;
            btn_xem.Enabled = false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            int phieu_muon_id = int.Parse(txt_ma_the_muon.Text);
            int doc_gia_id = int.Parse(cbb_doc_gia.SelectedValue.ToString());
            DateTime ngay_muon = DateTime.Parse(txt_ngay_muon.Text);
            DateTime ngay_hen_tra = DateTime.Parse(txt_ngay_tra.Text);
            tbMuonTra tbMuontra = new tbMuonTra(phieu_muon_id, doc_gia_id, ngay_muon, ngay_hen_tra);
            MuonTraBUS.them_pm(tbMuontra);
            Loads_phieuMuon();
            clearFormPM();
        }

        private void btn_xem_Click(object sender, EventArgs e)
        {
            if (cbb_doc_gia.Text == "")
            {
                MessageBox.Show("độc giả không được phép rỗng");
            }
            else
            {
                cbb_doc_gia.Enabled = false;
                txt_ma_the_muon.Enabled = false;
                txt_ngay_muon.Enabled = false;
                txt_ngay_tra.Enabled = false;
                Loads_chiTietPhieuMuon(cbb_doc_gia.SelectedValue.ToString());
            }
        }

        private void dgv_ds_muon_tra_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy chỉ số của hàng đang được chọn
            int rowIndex = e.RowIndex;

            // Kiểm tra xem chỉ số có hợp lệ không
            if (rowIndex >= 0 && rowIndex < dgv_ds_muon_tra.Rows.Count)
            {
                DataGridViewRow row = dgv_ds_muon_tra.Rows[rowIndex];
                cbb_doc_gia.SelectedValue = row.Cells["Mã Độc Giả"].Value;
                txt_ma_the_muon.Text = row.Cells["Mã Phiếu Mượn"].Value.ToString();
                txt_ngay_muon.Text = DateTime.Parse(row.Cells["Ngày Mượn"].Value.ToString()).ToString("yyyy-MM-dd");
                txt_ngay_tra.Text = DateTime.Parse(row.Cells["Ngày Hẹn Trả"].Value.ToString()).ToString("yyyy-MM-dd");
                cbb_doc_gia.Enabled = false;
                txt_ma_the_muon.Enabled = false;
                txt_ngay_muon.Enabled = false;
                txt_ngay_tra.Enabled = false;
            }
        }

        private void QL_TraMuon_Sach_Load(object sender, EventArgs e)
        {
            Loads_phieuMuon();
            loads_sachs();
            loads_member();
        }

        private void btn_the_loai_Click(object sender, EventArgs e)
        {
            QL_The_loai qltl = new QL_The_loai();
            this.Hide();
            qltl.ShowDialog();
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
    }
}
