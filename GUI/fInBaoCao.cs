using BUS;
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
    public partial class fInBaoCao : Form
    {
        public fInBaoCao()
        {
            InitializeComponent();
        }


        public void Loads()
        {
            Sach_RPT sVReport1 = new Sach_RPT();
            sVReport1.SetDataSource(SachBUS.ds_sach());
            crystalReportViewer1.ReportSource = sVReport1;
        }

        private void fInBaoCao_Load(object sender, EventArgs e)
        {
            Loads();
        }
    }
}
