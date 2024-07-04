using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class form_dang_nhap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_dang_ki = new System.Windows.Forms.Label();
            this.btn_dang_nhap = new System.Windows.Forms.Button();
            this.txt_mat_khau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ten_nguoi_dung = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::GUI.Properties.Resources.xanhtimdoc;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 388);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.lb_dang_ki);
            this.panel3.Controls.Add(this.btn_dang_nhap);
            this.panel3.Controls.Add(this.txt_mat_khau);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txt_ten_nguoi_dung);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(-1, 34);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(467, 336);
            this.panel3.TabIndex = 5;
            // 
            // lb_dang_ki
            // 
            this.lb_dang_ki.AutoSize = true;
            this.lb_dang_ki.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dang_ki.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_dang_ki.Location = new System.Drawing.Point(373, 377);
            this.lb_dang_ki.Name = "lb_dang_ki";
            this.lb_dang_ki.Size = new System.Drawing.Size(110, 20);
            this.lb_dang_ki.TabIndex = 6;
            this.lb_dang_ki.Text = "Đăng Kí Tại Đây";
            // 
            // btn_dang_nhap
            // 
            this.btn_dang_nhap.BackColor = System.Drawing.Color.Transparent;
            this.btn_dang_nhap.BackgroundImage = global::GUI.Properties.Resources.xanhtim2;
            this.btn_dang_nhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dang_nhap.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_dang_nhap.Location = new System.Drawing.Point(156, 234);
            this.btn_dang_nhap.Margin = new System.Windows.Forms.Padding(0);
            this.btn_dang_nhap.Name = "btn_dang_nhap";
            this.btn_dang_nhap.Padding = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.btn_dang_nhap.Size = new System.Drawing.Size(132, 35);
            this.btn_dang_nhap.TabIndex = 0;
            this.btn_dang_nhap.Text = "Đăng Nhập";
            this.btn_dang_nhap.UseVisualStyleBackColor = false;
            this.btn_dang_nhap.Click += new System.EventHandler(this.btn_dang_nhap_Click_1);
            // 
            // txt_mat_khau
            // 
            this.txt_mat_khau.BackColor = System.Drawing.SystemColors.Control;
            this.txt_mat_khau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mat_khau.Location = new System.Drawing.Point(15, 168);
            this.txt_mat_khau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mat_khau.Multiline = true;
            this.txt_mat_khau.Name = "txt_mat_khau";
            this.txt_mat_khau.PasswordChar = '*';
            this.txt_mat_khau.Size = new System.Drawing.Size(424, 36);
            this.txt_mat_khau.TabIndex = 2;
            this.txt_mat_khau.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(13, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật Khẩu";
            // 
            // txt_ten_nguoi_dung
            // 
            this.txt_ten_nguoi_dung.BackColor = System.Drawing.SystemColors.Control;
            this.txt_ten_nguoi_dung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ten_nguoi_dung.Location = new System.Drawing.Point(15, 67);
            this.txt_ten_nguoi_dung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ten_nguoi_dung.Multiline = true;
            this.txt_ten_nguoi_dung.Name = "txt_ten_nguoi_dung";
            this.txt_ten_nguoi_dung.Size = new System.Drawing.Size(424, 36);
            this.txt_ten_nguoi_dung.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Người Dùng";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(216, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(451, 345);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng Nhập";
            // 
            // form_dang_nhap
            // 
            this.AcceptButton = this.btn_dang_nhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 388);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "form_dang_nhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label lb_dang_ki;
        private Button btn_dang_nhap;
        private TextBox txt_mat_khau;
        private Label label2;
        private TextBox txt_ten_nguoi_dung;
        private Label label1;
        private GroupBox groupBox1;
    }
}