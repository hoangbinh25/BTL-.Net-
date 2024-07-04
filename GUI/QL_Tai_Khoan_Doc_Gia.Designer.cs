using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class QL_Tai_Khoan_Doc_Gia
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
            this.btn_dang_xuat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_the_loai = new System.Windows.Forms.Button();
            this.btn_ngon_ngu = new System.Windows.Forms.Button();
            this.btn_muon_tra = new System.Windows.Forms.Button();
            this.btn_doc_gia = new System.Windows.Forms.Button();
            this.btn_kho_sach = new System.Windows.Forms.Button();
            this.txt_dia_chi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_ds_doc_gia = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_han_the = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nam_sinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cmt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_so_dien_thoai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_bo_qua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_ten_doc_gia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ma_doc_gia = new System.Windows.Forms.TextBox();
            this.label2222 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ds_doc_gia)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_dang_xuat
            // 
            this.btn_dang_xuat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dang_xuat.Location = new System.Drawing.Point(10, 474);
            this.btn_dang_xuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dang_xuat.Name = "btn_dang_xuat";
            this.btn_dang_xuat.Size = new System.Drawing.Size(142, 27);
            this.btn_dang_xuat.TabIndex = 4;
            this.btn_dang_xuat.Text = "Đăng Xuất";
            this.btn_dang_xuat.UseVisualStyleBackColor = true;
            this.btn_dang_xuat.Click += new System.EventHandler(this.btn_dang_xuat_Click);
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
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 516);
            this.panel1.TabIndex = 8;
            // 
            // btn_the_loai
            // 
            this.btn_the_loai.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_the_loai.Location = new System.Drawing.Point(9, 167);
            this.btn_the_loai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_the_loai.Name = "btn_the_loai";
            this.btn_the_loai.Size = new System.Drawing.Size(142, 26);
            this.btn_the_loai.TabIndex = 11;
            this.btn_the_loai.Text = "Thể Loại";
            this.btn_the_loai.UseVisualStyleBackColor = true;
            this.btn_the_loai.Click += new System.EventHandler(this.btn_the_loai_Click);
            // 
            // btn_ngon_ngu
            // 
            this.btn_ngon_ngu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ngon_ngu.Location = new System.Drawing.Point(10, 128);
            this.btn_ngon_ngu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ngon_ngu.Name = "btn_ngon_ngu";
            this.btn_ngon_ngu.Size = new System.Drawing.Size(142, 29);
            this.btn_ngon_ngu.TabIndex = 10;
            this.btn_ngon_ngu.Text = "Ngôn ngữ";
            this.btn_ngon_ngu.UseVisualStyleBackColor = true;
            this.btn_ngon_ngu.Click += new System.EventHandler(this.btn_ngon_ngu_Click);
            // 
            // btn_muon_tra
            // 
            this.btn_muon_tra.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_muon_tra.Location = new System.Drawing.Point(10, 93);
            this.btn_muon_tra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_muon_tra.Name = "btn_muon_tra";
            this.btn_muon_tra.Size = new System.Drawing.Size(142, 28);
            this.btn_muon_tra.TabIndex = 9;
            this.btn_muon_tra.Text = "Mượn Trả";
            this.btn_muon_tra.UseVisualStyleBackColor = true;
            this.btn_muon_tra.Click += new System.EventHandler(this.btn_muon_tra_Click_1);
            // 
            // btn_doc_gia
            // 
            this.btn_doc_gia.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doc_gia.Location = new System.Drawing.Point(10, 54);
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
            this.btn_kho_sach.Location = new System.Drawing.Point(10, 16);
            this.btn_kho_sach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_kho_sach.Name = "btn_kho_sach";
            this.btn_kho_sach.Size = new System.Drawing.Size(142, 29);
            this.btn_kho_sach.TabIndex = 7;
            this.btn_kho_sach.Text = "Kho Sách";
            this.btn_kho_sach.UseVisualStyleBackColor = true;
            this.btn_kho_sach.Click += new System.EventHandler(this.btn_kho_sach_Click_1);
            // 
            // txt_dia_chi
            // 
            this.txt_dia_chi.BackColor = System.Drawing.SystemColors.Control;
            this.txt_dia_chi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_dia_chi.Location = new System.Drawing.Point(20, 175);
            this.txt_dia_chi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_dia_chi.Multiline = true;
            this.txt_dia_chi.Name = "txt_dia_chi";
            this.txt_dia_chi.Size = new System.Drawing.Size(757, 23);
            this.txt_dia_chi.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 21);
            this.label8.TabIndex = 23;
            this.label8.Text = "Địa Chỉ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(175, -2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(855, 515);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Độc Giả";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_ds_doc_gia);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(21, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(809, 234);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // dgv_ds_doc_gia
            // 
            this.dgv_ds_doc_gia.AllowUserToAddRows = false;
            this.dgv_ds_doc_gia.AllowUserToDeleteRows = false;
            this.dgv_ds_doc_gia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ds_doc_gia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ds_doc_gia.Location = new System.Drawing.Point(0, 22);
            this.dgv_ds_doc_gia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_ds_doc_gia.Name = "dgv_ds_doc_gia";
            this.dgv_ds_doc_gia.ReadOnly = true;
            this.dgv_ds_doc_gia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_ds_doc_gia.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_ds_doc_gia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ds_doc_gia.Size = new System.Drawing.Size(809, 218);
            this.dgv_ds_doc_gia.TabIndex = 0;
            this.dgv_ds_doc_gia.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ds_doc_gia_RowEnter);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_han_the);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_nam_sinh);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_dia_chi);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txt_cmt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_so_dien_thoai);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btn_bo_qua);
            this.panel2.Controls.Add(this.btn_xoa);
            this.panel2.Controls.Add(this.btn_sua);
            this.panel2.Controls.Add(this.btn_them);
            this.panel2.Controls.Add(this.txt_ten_doc_gia);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_ma_doc_gia);
            this.panel2.Controls.Add(this.label2222);
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(21, 26);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(809, 238);
            this.panel2.TabIndex = 0;
            // 
            // txt_han_the
            // 
            this.txt_han_the.BackColor = System.Drawing.SystemColors.Control;
            this.txt_han_the.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_han_the.Location = new System.Drawing.Point(423, 125);
            this.txt_han_the.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_han_the.Multiline = true;
            this.txt_han_the.Name = "txt_han_the";
            this.txt_han_the.Size = new System.Drawing.Size(355, 28);
            this.txt_han_the.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(405, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "Hạn Thẻ";
            // 
            // txt_nam_sinh
            // 
            this.txt_nam_sinh.BackColor = System.Drawing.SystemColors.Control;
            this.txt_nam_sinh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_nam_sinh.Location = new System.Drawing.Point(20, 125);
            this.txt_nam_sinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nam_sinh.Multiline = true;
            this.txt_nam_sinh.Name = "txt_nam_sinh";
            this.txt_nam_sinh.Size = new System.Drawing.Size(355, 28);
            this.txt_nam_sinh.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Năm Sinh";
            // 
            // txt_cmt
            // 
            this.txt_cmt.BackColor = System.Drawing.SystemColors.Control;
            this.txt_cmt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_cmt.Location = new System.Drawing.Point(423, 75);
            this.txt_cmt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cmt.Multiline = true;
            this.txt_cmt.Name = "txt_cmt";
            this.txt_cmt.Size = new System.Drawing.Size(355, 25);
            this.txt_cmt.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(405, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "CMT";
            // 
            // txt_so_dien_thoai
            // 
            this.txt_so_dien_thoai.BackColor = System.Drawing.SystemColors.Control;
            this.txt_so_dien_thoai.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_so_dien_thoai.Location = new System.Drawing.Point(423, 26);
            this.txt_so_dien_thoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_so_dien_thoai.Multiline = true;
            this.txt_so_dien_thoai.Name = "txt_so_dien_thoai";
            this.txt_so_dien_thoai.Size = new System.Drawing.Size(355, 23);
            this.txt_so_dien_thoai.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(405, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Điện Thoại";
            // 
            // btn_bo_qua
            // 
            this.btn_bo_qua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bo_qua.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bo_qua.ForeColor = System.Drawing.Color.Black;
            this.btn_bo_qua.Image = global::GUI.Properties.Resources.z5560539339010_ef792d56ebbc8998d0d577435891ae63;
            this.btn_bo_qua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bo_qua.Location = new System.Drawing.Point(695, 205);
            this.btn_bo_qua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_bo_qua.Name = "btn_bo_qua";
            this.btn_bo_qua.Padding = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btn_bo_qua.Size = new System.Drawing.Size(81, 27);
            this.btn_bo_qua.TabIndex = 12;
            this.btn_bo_qua.Text = "Bỏ Qua";
            this.btn_bo_qua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_bo_qua.UseVisualStyleBackColor = true;
            this.btn_bo_qua.Click += new System.EventHandler(this.btn_bo_qua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_xoa.Image = global::GUI.Properties.Resources.z5560539339010_ef792d56ebbc8998d0d577435891ae63;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(243, 205);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Padding = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btn_xoa.Size = new System.Drawing.Size(75, 27);
            this.btn_xoa.TabIndex = 11;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.Black;
            this.btn_sua.Image = global::GUI.Properties.Resources.z5560539359740_9337aa11269aeccd6e939ece18cfa20e;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(131, 205);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Padding = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btn_sua.Size = new System.Drawing.Size(75, 27);
            this.btn_sua.TabIndex = 10;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_them.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.Black;
            this.btn_them.Image = global::GUI.Properties.Resources.z5560539359591_8726bde7817e7680733c216c1b763b9d;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(20, 205);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Padding = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btn_them.Size = new System.Drawing.Size(75, 27);
            this.btn_them.TabIndex = 9;
            this.btn_them.Text = "Thêm ";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click_1);
            // 
            // txt_ten_doc_gia
            // 
            this.txt_ten_doc_gia.BackColor = System.Drawing.SystemColors.Control;
            this.txt_ten_doc_gia.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_ten_doc_gia.Location = new System.Drawing.Point(20, 75);
            this.txt_ten_doc_gia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ten_doc_gia.Multiline = true;
            this.txt_ten_doc_gia.Name = "txt_ten_doc_gia";
            this.txt_ten_doc_gia.Size = new System.Drawing.Size(355, 25);
            this.txt_ten_doc_gia.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Độc Giả";
            // 
            // txt_ma_doc_gia
            // 
            this.txt_ma_doc_gia.BackColor = System.Drawing.SystemColors.Control;
            this.txt_ma_doc_gia.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_ma_doc_gia.Location = new System.Drawing.Point(20, 26);
            this.txt_ma_doc_gia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ma_doc_gia.Multiline = true;
            this.txt_ma_doc_gia.Name = "txt_ma_doc_gia";
            this.txt_ma_doc_gia.Size = new System.Drawing.Size(355, 23);
            this.txt_ma_doc_gia.TabIndex = 3;
            // 
            // label2222
            // 
            this.label2222.AutoSize = true;
            this.label2222.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2222.ForeColor = System.Drawing.Color.White;
            this.label2222.Location = new System.Drawing.Point(3, 1);
            this.label2222.Name = "label2222";
            this.label2222.Size = new System.Drawing.Size(90, 21);
            this.label2222.TabIndex = 2;
            this.label2222.Text = "Mã Độc Giả";
            // 
            // QL_Tai_Khoan_Doc_Gia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.xanhtim2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1030, 512);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QL_Tai_Khoan_Doc_Gia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QL_Tai_Khoan_Doc_Gia";
            this.Load += new System.EventHandler(this.QL_Tai_Khoan_Doc_Gia_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ds_doc_gia)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_dang_xuat;
        private Panel panel1;
        private TextBox txt_dia_chi;
        private Label label8;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgv_ds_doc_gia;
        private Panel panel2;
        private TextBox txt_cmt;
        private Label label4;
        private TextBox txt_so_dien_thoai;
        private Label label5;
        private Button btn_bo_qua;
        private Button btn_xoa;
        private Button btn_sua;
        private Button btn_them;
        private TextBox txt_ten_doc_gia;
        private Label label2;
        private TextBox txt_ma_doc_gia;
        private Label label2222;
        private TextBox txt_han_the;
        private Label label1;
        private TextBox txt_nam_sinh;
        private Label label3;
        private Button btn_the_loai;
        private Button btn_ngon_ngu;
        private Button btn_muon_tra;
        private Button btn_doc_gia;
        private Button btn_kho_sach;
    }
}