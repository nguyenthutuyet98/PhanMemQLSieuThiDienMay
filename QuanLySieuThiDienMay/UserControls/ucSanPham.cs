using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLySieuThiDienMay.DTO;

namespace QuanLySieuThiDienMay.UserControls
{
    public partial class ucSanPham : UserControl
    {
        private SanPham sp = null;

        public SanPham Sp
        {
            get { return sp; }
            set { sp = value; }
        }

        public ucSanPham(SanPham temp)
        {
            InitializeComponent();

            sp = temp;

            if (Sp.TenSP.Length > 27)
            {
                lblTenSP.Text = Sp.TenSP.Substring(0, 27) + "...";
            }
            else
            {
                lblTenSP.Text = Sp.TenSP;
            }

            lblGiaBan.Text = Sp.GiaBan.ToString();

            this.Tag = Sp.MaSP;
        }


        private void ucSanPham_Load(object sender, EventArgs e)
        {
            try
            {
                //picbIMG.Image = new Bitmap(Image.FromFile(Application.StartupPath + @"\" + Sp.HinhAnh), 130, 130);
                picbIMG.ImageLocation = Application.StartupPath + @"\" + Sp.HinhAnh;
            }
            catch (System.IO.FileNotFoundException ex)
            {
                //picbIMG.Image = new Bitmap(Image.FromFile(Application.StartupPath + @"\imgSanPham\no_picture.png"), 130, 130);
                picbIMG.ImageLocation = Application.StartupPath + @"\imgSanPham\no_picture.png";
            }

        }

        private void lblGiaBan_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void lblTenSP_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void picbIMG_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void ucSanPham_Click(object sender, EventArgs e)
        {

        }

    }
}
