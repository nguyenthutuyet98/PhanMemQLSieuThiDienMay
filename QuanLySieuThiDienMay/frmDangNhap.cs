/*
 * ten: ngo thi ngoc diem
 * lop: cd16tt2
 * ma so: 16211tt0449
 * giao vien: Le Tho
 * ten do an: quan ly cua hang dien may
 * phan duoc giao: Viet CSDL chung, phan Dang nhap va Thong ke bao cao
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLySieuThiDienMay.DTO; // thu vien cho DataProvider: la 1 tien ich giup thao tac tren csdl 


namespace QuanLySieuThiDienMay
{
    public partial class frmDangNhap : Form
    {
        List<NhanVien> lst;
        MenuStrip mnsMain, mnsTemp;

        /// <summary>
        /// form đăng nhập 
        /// 
        /// </summary>
        /// <param name="mnsMain"></param>
        /// <param name="mnsTemp"></param>
        public frmDangNhap(MenuStrip mnsMain, MenuStrip mnsTemp)
        {
            InitializeComponent();

            this.mnsMain = mnsMain;
            this.mnsTemp = mnsTemp;
        }

        /// <summary>
        /// Hàm dùng để Load danh sach nhan vien
        /// Thông báo khi chưa đăng nhập tài khoản, mật khẩu
        /// Thực hiện kết nối CSDL
        /// Thực hiện các câu truy vấn
        /// Đổ DL lên
        /// Thực hiện kiểm tra xem dữ liệu nhập vào có khớp với dữ liệu gốc hay không
        /// Thông báo khi đăng nhập thất bại
        /// </summary>
        void LoadDSNhanVien()
        {
            // kiem tra ten dang nhap
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản!", "Thông báo!");
                return; // neu ko nhap thoat khoi ham
            }

            // kiem tra mat khau
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!", "Thông báo!");
                return;
            }

            // Tao list ds NV moi
            lst = new List<NhanVien>();

            string query = "EXEC SP_LOAD_NHANVIEN"; // cau truy van de load du lieu len
            DataTable data = DataProvider.ExecuteQuery(query);


            // tien hanh do du lieu
            foreach (DataRow item in data.Rows)
            {
                NhanVien tmp = new NhanVien();

                tmp.MaNV = Int32.Parse(item[0].ToString());
                tmp.HoTen = item[1].ToString();
                tmp.GioiTinh = item[2].ToString();
                tmp.CMND = item[3].ToString();
                tmp.DiaChi = item[4].ToString();
                tmp.SoDT = item[5].ToString();
                tmp.NgayVL = Convert.ToDateTime(item[6].ToString());
                tmp.TaiKhoan = item[7].ToString();
                tmp.MatKhau = item[8].ToString();
                tmp.MucLuong = double.Parse(item[9].ToString());
                tmp.PhuCap = double.Parse(item[10].ToString());

                lst.Add(tmp); // them cac cot vao


            }
            bool isFound = false; // Tao 1 bien kiem tra
            for (int i = 0; i < lst.Count; i++) // duyet mang ds tai khoan
            {
                if (txtTaiKhoan.Text == lst[i].TaiKhoan && txtMatKhau.Text == lst[i].MatKhau) // so sanh du lieu nhap vao co ktrung voil dl da co hay khong
                {
                    MessageBox.Show("Bạn đã đăng nhập thành công!");
                    isFound = true;
                    mnsMain.Visible = true; // hien len bang menu chua cac chuc nang
                    mnsTemp.Visible = false; // an cai form dang nhap di

                    ((frmMain)this.MdiParent).setNhanVienDangNhap(lst[i]);

                    this.Close(); // dong form dang nhap
                }
            }
            if (isFound == false)
            {
                MessageBox.Show("Đăng nhập thất bại!", "Thông báo lỗi", MessageBoxButtons.OKCancel);
            }

            // dua con tro chuot vao textbox dau tien khi chay chuong trinh ma khong can tro chuot
            txtTaiKhoan.Focus();
        }

        // xu ly trong nut button dang nhap
       
        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            LoadDSNhanVien();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

    }
}
