﻿using System;
using System.Windows.Forms;

namespace GUI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new form_dang_nhap());
            Application.Run(new QL_TraMuon_Sach());

        }
    }
}
