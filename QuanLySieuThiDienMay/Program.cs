/*
 * ten: ngo thi ngoc diem, le thanh thien, nguyen thu tuyet
 * lop: cd16tt2
 * ma so: 16211tt0449, 16211tt0473, 16211tt0881
 * giao vien: Le Tho
 * ten do an: quan ly cua hang dien may
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLySieuThiDienMay
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
