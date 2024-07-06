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
            RPT_Sach sVReport1 = new RPT_Sach();
            sVReport1.SetDataSource(SachBUS.ds_sach());
            baoCaoRV.ReportSource = sVReport1;
        }

        private void fInBaoCao_Load(object sender, EventArgs e)
        {
            Loads();
        }
    }
}
