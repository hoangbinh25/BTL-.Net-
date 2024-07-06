using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class QL_TraMuon_Sach
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
            this.txt_ngay_tra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_ds_muon_tra = new System.Windows.Forms.DataGridView();
            this.txt_ngay_muon = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbb_doc_gia = new System.Windows.Forms.ComboBox();
            this.btn_luu = new System.Windows.Forms.Button();
            this.txt_ma_the_muon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_xem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_bo_qua = new System.Windows.Forms.Button();
            this.btn_tra = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label2222 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_dang_xuat = new System.Windows.Forms.Button();
            this.btn_the_loai = new System.Windows.Forms.Button();
            this.btn_ngon_ngu = new System.Windows.Forms.Button();
            this.btn_muon_tra = new System.Windows.Forms.Button();
            this.btn_doc_gia = new System.Windows.Forms.Button();
            this.btn_kho_sach = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_so_luong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_xoa_sach = new System.Windows.Forms.Button();
            this.btn_them_sach = new System.Windows.Forms.Button();
            this.cbb_ten_sach = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_ds_chitietmuontra = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ds_muon_tra)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ds_chitietmuontra)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ngay_tra
            // 
            this.txt_ngay_tra.BackColor = System.Drawing.SystemColors.Control;
            this.txt_ngay_tra.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_ngay_tra.Location = new System.Drawing.Point(564, 100);
            this.txt_ngay_tra.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_ngay_tra.Multiline = true;
            this.txt_ngay_tra.Name = "txt_ngay_tra";
            this.txt_ngay_tra.Size = new System.Drawing.Size(472, 31);
            this.txt_ngay_tra.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(540, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 28);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ngày Trả";
            // 
            // dgv_ds_muon_tra
            // 
            this.dgv_ds_muon_tra.AllowUserToAddRows = false;
            this.dgv_ds_muon_tra.AllowUserToDeleteRows = false;
            this.dgv_ds_muon_tra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ds_muon_tra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ds_muon_tra.Location = new System.Drawing.Point(0, 27);
            this.dgv_ds_muon_tra.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgv_ds_muon_tra.Name = "dgv_ds_muon_tra";
            this.dgv_ds_muon_tra.ReadOnly = true;
            this.dgv_ds_muon_tra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_ds_muon_tra.RowHeadersWidth = 51;
            this.dgv_ds_muon_tra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ds_muon_tra.Size = new System.Drawing.Size(1079, 169);
            this.dgv_ds_muon_tra.TabIndex = 0;
            this.dgv_ds_muon_tra.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ds_muon_tra_RowEnter);
            // 
            // txt_ngay_muon
            // 
            this.txt_ngay_muon.BackColor = System.Drawing.SystemColors.Control;
            this.txt_ngay_muon.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_ngay_muon.Location = new System.Drawing.Point(564, 32);
            this.txt_ngay_muon.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_ngay_muon.Multiline = true;
            this.txt_ngay_muon.Name = "txt_ngay_muon";
            this.txt_ngay_muon.Size = new System.Drawing.Size(472, 31);
            this.txt_ngay_muon.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbb_doc_gia);
            this.panel2.Controls.Add(this.btn_luu);
            this.panel2.Controls.Add(this.txt_ma_the_muon);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_xem);
            this.panel2.Controls.Add(this.txt_ngay_tra);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_ngay_muon);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btn_bo_qua);
            this.panel2.Controls.Add(this.btn_tra);
            this.panel2.Controls.Add(this.btn_sua);
            this.panel2.Controls.Add(this.btn_them);
            this.panel2.Controls.Add(this.label2222);
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(28, 32);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1078, 189);
            this.panel2.TabIndex = 0;
            // 
            // cbb_doc_gia
            // 
            this.cbb_doc_gia.BackColor = System.Drawing.SystemColors.Control;
            this.cbb_doc_gia.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbb_doc_gia.FormattingEnabled = true;
            this.cbb_doc_gia.Location = new System.Drawing.Point(28, 99);
            this.cbb_doc_gia.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbb_doc_gia.Name = "cbb_doc_gia";
            this.cbb_doc_gia.Size = new System.Drawing.Size(472, 36);
            this.cbb_doc_gia.TabIndex = 27;
            // 
            // btn_luu
            // 
            this.btn_luu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_luu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.Color.Black;
            this.btn_luu.Image = global::GUI.Properties.Resources.z5560539359592_623c956011eaad65169285dc99d41041;
            this.btn_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_luu.Location = new System.Drawing.Point(388, 146);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Padding = new System.Windows.Forms.Padding(11, 4, 4, 4);
            this.btn_luu.Size = new System.Drawing.Size(100, 33);
            this.btn_luu.TabIndex = 33;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // txt_ma_the_muon
            // 
            this.txt_ma_the_muon.BackColor = System.Drawing.SystemColors.Control;
            this.txt_ma_the_muon.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_ma_the_muon.Location = new System.Drawing.Point(28, 32);
            this.txt_ma_the_muon.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_ma_the_muon.Multiline = true;
            this.txt_ma_the_muon.Name = "txt_ma_the_muon";
            this.txt_ma_the_muon.Size = new System.Drawing.Size(472, 31);
            this.txt_ma_the_muon.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 28);
            this.label2.TabIndex = 31;
            this.label2.Text = "Mã Thẻ Mượn";
            // 
            // btn_xem
            // 
            this.btn_xem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xem.ForeColor = System.Drawing.Color.Black;
            this.btn_xem.Image = global::GUI.Properties.Resources.favicon_32x32;
            this.btn_xem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xem.Location = new System.Drawing.Point(750, 146);
            this.btn_xem.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Padding = new System.Windows.Forms.Padding(11, 4, 4, 4);
            this.btn_xem.Size = new System.Drawing.Size(100, 33);
            this.btn_xem.TabIndex = 30;
            this.btn_xem.Text = "Xem";
            this.btn_xem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xem.UseVisualStyleBackColor = true;
            this.btn_xem.Click += new System.EventHandler(this.btn_xem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(540, -1);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 28);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ngày Mượn ";
            // 
            // btn_bo_qua
            // 
            this.btn_bo_qua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bo_qua.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bo_qua.ForeColor = System.Drawing.Color.Black;
            this.btn_bo_qua.Image = global::GUI.Properties.Resources.z5560539339010_ef792d56ebbc8998d0d577435891ae63;
            this.btn_bo_qua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bo_qua.Location = new System.Drawing.Point(915, 146);
            this.btn_bo_qua.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_bo_qua.Name = "btn_bo_qua";
            this.btn_bo_qua.Padding = new System.Windows.Forms.Padding(11, 4, 4, 4);
            this.btn_bo_qua.Size = new System.Drawing.Size(121, 33);
            this.btn_bo_qua.TabIndex = 12;
            this.btn_bo_qua.Text = "Bỏ Qua";
            this.btn_bo_qua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_bo_qua.UseVisualStyleBackColor = true;
            this.btn_bo_qua.Click += new System.EventHandler(this.btn_bo_qua_Click);
            // 
            // btn_tra
            // 
            this.btn_tra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tra.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tra.ForeColor = System.Drawing.Color.Black;
            this.btn_tra.Image = global::GUI.Properties.Resources.favicon_16x161;
            this.btn_tra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tra.Location = new System.Drawing.Point(578, 146);
            this.btn_tra.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_tra.Name = "btn_tra";
            this.btn_tra.Padding = new System.Windows.Forms.Padding(11, 4, 4, 4);
            this.btn_tra.Size = new System.Drawing.Size(100, 33);
            this.btn_tra.TabIndex = 11;
            this.btn_tra.Text = "Trả";
            this.btn_tra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_tra.UseVisualStyleBackColor = true;
            this.btn_tra.Click += new System.EventHandler(this.btn_tra_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.Black;
            this.btn_sua.Image = global::GUI.Properties.Resources.z5560539359740_9337aa11269aeccd6e939ece18cfa20e;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(217, 146);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Padding = new System.Windows.Forms.Padding(11, 4, 4, 4);
            this.btn_sua.Size = new System.Drawing.Size(100, 33);
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
            this.btn_them.Location = new System.Drawing.Point(28, 146);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Padding = new System.Windows.Forms.Padding(11, 4, 4, 4);
            this.btn_them.Size = new System.Drawing.Size(100, 33);
            this.btn_them.TabIndex = 9;
            this.btn_them.Text = "Mượn";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label2222
            // 
            this.label2222.AutoSize = true;
            this.label2222.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2222.ForeColor = System.Drawing.Color.White;
            this.label2222.Location = new System.Drawing.Point(4, 69);
            this.label2222.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2222.Name = "label2222";
            this.label2222.Size = new System.Drawing.Size(81, 28);
            this.label2222.TabIndex = 2;
            this.label2222.Text = "Độc Giả";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::GUI.Properties.Resources.xanhtimdocmmm;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_dang_xuat);
            this.panel1.Controls.Add(this.btn_the_loai);
            this.panel1.Controls.Add(this.btn_ngon_ngu);
            this.panel1.Controls.Add(this.btn_muon_tra);
            this.panel1.Controls.Add(this.btn_doc_gia);
            this.panel1.Controls.Add(this.btn_kho_sach);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 729);
            this.panel1.TabIndex = 10;
            // 
            // btn_dang_xuat
            // 
            this.btn_dang_xuat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dang_xuat.Location = new System.Drawing.Point(13, 674);
            this.btn_dang_xuat.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_dang_xuat.Name = "btn_dang_xuat";
            this.btn_dang_xuat.Size = new System.Drawing.Size(189, 33);
            this.btn_dang_xuat.TabIndex = 12;
            this.btn_dang_xuat.Text = "Đăng Xuất";
            this.btn_dang_xuat.UseVisualStyleBackColor = true;
            this.btn_dang_xuat.Click += new System.EventHandler(this.btn_dang_xuat_Click);
            // 
            // btn_the_loai
            // 
            this.btn_the_loai.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_the_loai.Location = new System.Drawing.Point(12, 199);
            this.btn_the_loai.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_the_loai.Name = "btn_the_loai";
            this.btn_the_loai.Size = new System.Drawing.Size(189, 32);
            this.btn_the_loai.TabIndex = 11;
            this.btn_the_loai.Text = "Thể Loại";
            this.btn_the_loai.UseVisualStyleBackColor = true;
            this.btn_the_loai.Click += new System.EventHandler(this.btn_the_loai_Click);
            // 
            // btn_ngon_ngu
            // 
            this.btn_ngon_ngu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ngon_ngu.Location = new System.Drawing.Point(13, 151);
            this.btn_ngon_ngu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_ngon_ngu.Name = "btn_ngon_ngu";
            this.btn_ngon_ngu.Size = new System.Drawing.Size(189, 36);
            this.btn_ngon_ngu.TabIndex = 10;
            this.btn_ngon_ngu.Text = "Ngôn ngữ";
            this.btn_ngon_ngu.UseVisualStyleBackColor = true;
            this.btn_ngon_ngu.Click += new System.EventHandler(this.btn_ngon_ngu_Click);
            // 
            // btn_muon_tra
            // 
            this.btn_muon_tra.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_muon_tra.Location = new System.Drawing.Point(13, 108);
            this.btn_muon_tra.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_muon_tra.Name = "btn_muon_tra";
            this.btn_muon_tra.Size = new System.Drawing.Size(189, 34);
            this.btn_muon_tra.TabIndex = 9;
            this.btn_muon_tra.Text = "Mượn Trả";
            this.btn_muon_tra.UseVisualStyleBackColor = true;
            // 
            // btn_doc_gia
            // 
            this.btn_doc_gia.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doc_gia.Location = new System.Drawing.Point(13, 60);
            this.btn_doc_gia.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_doc_gia.Name = "btn_doc_gia";
            this.btn_doc_gia.Size = new System.Drawing.Size(189, 38);
            this.btn_doc_gia.TabIndex = 8;
            this.btn_doc_gia.Text = "Độc Giả";
            this.btn_doc_gia.UseVisualStyleBackColor = true;
            this.btn_doc_gia.Click += new System.EventHandler(this.btn_doc_gia_Click);
            // 
            // btn_kho_sach
            // 
            this.btn_kho_sach.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kho_sach.Location = new System.Drawing.Point(13, 14);
            this.btn_kho_sach.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_kho_sach.Name = "btn_kho_sach";
            this.btn_kho_sach.Size = new System.Drawing.Size(189, 36);
            this.btn_kho_sach.TabIndex = 7;
            this.btn_kho_sach.Text = "Kho Sách";
            this.btn_kho_sach.UseVisualStyleBackColor = true;
            this.btn_kho_sach.Click += new System.EventHandler(this.btn_kho_sach_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_ds_muon_tra);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(31, 225);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(1079, 194);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(236, -2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Size = new System.Drawing.Size(1137, 730);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Mượn - Trả";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_so_luong);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btn_xoa_sach);
            this.groupBox3.Controls.Add(this.btn_them_sach);
            this.groupBox3.Controls.Add(this.cbb_ten_sach);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dgv_ds_chitietmuontra);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(28, 425);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(1079, 286);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả";
            // 
            // txt_so_luong
            // 
            this.txt_so_luong.BackColor = System.Drawing.SystemColors.Control;
            this.txt_so_luong.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_so_luong.Location = new System.Drawing.Point(484, 56);
            this.txt_so_luong.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_so_luong.Multiline = true;
            this.txt_so_luong.Name = "txt_so_luong";
            this.txt_so_luong.Size = new System.Drawing.Size(421, 27);
            this.txt_so_luong.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(484, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 28);
            this.label6.TabIndex = 25;
            this.label6.Text = "Số Lượng";
            // 
            // btn_xoa_sach
            // 
            this.btn_xoa_sach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xoa_sach.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa_sach.ForeColor = System.Drawing.Color.Black;
            this.btn_xoa_sach.Image = global::GUI.Properties.Resources.z5560539339010_ef792d56ebbc8998d0d577435891ae63;
            this.btn_xoa_sach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa_sach.Location = new System.Drawing.Point(949, 75);
            this.btn_xoa_sach.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_xoa_sach.Name = "btn_xoa_sach";
            this.btn_xoa_sach.Padding = new System.Windows.Forms.Padding(11, 4, 4, 4);
            this.btn_xoa_sach.Size = new System.Drawing.Size(100, 33);
            this.btn_xoa_sach.TabIndex = 24;
            this.btn_xoa_sach.Text = "Xóa";
            this.btn_xoa_sach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa_sach.UseVisualStyleBackColor = true;
            this.btn_xoa_sach.Click += new System.EventHandler(this.btn_xoa_sach_Click);
            // 
            // btn_them_sach
            // 
            this.btn_them_sach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_them_sach.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them_sach.ForeColor = System.Drawing.Color.Black;
            this.btn_them_sach.Image = global::GUI.Properties.Resources.z5560539359591_8726bde7817e7680733c216c1b763b9d;
            this.btn_them_sach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them_sach.Location = new System.Drawing.Point(949, 31);
            this.btn_them_sach.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_them_sach.Name = "btn_them_sach";
            this.btn_them_sach.Padding = new System.Windows.Forms.Padding(11, 4, 4, 4);
            this.btn_them_sach.Size = new System.Drawing.Size(100, 33);
            this.btn_them_sach.TabIndex = 23;
            this.btn_them_sach.Text = "Thêm ";
            this.btn_them_sach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them_sach.UseVisualStyleBackColor = true;
            this.btn_them_sach.Click += new System.EventHandler(this.btn_them_sach_Click);
            // 
            // cbb_ten_sach
            // 
            this.cbb_ten_sach.BackColor = System.Drawing.SystemColors.Control;
            this.cbb_ten_sach.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbb_ten_sach.FormattingEnabled = true;
            this.cbb_ten_sach.Location = new System.Drawing.Point(28, 52);
            this.cbb_ten_sach.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbb_ten_sach.Name = "cbb_ten_sach";
            this.cbb_ten_sach.Size = new System.Drawing.Size(432, 36);
            this.cbb_ten_sach.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên Sách";
            // 
            // dgv_ds_chitietmuontra
            // 
            this.dgv_ds_chitietmuontra.AllowUserToAddRows = false;
            this.dgv_ds_chitietmuontra.AllowUserToDeleteRows = false;
            this.dgv_ds_chitietmuontra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ds_chitietmuontra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ds_chitietmuontra.Location = new System.Drawing.Point(0, 113);
            this.dgv_ds_chitietmuontra.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgv_ds_chitietmuontra.Name = "dgv_ds_chitietmuontra";
            this.dgv_ds_chitietmuontra.ReadOnly = true;
            this.dgv_ds_chitietmuontra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_ds_chitietmuontra.RowHeadersWidth = 51;
            this.dgv_ds_chitietmuontra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ds_chitietmuontra.Size = new System.Drawing.Size(1079, 169);
            this.dgv_ds_chitietmuontra.TabIndex = 0;
            this.dgv_ds_chitietmuontra.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ds_chitietmuontra_RowEnter);
            // 
            // QL_TraMuon_Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.xanhtim2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1373, 736);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "QL_TraMuon_Sach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QL_TraMuon_Sach";
            this.Load += new System.EventHandler(this.QL_TraMuon_Sach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ds_muon_tra)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ds_chitietmuontra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox txt_ngay_tra;
        private Label label4;
        private DataGridView dgv_ds_muon_tra;
        private TextBox txt_ngay_muon;
        private Panel panel2;
        private Label label5;
        private Button btn_bo_qua;
        private Button btn_tra;
        private Button btn_sua;
        private Button btn_them;
        private Label label2222;
        private Panel panel1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button btn_xem;
        private GroupBox groupBox3;
        private DataGridView dgv_ds_chitietmuontra;
        private ComboBox cbb_ten_sach;
        private Label label3;
        private TextBox txt_so_luong;
        private Label label6;
        private Button btn_xoa_sach;
        private Button btn_them_sach;
        private TextBox txt_ma_the_muon;
        private Label label2;
        private Button btn_luu;
        private ComboBox cbb_doc_gia;
        private Button btn_the_loai;
        private Button btn_ngon_ngu;
        private Button btn_muon_tra;
        private Button btn_doc_gia;
        private Button btn_kho_sach;
        private Button btn_dang_xuat;
    }
}