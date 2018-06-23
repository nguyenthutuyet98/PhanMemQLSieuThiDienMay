/*
 * ten cac sv: ngo thi ngoc diem, nguyen thu tuyet, le thanh thien
 * lop: cd16tt2
 * ma so: 16211tt0449, 16211tt0881, 16211tt0473
 * giao vien: Le Tho
 * ten do an: quan ly cua hang dien may
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLySieuThiDienMay.DTO;

namespace QuanLySieuThiDienMay
{
    public partial class frmMain : Form
    {
        private frmBanHang frmBH;
        private frmQLNhanVien frmQLNV;
        private frmQLSanPham frmQLSP;
        private frmBaoCaoDTTheoNhanVien frmTKNV;
        private frmBaoCaoDTTheoThoiGian frmTKTG;
        private NhanVien currentNV;

        public NhanVien CurrentNV
        {
            get { return currentNV; }
            set { currentNV = value; }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        public void setNhanVienDangNhap(NhanVien nv)
        {
            currentNV = nv;

            sttThongTin.Text = nv.HoTen;
        }

        // kiem tra xem form con da hien thi trong form cha chua
        private bool CheckExitsForm(String name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)// voi MdiChildren tra ve tap form con dang hien thi trong form cha
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        // hien thi len tren cung cac form con da goi
        private void ActiveChildForm(String name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void dangnhapToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //mnsTemp.Visible = false;
            //mnsMain.Visible = true;
            if (!CheckExitsForm("frmDangNhap"))
            {
                frmDangNhap frm = new frmDangNhap(mnsMain, mnsTemp);
                frm.MdiParent = this; // voi MdiParent: thiet lap form cha cho cac form con la frmMain
                frm.Show();
            }
            else
            {
                ActiveChildForm("frmDangNhap");
            }
        }

        /// <summary>
        /// sử lý sự kiện click vào menu bán hàng
        /// show form bán hàng
        /// nếu form đã tồn tại thì cho form lên trên cùng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void banghangToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (var item in this.MdiChildren)
            {
                item.Hide();
            }

            if (frmBH != null)
            {
                

                frmBH.Focus();
            }
            else
            { 
                frmBH = new frmBanHang(CurrentNV);
                frmBH.MdiParent = this;

                frmBH.FormClosed += new FormClosedEventHandler(frmBH_FormClosed);
                
                

                frmBH.Show();
            }
        }

        /// <summary>
        /// sử lý sự kiện khi tắt form Thống kê theo thời gian
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void frmBH_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmBH = null;
        }

        /// <summary>
        /// sử lý sự kiện click vào menu Thống kê theo thời gian
        /// show form Thống kê theo thời gian
        /// nếu form đã tồn tại thì cho form lên trên cùng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void thongketheoTGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in this.MdiChildren)
            {
                item.Hide();
            }

            if (frmTKTG != null)
            {
                frmTKTG.Focus();
            }
            else
            {
                frmTKTG = new frmBaoCaoDTTheoThoiGian();
                frmTKTG.MdiParent = this;

                frmTKTG.FormClosed += new FormClosedEventHandler(frmTKTG_FormClosed);

                frmTKTG.Show();
            }
        }

        /// <summary>
        /// sử lý sự kiện khi tắt form Thống kê theo thời gian
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void frmTKTG_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmTKTG = null;
        }

        /// <summary>
        /// sử lý sự kiện click vào menu Thống kê theo nhân viên
        /// show form Thống kê theo nhân viên
        /// nếu form đã tồn tại thì cho form lên trên cùng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void thongketheoNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in this.MdiChildren)
            {
                item.Hide();
            }

            if (frmTKNV != null)
            {
                frmTKNV.Focus();
            }
            else
            { 
                frmTKNV = new frmBaoCaoDTTheoNhanVien();
                frmTKNV.MdiParent = this;

                frmTKNV.FormClosed += new FormClosedEventHandler(frmTKNV_FormClosed);

                frmTKNV.Show();
            }
        }

        /// <summary>
        /// sử lý sự kiện khi tắt form Thống kê theo nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void frmTKNV_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmTKNV = null;
        }

        /// <summary>
        /// sử lý sự kiện click vào menu quản lý sản phẩm 
        /// show form quản lý sản phẩm
        /// nếu form đã tồn tại thì cho form lên trên cùng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quanlysanphamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in this.MdiChildren)
            {
                item.Hide();
            }

            if (frmQLSP != null)
            {
                frmQLSP.Focus();
            }
            else
            { 
                frmQLSP = new frmQLSanPham(this);
                frmQLSP.MdiParent = this;

                frmQLSP.FormClosed += new FormClosedEventHandler(frmQLSP_FormClosed);

                frmQLSP.Show();
            }
        }

        /// <summary>
        /// sử lý sự kiện khi tắt form quản lý sản phẩm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void frmQLSP_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmQLSP = null;

            foreach (var item in this.MdiChildren)
	        {
                if (item.Name.CompareTo("frmThemSanPham") == 0)
                {
                    item.Close();
                }
	        } 
        }

        /// <summary>
        /// sử lý sự kiện click vào menu quản lý nhân viên 
        /// show form quản lý nhân viên
        /// nếu form đã tồn tại thì cho form lên trên cùng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quanlynhanvienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in this.MdiChildren)
            {
                item.Hide();
            }

            if (frmQLNV != null)
            {
                frmQLNV.Focus();
            }
            else
            { 
                frmQLNV = new frmQLNhanVien(this);
                frmQLNV.MdiParent = this;

                frmQLNV.FormClosed += new FormClosedEventHandler(frmQLNV_FormClosed);

                frmQLNV.Show();
            }
        }

        /// <summary>
        /// sử lý sự kiện khi tắt form quản lý nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void frmQLNV_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmQLNV = null;

            foreach (var item in this.MdiChildren)
            {
                if (item.Name.CompareTo("frmThemQuanLyNhanVien") == 0)
                {
                    item.Close();
                }
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// khẳng định có muốn thoát hay không ở nút thoát của menu chưa đăng nhập
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("bạn có muốn thoát ?????", "Siêu Thị Điện Máy ???", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();    
            }
            
        }

        /// <summary>
        /// khẳng định có muốn thoát hay không ở nút thoát của menu đã đăng nhập
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void thoatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có muốn thoát ?????", "Siêu Thị Điện Máy ???", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// xử lý khi click đăng xuất
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dangxuatToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (var item in this.MdiChildren)
            {
                item.Hide();
            }
            mnsMain.Visible = false;
            
            mnsTemp.Visible = true;
            sttThongTin.Text = "";
        }

        /// <summary>
        /// khẳng định muốn tắt hay không cho nút x của formMain
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("bạn có muốn thoát ?????", "Siêu Thị Điện Máy ???", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }


    }
}
