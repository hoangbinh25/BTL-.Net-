using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class Tim_kiem
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
            this.dgv_ds_tim_kiem = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_dang_xuat = new System.Windows.Forms.Button();
            this.btn_muon_tra = new System.Windows.Forms.Button();
            this.btn_doc_gia = new System.Windows.Forms.Button();
            this.btn_kho_sach = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_the_loai = new System.Windows.Forms.Button();
            this.btn_ngon_ngu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_tim_kiem = new System.Windows.Forms.Button();
            this.txt_tim_kiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ds_tim_kiem)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_ds_tim_kiem
            // 
            this.dgv_ds_tim_kiem.AllowUserToAddRows = false;
            this.dgv_ds_tim_kiem.AllowUserToDeleteRows = false;
            this.dgv_ds_tim_kiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ds_tim_kiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ds_tim_kiem.Location = new System.Drawing.Point(-13, 28);
            this.dgv_ds_tim_kiem.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgv_ds_tim_kiem.Name = "dgv_ds_tim_kiem";
            this.dgv_ds_tim_kiem.ReadOnly = true;
            this.dgv_ds_tim_kiem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_ds_tim_kiem.RowHeadersWidth = 51;
            this.dgv_ds_tim_kiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ds_tim_kiem.Size = new System.Drawing.Size(1121, 457);
            this.dgv_ds_tim_kiem.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_ds_tim_kiem);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(33, 140);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(1108, 473);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // btn_dang_xuat
            // 
            this.btn_dang_xuat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dang_xuat.Location = new System.Drawing.Point(11, 583);
            this.btn_dang_xuat.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_dang_xuat.Name = "btn_dang_xuat";
            this.btn_dang_xuat.Size = new System.Drawing.Size(189, 36);
            this.btn_dang_xuat.TabIndex = 4;
            this.btn_dang_xuat.Text = "Đăng Xuất";
            this.btn_dang_xuat.UseVisualStyleBackColor = true;
            this.btn_dang_xuat.Click += new System.EventHandler(this.btn_dang_xuat_Click_1);
            // 
            // btn_muon_tra
            // 
            this.btn_muon_tra.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_muon_tra.Location = new System.Drawing.Point(13, 108);
            this.btn_muon_tra.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_muon_tra.Name = "btn_muon_tra";
            this.btn_muon_tra.Size = new System.Drawing.Size(189, 39);
            this.btn_muon_tra.TabIndex = 3;
            this.btn_muon_tra.Text = "Mượn Trả";
            this.btn_muon_tra.UseVisualStyleBackColor = true;
            this.btn_muon_tra.Click += new System.EventHandler(this.btn_muon_tra_Click);
            // 
            // btn_doc_gia
            // 
            this.btn_doc_gia.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doc_gia.Location = new System.Drawing.Point(13, 54);
            this.btn_doc_gia.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_doc_gia.Name = "btn_doc_gia";
            this.btn_doc_gia.Size = new System.Drawing.Size(189, 39);
            this.btn_doc_gia.TabIndex = 2;
            this.btn_doc_gia.Text = "Độc Giả";
            this.btn_doc_gia.UseVisualStyleBackColor = true;
            this.btn_doc_gia.Click += new System.EventHandler(this.btn_doc_gia_Click);
            // 
            // btn_kho_sach
            // 
            this.btn_kho_sach.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kho_sach.Location = new System.Drawing.Point(13, 9);
            this.btn_kho_sach.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_kho_sach.Name = "btn_kho_sach";
            this.btn_kho_sach.Size = new System.Drawing.Size(189, 37);
            this.btn_kho_sach.TabIndex = 1;
            this.btn_kho_sach.Text = "Kho Sách";
            this.btn_kho_sach.UseVisualStyleBackColor = true;
            this.btn_kho_sach.Click += new System.EventHandler(this.btn_kho_sach_Click);
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
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 633);
            this.panel1.TabIndex = 6;
            // 
            // btn_the_loai
            // 
            this.btn_the_loai.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_the_loai.Location = new System.Drawing.Point(13, 212);
            this.btn_the_loai.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_the_loai.Name = "btn_the_loai";
            this.btn_the_loai.Size = new System.Drawing.Size(189, 36);
            this.btn_the_loai.TabIndex = 8;
            this.btn_the_loai.Text = "Thể Loại";
            this.btn_the_loai.UseVisualStyleBackColor = true;
            this.btn_the_loai.Click += new System.EventHandler(this.btn_the_loai_Click);
            // 
            // btn_ngon_ngu
            // 
            this.btn_ngon_ngu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ngon_ngu.Location = new System.Drawing.Point(13, 160);
            this.btn_ngon_ngu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_ngon_ngu.Name = "btn_ngon_ngu";
            this.btn_ngon_ngu.Size = new System.Drawing.Size(188, 37);
            this.btn_ngon_ngu.TabIndex = 6;
            this.btn_ngon_ngu.Text = "Ngôn ngữ";
            this.btn_ngon_ngu.UseVisualStyleBackColor = true;
            this.btn_ngon_ngu.Click += new System.EventHandler(this.btn_ngon_ngu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(236, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Size = new System.Drawing.Size(1161, 634);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Nhanh";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_tim_kiem);
            this.panel2.Controls.Add(this.txt_tim_kiem);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(33, 43);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1107, 93);
            this.panel2.TabIndex = 0;
            // 
            // btn_tim_kiem
            // 
            this.btn_tim_kiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tim_kiem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim_kiem.ForeColor = System.Drawing.Color.Black;
            this.btn_tim_kiem.Image = global::GUI.Properties.Resources.favicon_16x16;
            this.btn_tim_kiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tim_kiem.Location = new System.Drawing.Point(905, 36);
            this.btn_tim_kiem.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_tim_kiem.Name = "btn_tim_kiem";
            this.btn_tim_kiem.Padding = new System.Windows.Forms.Padding(11, 4, 4, 4);
            this.btn_tim_kiem.Size = new System.Drawing.Size(125, 32);
            this.btn_tim_kiem.TabIndex = 30;
            this.btn_tim_kiem.Text = "Tìm Kiếm";
            this.btn_tim_kiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_tim_kiem.UseVisualStyleBackColor = true;
            this.btn_tim_kiem.Click += new System.EventHandler(this.btn_tim_kiem_Click_1);
            // 
            // txt_tim_kiem
            // 
            this.txt_tim_kiem.BackColor = System.Drawing.SystemColors.Control;
            this.txt_tim_kiem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_tim_kiem.Location = new System.Drawing.Point(19, 36);
            this.txt_tim_kiem.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_tim_kiem.Multiline = true;
            this.txt_tim_kiem.Name = "txt_tim_kiem";
            this.txt_tim_kiem.Size = new System.Drawing.Size(848, 32);
            this.txt_tim_kiem.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cụm Từ Tìm Kiếm";
            // 
            // Tim_kiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.xanhtim2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1389, 636);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Tim_kiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tim_kiem";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ds_tim_kiem)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dgv_ds_tim_kiem;
        private GroupBox groupBox2;
        private Button btn_dang_xuat;
        private Button btn_muon_tra;
        private Button btn_doc_gia;
        private Button btn_kho_sach;
        private Panel panel1;
        private GroupBox groupBox1;
        private Button btn_ngon_ngu;
        private Panel panel2;
        private Button btn_tim_kiem;
        private TextBox txt_tim_kiem;
        private Label label1;
        private Button btn_the_loai;
    }
}