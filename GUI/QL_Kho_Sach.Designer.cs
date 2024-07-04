using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class QL_Kho_Sach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_ten_sach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label2222 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_kho_sach = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_tac_gia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_so_luong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nha_xuat_ban = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_gia_bia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ngay_nhap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_ngon_ngu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_boqua = new System.Windows.Forms.Button();
            this.cbb_the_loai = new System.Windows.Forms.ComboBox();
            this.txt_ma_sach = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_dang_xuat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_the_loai = new System.Windows.Forms.Button();
            this.btn_ngon_ngu = new System.Windows.Forms.Button();
            this.btn_muon_tra = new System.Windows.Forms.Button();
            this.btn_doc_gia = new System.Windows.Forms.Button();
            this.btn_kho_sach = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kho_sach)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_xoa
            // 
            this.btn_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_xoa.Image = global::GUI.Properties.Resources.z5560539339010_ef792d56ebbc8998d0d577435891ae63;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(533, 275);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Padding = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btn_xoa.Size = new System.Drawing.Size(75, 27);
            this.btn_xoa.TabIndex = 11;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            this.btn_sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.Black;
            this.btn_sua.Image = global::GUI.Properties.Resources.z5560539359740_9337aa11269aeccd6e939ece18cfa20e;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(281, 275);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Padding = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btn_sua.Size = new System.Drawing.Size(75, 27);
            this.btn_sua.TabIndex = 10;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_them.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.Black;
            this.btn_them.Image = global::GUI.Properties.Resources.z5560539359591_8726bde7817e7680733c216c1b763b9d;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(21, 276);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Padding = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btn_them.Size = new System.Drawing.Size(75, 27);
            this.btn_them.TabIndex = 9;
            this.btn_them.Text = "Thêm ";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // txt_ten_sach
            // 
            this.txt_ten_sach.BackColor = System.Drawing.SystemColors.Control;
            this.txt_ten_sach.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_ten_sach.Location = new System.Drawing.Point(20, 72);
            this.txt_ten_sach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ten_sach.Multiline = true;
            this.txt_ten_sach.Name = "txt_ten_sach";
            this.txt_ten_sach.Size = new System.Drawing.Size(364, 23);
            this.txt_ten_sach.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thể Loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Sách";
            // 
            // label2222
            // 
            this.label2222.AutoSize = true;
            this.label2222.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2222.ForeColor = System.Drawing.Color.White;
            this.label2222.Location = new System.Drawing.Point(20, 2);
            this.label2222.Name = "label2222";
            this.label2222.Size = new System.Drawing.Size(69, 21);
            this.label2222.TabIndex = 2;
            this.label2222.Text = "Mã Sách";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_kho_sach);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(21, 338);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(874, 178);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // dgv_kho_sach
            // 
            this.dgv_kho_sach.AllowUserToAddRows = false;
            this.dgv_kho_sach.AllowUserToDeleteRows = false;
            this.dgv_kho_sach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_kho_sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kho_sach.Location = new System.Drawing.Point(-7, 17);
            this.dgv_kho_sach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_kho_sach.Name = "dgv_kho_sach";
            this.dgv_kho_sach.ReadOnly = true;
            this.dgv_kho_sach.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_kho_sach.RowHeadersWidth = 51;
            this.dgv_kho_sach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_kho_sach.Size = new System.Drawing.Size(868, 174);
            this.dgv_kho_sach.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_tac_gia);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txt_so_luong);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_nha_xuat_ban);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txt_gia_bia);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_ngay_nhap);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cbb_ngon_ngu);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_boqua);
            this.panel2.Controls.Add(this.btn_xoa);
            this.panel2.Controls.Add(this.btn_sua);
            this.panel2.Controls.Add(this.btn_them);
            this.panel2.Controls.Add(this.txt_ten_sach);
            this.panel2.Controls.Add(this.cbb_the_loai);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_ma_sach);
            this.panel2.Controls.Add(this.label2222);
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(21, 26);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(874, 312);
            this.panel2.TabIndex = 0;
            // 
            // txt_tac_gia
            // 
            this.txt_tac_gia.BackColor = System.Drawing.SystemColors.Control;
            this.txt_tac_gia.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_tac_gia.Location = new System.Drawing.Point(20, 122);
            this.txt_tac_gia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tac_gia.Multiline = true;
            this.txt_tac_gia.Name = "txt_tac_gia";
            this.txt_tac_gia.Size = new System.Drawing.Size(364, 23);
            this.txt_tac_gia.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(20, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 21);
            this.label8.TabIndex = 23;
            this.label8.Text = "Tác Giả";
            // 
            // txt_so_luong
            // 
            this.txt_so_luong.BackColor = System.Drawing.SystemColors.Control;
            this.txt_so_luong.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_so_luong.Location = new System.Drawing.Point(456, 182);
            this.txt_so_luong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_so_luong.Multiline = true;
            this.txt_so_luong.Name = "txt_so_luong";
            this.txt_so_luong.Size = new System.Drawing.Size(362, 23);
            this.txt_so_luong.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(456, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "Số Lượng";
            // 
            // txt_nha_xuat_ban
            // 
            this.txt_nha_xuat_ban.BackColor = System.Drawing.SystemColors.Control;
            this.txt_nha_xuat_ban.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_nha_xuat_ban.Location = new System.Drawing.Point(456, 121);
            this.txt_nha_xuat_ban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nha_xuat_ban.Multiline = true;
            this.txt_nha_xuat_ban.Name = "txt_nha_xuat_ban";
            this.txt_nha_xuat_ban.Size = new System.Drawing.Size(362, 23);
            this.txt_nha_xuat_ban.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(456, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "Nhà Xuất Bản";
            // 
            // txt_gia_bia
            // 
            this.txt_gia_bia.BackColor = System.Drawing.SystemColors.Control;
            this.txt_gia_bia.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_gia_bia.Location = new System.Drawing.Point(456, 71);
            this.txt_gia_bia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_gia_bia.Multiline = true;
            this.txt_gia_bia.Name = "txt_gia_bia";
            this.txt_gia_bia.Size = new System.Drawing.Size(362, 23);
            this.txt_gia_bia.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(456, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Giá Bìa";
            // 
            // txt_ngay_nhap
            // 
            this.txt_ngay_nhap.BackColor = System.Drawing.SystemColors.Control;
            this.txt_ngay_nhap.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_ngay_nhap.Location = new System.Drawing.Point(456, 25);
            this.txt_ngay_nhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ngay_nhap.Multiline = true;
            this.txt_ngay_nhap.Name = "txt_ngay_nhap";
            this.txt_ngay_nhap.Size = new System.Drawing.Size(362, 23);
            this.txt_ngay_nhap.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(456, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ngày Nhập";
            // 
            // cbb_ngon_ngu
            // 
            this.cbb_ngon_ngu.BackColor = System.Drawing.SystemColors.Control;
            this.cbb_ngon_ngu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbb_ngon_ngu.FormattingEnabled = true;
            this.cbb_ngon_ngu.Location = new System.Drawing.Point(20, 227);
            this.cbb_ngon_ngu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_ngon_ngu.Name = "cbb_ngon_ngu";
            this.cbb_ngon_ngu.Size = new System.Drawing.Size(364, 29);
            this.cbb_ngon_ngu.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ngôn Ngữ";
            // 
            // btn_boqua
            // 
            this.btn_boqua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_boqua.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_boqua.ForeColor = System.Drawing.Color.Black;
            this.btn_boqua.Image = global::GUI.Properties.Resources.z5560539339010_ef792d56ebbc8998d0d577435891ae63;
            this.btn_boqua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_boqua.Location = new System.Drawing.Point(766, 275);
            this.btn_boqua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Padding = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btn_boqua.Size = new System.Drawing.Size(80, 27);
            this.btn_boqua.TabIndex = 12;
            this.btn_boqua.Text = "Bỏ Qua";
            this.btn_boqua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_boqua.UseVisualStyleBackColor = true;
            // 
            // cbb_the_loai
            // 
            this.cbb_the_loai.BackColor = System.Drawing.SystemColors.Control;
            this.cbb_the_loai.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbb_the_loai.FormattingEnabled = true;
            this.cbb_the_loai.Location = new System.Drawing.Point(20, 173);
            this.cbb_the_loai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_the_loai.Name = "cbb_the_loai";
            this.cbb_the_loai.Size = new System.Drawing.Size(364, 29);
            this.cbb_the_loai.TabIndex = 7;
            // 
            // txt_ma_sach
            // 
            this.txt_ma_sach.BackColor = System.Drawing.SystemColors.Control;
            this.txt_ma_sach.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_ma_sach.Location = new System.Drawing.Point(20, 26);
            this.txt_ma_sach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ma_sach.Multiline = true;
            this.txt_ma_sach.Name = "txt_ma_sach";
            this.txt_ma_sach.Size = new System.Drawing.Size(364, 23);
            this.txt_ma_sach.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(177, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(895, 540);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Kho Sách";
            // 
            // btn_dang_xuat
            // 
            this.btn_dang_xuat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dang_xuat.Location = new System.Drawing.Point(10, 487);
            this.btn_dang_xuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dang_xuat.Name = "btn_dang_xuat";
            this.btn_dang_xuat.Size = new System.Drawing.Size(142, 27);
            this.btn_dang_xuat.TabIndex = 4;
            this.btn_dang_xuat.Text = "Đăng Xuất";
            this.btn_dang_xuat.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::GUI.Properties.Resources.xanhtimdocmmm;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_the_loai);
            this.panel1.Controls.Add(this.btn_ngon_ngu);
            this.panel1.Controls.Add(this.btn_muon_tra);
            this.panel1.Controls.Add(this.btn_doc_gia);
            this.panel1.Controls.Add(this.btn_kho_sach);
            this.panel1.Controls.Add(this.btn_dang_xuat);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 540);
            this.panel1.TabIndex = 6;
            // 
            // btn_the_loai
            // 
            this.btn_the_loai.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_the_loai.Location = new System.Drawing.Point(9, 165);
            this.btn_the_loai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_the_loai.Name = "btn_the_loai";
            this.btn_the_loai.Size = new System.Drawing.Size(142, 26);
            this.btn_the_loai.TabIndex = 11;
            this.btn_the_loai.Text = "Thể Loại";
            this.btn_the_loai.UseVisualStyleBackColor = true;
            // 
            // btn_ngon_ngu
            // 
            this.btn_ngon_ngu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ngon_ngu.Location = new System.Drawing.Point(10, 126);
            this.btn_ngon_ngu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ngon_ngu.Name = "btn_ngon_ngu";
            this.btn_ngon_ngu.Size = new System.Drawing.Size(142, 29);
            this.btn_ngon_ngu.TabIndex = 10;
            this.btn_ngon_ngu.Text = "Ngôn ngữ";
            this.btn_ngon_ngu.UseVisualStyleBackColor = true;
            // 
            // btn_muon_tra
            // 
            this.btn_muon_tra.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_muon_tra.Location = new System.Drawing.Point(10, 91);
            this.btn_muon_tra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_muon_tra.Name = "btn_muon_tra";
            this.btn_muon_tra.Size = new System.Drawing.Size(142, 28);
            this.btn_muon_tra.TabIndex = 9;
            this.btn_muon_tra.Text = "Mượn Trả";
            this.btn_muon_tra.UseVisualStyleBackColor = true;
            // 
            // btn_doc_gia
            // 
            this.btn_doc_gia.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doc_gia.Location = new System.Drawing.Point(10, 52);
            this.btn_doc_gia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_doc_gia.Name = "btn_doc_gia";
            this.btn_doc_gia.Size = new System.Drawing.Size(142, 31);
            this.btn_doc_gia.TabIndex = 8;
            this.btn_doc_gia.Text = "Độc Giả";
            this.btn_doc_gia.UseVisualStyleBackColor = true;
            // 
            // btn_kho_sach
            // 
            this.btn_kho_sach.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kho_sach.Location = new System.Drawing.Point(10, 14);
            this.btn_kho_sach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_kho_sach.Name = "btn_kho_sach";
            this.btn_kho_sach.Size = new System.Drawing.Size(142, 29);
            this.btn_kho_sach.TabIndex = 7;
            this.btn_kho_sach.Text = "Kho Sách";
            this.btn_kho_sach.UseVisualStyleBackColor = true;
            // 
            // QL_Kho_Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.xanhtim2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1078, 543);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QL_Kho_Sach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QL_Kho_Sach";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kho_sach)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_xoa;
        private Button btn_sua;
        private Button btn_them;
        private TextBox txt_ten_sach;
        private Label label3;
        private Label label2;
        private Label label2222;
        private GroupBox groupBox2;
        private DataGridView dgv_kho_sach;
        private Panel panel2;
        private TextBox txt_ma_sach;
        private GroupBox groupBox1;
        private Button btn_dang_xuat;
        private Panel panel1;
        private Button btn_boqua;
        private ComboBox cbb_the_loai;
        private TextBox txt_tac_gia;
        private Label label8;
        private TextBox txt_so_luong;
        private Label label6;
        private TextBox txt_nha_xuat_ban;
        private Label label7;
        private TextBox txt_gia_bia;
        private Label label4;
        private TextBox txt_ngay_nhap;
        private Label label5;
        private ComboBox cbb_ngon_ngu;
        private Label label1;
        private Button btn_the_loai;
        private Button btn_ngon_ngu;
        private Button btn_muon_tra;
        private Button btn_doc_gia;
        private Button btn_kho_sach;
    }
}