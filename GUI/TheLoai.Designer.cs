using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class QL_The_loai
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
            this.btn_ngon_ngu = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_kho_sach = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ma_the_loai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_dang_xuat = new System.Windows.Forms.Button();
            this.btn_muon_tra = new System.Windows.Forms.Button();
            this.btn_doc_gia = new System.Windows.Forms.Button();
            this.txt_the_loai = new System.Windows.Forms.TextBox();
            this.dgv_ds_the_loai = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_the_loai = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ds_the_loai)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ngon_ngu
            // 
            this.btn_ngon_ngu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ngon_ngu.Location = new System.Drawing.Point(10, 122);
            this.btn_ngon_ngu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ngon_ngu.Name = "btn_ngon_ngu";
            this.btn_ngon_ngu.Size = new System.Drawing.Size(142, 29);
            this.btn_ngon_ngu.TabIndex = 5;
            this.btn_ngon_ngu.Text = "Ngôn ngữ";
            this.btn_ngon_ngu.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_xoa.Image = global::GUI.Properties.Resources.z5560539339010_ef792d56ebbc8998d0d577435891ae63;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(496, 119);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Padding = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btn_xoa.Size = new System.Drawing.Size(75, 27);
            this.btn_xoa.TabIndex = 5;
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
            this.btn_sua.Location = new System.Drawing.Point(269, 121);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Padding = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btn_sua.Size = new System.Drawing.Size(75, 27);
            this.btn_sua.TabIndex = 4;
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
            this.btn_them.Location = new System.Drawing.Point(45, 121);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Padding = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btn_them.Size = new System.Drawing.Size(75, 27);
            this.btn_them.TabIndex = 3;
            this.btn_them.Text = "Thêm ";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // btn_kho_sach
            // 
            this.btn_kho_sach.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kho_sach.Location = new System.Drawing.Point(10, 10);
            this.btn_kho_sach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_kho_sach.Name = "btn_kho_sach";
            this.btn_kho_sach.Size = new System.Drawing.Size(142, 29);
            this.btn_kho_sach.TabIndex = 1;
            this.btn_kho_sach.Text = "Kho Sách";
            this.btn_kho_sach.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mã";
            // 
            // txt_ma_the_loai
            // 
            this.txt_ma_the_loai.BackColor = System.Drawing.SystemColors.Control;
            this.txt_ma_the_loai.Enabled = false;
            this.txt_ma_the_loai.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_ma_the_loai.Location = new System.Drawing.Point(20, 23);
            this.txt_ma_the_loai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ma_the_loai.Multiline = true;
            this.txt_ma_the_loai.Name = "txt_ma_the_loai";
            this.txt_ma_the_loai.ReadOnly = true;
            this.txt_ma_the_loai.Size = new System.Drawing.Size(564, 23);
            this.txt_ma_the_loai.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, -25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Thêm ngôn ngữ";
            // 
            // btn_dang_xuat
            // 
            this.btn_dang_xuat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dang_xuat.Location = new System.Drawing.Point(6, 372);
            this.btn_dang_xuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dang_xuat.Name = "btn_dang_xuat";
            this.btn_dang_xuat.Size = new System.Drawing.Size(142, 27);
            this.btn_dang_xuat.TabIndex = 4;
            this.btn_dang_xuat.Text = "Đăng Xuất";
            this.btn_dang_xuat.UseVisualStyleBackColor = true;
            // 
            // btn_muon_tra
            // 
            this.btn_muon_tra.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_muon_tra.Location = new System.Drawing.Point(10, 87);
            this.btn_muon_tra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_muon_tra.Name = "btn_muon_tra";
            this.btn_muon_tra.Size = new System.Drawing.Size(142, 28);
            this.btn_muon_tra.TabIndex = 3;
            this.btn_muon_tra.Text = "Mượn Trả";
            this.btn_muon_tra.UseVisualStyleBackColor = true;
            // 
            // btn_doc_gia
            // 
            this.btn_doc_gia.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doc_gia.Location = new System.Drawing.Point(10, 48);
            this.btn_doc_gia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_doc_gia.Name = "btn_doc_gia";
            this.btn_doc_gia.Size = new System.Drawing.Size(142, 31);
            this.btn_doc_gia.TabIndex = 2;
            this.btn_doc_gia.Text = "Độc Giả";
            this.btn_doc_gia.UseVisualStyleBackColor = true;
            // 
            // txt_the_loai
            // 
            this.txt_the_loai.BackColor = System.Drawing.SystemColors.Control;
            this.txt_the_loai.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_the_loai.Location = new System.Drawing.Point(20, 81);
            this.txt_the_loai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_the_loai.Multiline = true;
            this.txt_the_loai.Name = "txt_the_loai";
            this.txt_the_loai.Size = new System.Drawing.Size(564, 23);
            this.txt_the_loai.TabIndex = 2;
            // 
            // dgv_ds_the_loai
            // 
            this.dgv_ds_the_loai.AllowUserToAddRows = false;
            this.dgv_ds_the_loai.AllowUserToDeleteRows = false;
            this.dgv_ds_the_loai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ds_the_loai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ds_the_loai.Location = new System.Drawing.Point(0, 24);
            this.dgv_ds_the_loai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_ds_the_loai.Name = "dgv_ds_the_loai";
            this.dgv_ds_the_loai.ReadOnly = true;
            this.dgv_ds_the_loai.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_ds_the_loai.RowHeadersWidth = 51;
            this.dgv_ds_the_loai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ds_the_loai.Size = new System.Drawing.Size(628, 169);
            this.dgv_ds_the_loai.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::GUI.Properties.Resources.xanhtimdocmmm;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_the_loai);
            this.panel1.Controls.Add(this.btn_ngon_ngu);
            this.panel1.Controls.Add(this.btn_dang_xuat);
            this.panel1.Controls.Add(this.btn_muon_tra);
            this.panel1.Controls.Add(this.btn_doc_gia);
            this.panel1.Controls.Add(this.btn_kho_sach);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 420);
            this.panel1.TabIndex = 8;
            // 
            // btn_the_loai
            // 
            this.btn_the_loai.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_the_loai.Location = new System.Drawing.Point(9, 161);
            this.btn_the_loai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_the_loai.Name = "btn_the_loai";
            this.btn_the_loai.Size = new System.Drawing.Size(142, 26);
            this.btn_the_loai.TabIndex = 6;
            this.btn_the_loai.Text = "Thể Loại";
            this.btn_the_loai.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_ma_the_loai);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_xoa);
            this.panel2.Controls.Add(this.btn_sua);
            this.panel2.Controls.Add(this.btn_them);
            this.panel2.Controls.Add(this.txt_the_loai);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(21, 35);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 158);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thêm Thể Loại";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_ds_the_loai);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(21, 197);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(632, 193);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(184, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(678, 409);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thể Loại";
            // 
            // QL_The_loai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.xanhtim2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(863, 424);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QL_The_loai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TheLoai";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ds_the_loai)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_ngon_ngu;
        private Button btn_xoa;
        private Button btn_sua;
        private Button btn_them;
        private Button btn_kho_sach;
        private Label label3;
        private TextBox txt_ma_the_loai;
        private Label label2;
        private Button btn_dang_xuat;
        private Button btn_muon_tra;
        private Button btn_doc_gia;
        private TextBox txt_the_loai;
        private DataGridView dgv_ds_the_loai;
        private Panel panel1;
        private Button btn_the_loai;
        private Panel panel2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
    }
}