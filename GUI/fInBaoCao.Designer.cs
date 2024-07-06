namespace GUI
{
    partial class fInBaoCao
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
            this.baoCaoRV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // baoCaoRV
            // 
            this.baoCaoRV.ActiveViewIndex = -1;
            this.baoCaoRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.baoCaoRV.Cursor = System.Windows.Forms.Cursors.Default;
            this.baoCaoRV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baoCaoRV.Location = new System.Drawing.Point(0, 0);
            this.baoCaoRV.Name = "baoCaoRV";
            this.baoCaoRV.Size = new System.Drawing.Size(800, 450);
            this.baoCaoRV.TabIndex = 0;
            // 
            // fInBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.baoCaoRV);
            this.Name = "fInBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fInBaoCao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fInBaoCao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer baoCaoRV;
    }
}