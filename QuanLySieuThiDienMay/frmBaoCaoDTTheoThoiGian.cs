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
using QuanLySieuThiDienMay.DTO;// thu vien cho DataProvider: la 1 tien ich giup thao tac tren csdl 
using System.Drawing.Printing;

namespace QuanLySieuThiDienMay
{
    public partial class frmBaoCaoDTTheoThoiGian : Form
    {
        List<HoaDon> lstHD;
        List<CTHoaDon> lstCTHD;

        public frmBaoCaoDTTheoThoiGian()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Hàm dùng để Load danh sach hóa đơn
        /// Thông báo khi chưa đăng nhập tài khoản, mật khẩu
        /// Thực hiện kết nối CSDL
        /// Thực hiện các câu truy vấn
        /// Đổ DL lên
        /// Thực hiện kiểm tra xem dữ liệu nhập vào có khớp với dữ liệu gốc hay không
        /// Thông báo khi đăng nhập thất bại
        /// </summary>
        void LoadDSHoaDon()
        {
            // Tao list ds Hóa đơn mới
            lstHD = new List<HoaDon>();

            string query = "EXEC SP_LOAD_DTTHEOTHOIGIAN @NgayBatDau , @NgayKetThuc"; // Thực hiện try vấn để kết nối CSDL
            object[] thamso = new object[] { dtpNgayBatDau.Value, dtpNgayKetThuc.Value }; //là 2 giá trị tương đương vs 2 biến @ trên

            DataTable data = DataProvider.ExecuteQuery(query, thamso);
            double Tong = 0;

            // tiến hành đổ DL
            foreach (DataRow item in data.Rows)
            {
                HoaDon tmp = new HoaDon();

                tmp.SoHD = Int32.Parse(item[0].ToString());
                tmp.NgayLap = Convert.ToDateTime(item[1].ToString());
                tmp.MaNV = Int32.Parse(item[2].ToString());
                tmp.TongTien = double.Parse(item[3].ToString());

                Tong = Tong + tmp.TongTien;

                lstHD.Add(tmp);
            }

            // tính tổng tiền và tổng hóa đơn
            txtTongTien.Text = Tong.ToString();
            txtTongOrder.Text = lstHD.Count.ToString();

            dtgvHoaDon.DataSource = lstHD;

            // dua con tro chuot vao textbox dau tien khi chay chuong trinh ma khong can tro chuot
            dtpNgayBatDau.Focus();
        }

        /// <summary>
        /// Hàm dùng để Load danh sách Tìm kiếm
        /// Thông báo khi chưa đăng nhập tài khoản, mật khẩu
        /// Thực hiện kết nối CSDL
        /// Thực hiện các câu truy vấn
        /// Đổ DL lên
        /// Thực hiện kiểm tra xem dữ liệu nhập vào có khớp với dữ liệu gốc hay không
        /// Thông báo khi đăng nhập thất bại
        /// </summary>

        void LoadDSTimKiem()
        {
            // kiểm tra truong du lieu co trong khong
            if (txtTim.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập từ khóa cần tìm!", "Thông báo!");
                return; // neu ko nhap thoat khoi ham
            }

            try
            {
                lstHD = new List<HoaDon>();

                string query = "SELECT * FROM HOADON WHERE SoHD LIKE '%" + txtTim.Text + "%'";
                object[] thamso = new object[] { txtTim.Text };

                DataTable data = DataProvider.ExecuteQuery(query, thamso);

                foreach (DataRow item in data.Rows)
                {
                    HoaDon tmp = new HoaDon();

                    tmp.SoHD = Int32.Parse(item[0].ToString());
                    tmp.NgayLap = Convert.ToDateTime(item[1].ToString());
                    tmp.MaNV = Int32.Parse(item[2].ToString());
                    tmp.TongTien = double.Parse(item[3].ToString());

                    lstHD.Add(tmp);
                }

                

                dtgvHoaDon.DataSource = lstHD;

                // truong hop nhap vao so HD khong khop voi du lieu
                if (lstHD.Count == 0)
                {
                    MessageBox.Show("Không tồn tại số HĐ này trong Ds!", "Thông báo lỗi", MessageBoxButtons.OKCancel);
                    return;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show (e.Message);// "Không tồn tại hóa đơn nào có số HĐ cần tìm trong danh sách!", "Thông báo", MessageBoxButtons.OKCancel);
            }
 
        }
        // load danh sach hoa don trong button xem chi tiet
        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            LoadDSHoaDon();
        }

        /// <summary>
        /// khẳng định muốn tắt hay không cho nút x của formBCDTTheoThoiGian
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void frmBaoCaoDTTheoThoiGian_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("bạn có muốn thoát ?????", "Siêu Thị Điện Máy ???", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
       
        // load ds tim kiem trong button Tim
        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadDSTimKiem();
        }
        /// <summary>
        /// rang buoc cho su kien ấn phím 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// rang buoc cho su kien chuột nhấp nháy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true; // ham de ngan chan su kien keypress xay ra, tuc la ngan chan phim do thuc thi

            }
        }

        /// <summary>
        /// phuong thuc xu ly su kien: Thay doi gia tri cua datetimepicker Ngay bat dau, cho no khong duoc lon hon Ngay ket thuc 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpNgayBatDau_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNgayBatDau.Value.Date.CompareTo(dtpNgayKetThuc.Value.Date) > 0)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc");

                dtpNgayBatDau.Value = dtpNgayKetThuc.Value;
            }
        }

        /// <summary>
        /// phuong thuc xu ly su kien: Thay doi gia tri cua datetimepicker Ngay ket thuc, khong duoc nho hon Ngay bat dau.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpNgayKetThuc_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNgayKetThuc.Value.Date.CompareTo(dtpNgayBatDau.Value.Date) < 0)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu");

                dtpNgayKetThuc.Value = dtpNgayBatDau.Value;
            }
        }

        /// <summary>
        /// Hàm xử lý sự kiện khi click vào 1 ô trên dtgvHD.
        /// Thực hiện load chi tiết hóa đơn đó. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lstCTHD = new List<CTHoaDon>();
            int RowIndex = e.RowIndex; // khi click vao 1 o no lay ds o do

            int SoHD = int.Parse(dtgvHoaDon.Rows[RowIndex].Cells[0].Value.ToString()); // lay gia tri cua o do

            string query = "EXEC SP_LOAD_CTHD @SoHD";
            object[] thamso = new object[] {SoHD.ToString()}; //là giá trị tương đương vs biến @ trên

            DataTable data = DataProvider.ExecuteQuery(query, thamso);

            foreach (DataRow item in data.Rows)
            {
                CTHoaDon tmp = new CTHoaDon();

                tmp.SoHD = Int32.Parse(item[1].ToString());
                tmp.MaSP = Int32.Parse(item[2].ToString());
                tmp.GiaBan = double.Parse(item[3].ToString());
                tmp.SoLuong = Int32.Parse(item[4].ToString());
                tmp.ThanhTien = double.Parse(item[5].ToString());

                lstCTHD.Add(tmp);
            }
            dtgvCTHD.DataSource = lstCTHD;
        }
         
        /// <summary>
        /// In hóa đơn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInHD_Click(object sender, EventArgs e)
        {
            PrintDialog _PrintDialog = new PrintDialog();
            PrintDocument _PrintDocument = new PrintDocument();

            _PrintDialog.Document = _PrintDocument; //add the document to the dialog box

            _PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(_CreateReceipt);
            DialogResult result = _PrintDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                _PrintDocument.Print();
            }
        }

        /// <summary>
        /// Hàm xử lý sự kiện tạo hóa đơn để in.
        /// Sử dụng thư viện đồ họa Graphic để vẽ hóa đơn.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void _CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 10);
            float FontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 20;

            graphic.DrawString("Siêu Thị Điện Máy", new Font("Courier New", 16), new SolidBrush(Color.Black), startX + 50, startY);
            offset = offset + (int)FontHeight + 10;

            graphic.DrawString("        Tel: (08) 12345678", new Font("Courier New", 8, FontStyle.Italic), new SolidBrush(Color.Black), startX + 30, startY + offset);

            offset = offset + (int)FontHeight + 10;
            graphic.DrawString("    Nhân viên: " + ((frmMain)this.MdiParent).CurrentNV.HoTen, font, new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + (int)FontHeight + 10;
            graphic.DrawString("    Mã order: " + txtTim.Text, font, new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + (int)FontHeight + 10;
            graphic.DrawString("    Ngày lập: " + DateTime.Now, font, new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + (int)FontHeight + 15;
            string top = "    Sản phẩm".PadRight(12) + "   SL".PadRight(13) /*+ "Đơn giá".PadRight(9)*/ + "  Thành Tiền";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight; //make the spacing consistent
            graphic.DrawString("    -----------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + (int)FontHeight + 10;
            int index = 0;
            foreach (DataGridViewRow item in dtgvCTHD.Rows)
            {
                graphic.DrawString(Convert.ToString(item.Cells[1].Value), font, new SolidBrush(Color.Black), startX + 35, startY + offset);
                graphic.DrawString(Convert.ToString(item.Cells[3].Value), font, new SolidBrush(Color.Black), startX + 125, startY + offset);
                //graphic.DrawString(Convert.ToInt64(item.Cells[3].Value).ToString("#,###", cul), font, new SolidBrush(Color.Black), startX + 148, startY + offset);
                graphic.DrawString(Convert.ToInt64(item.Cells[4].Value).ToString(), font, new SolidBrush(Color.Black), startX + 229, startY + offset);
                offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            }
            offset = offset - 1 - (int)FontHeight + 5;
            graphic.DrawString("    -----------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + 12;
            graphic.DrawString("    TỔNG TIỀN ", font, new SolidBrush(Color.Black), startX, startY + offset);

            if (txtTongTien.Text.Length == 6)
            {
                graphic.DrawString(txtTongTien.Text, new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX + 239, startY + offset);
            }
            else
            {
                graphic.DrawString(txtTongTien.Text, new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX + 231, startY + offset);
            }

            offset = offset + (int)FontHeight + 10;

            graphic.DrawString("Hẹn gặp lại!", new Font("Courier New", 12, FontStyle.Italic), new SolidBrush(Color.Black), startX + 95, startY + offset);

        }

        private void frmBaoCaoDTTheoThoiGian_Load(object sender, EventArgs e)
        {

        }
        
    }
}
