/*
 * ten: nguyen thu tuyet
 * lop: cd16tt2
 * ma so: 16211tt0881
 * giao vien: Le Tho
 * ten do an: quan ly cua hang dien may
 * phan duoc giao: Phan quan ly nhan vien va quan ly san pham
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
using System.Text.RegularExpressions;

namespace QuanLySieuThiDienMay
{
    public partial class frmQLNhanVien : Form
    {
        private frmThemNhanVien frmTNV;
        private frmMain frmM;
        public frmQLNhanVien(frmMain temp) // chuyền vào form cha
        {
            InitializeComponent();
            frmM = temp;
        }

        /// <summary>
        /// sử lý sự kiện click vào nút thêm trong form quản lý nhân viên
        /// show form Thêm quản lý nhân viên
        /// nếu form đã tồn tại thì cho form lên trên cùng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (frmTNV != null)
            {
                frmTNV.Focus();
            }
            else
            {
                frmTNV = new frmThemNhanVien(this);
                frmTNV.MdiParent = frmM; // khẳng định cha con

                frmTNV.FormClosed += new FormClosedEventHandler(frmTNV_FormClosed);

                frmTNV.Show();
            }
        }

        /// <summary>
        /// sử lý sự kiện khi tắt form Thêm quản lý nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void frmTNV_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmTNV = null;
        }
        /// <summary>
        /// Load thông tin nhân viên từ cơ sở dữ liệu lên datagidview winform
        /// </summary>
        public void Load_NhanVien()
        {
            List<NhanVien> lst = new List<NhanVien>();
            string query = "EXEC SP_LOAD_NHANVIEN";
            DataTable kq = DataProvider.ExecuteQuery(query);

            foreach (DataRow item in kq.Rows)
            {
                NhanVien tmp = new NhanVien();
                tmp.MaNV = int.Parse(item[0].ToString());
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
                
                lst.Add(tmp);
            }
            dtgvNV.DataSource = lst;
        }
        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {
           Load_NhanVien();
        }
        /// <summary>
        /// Sự kiện click khi nhấn vào button xóa
        /// Xóa tại dòng được trỏ tới
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thong Bao!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                string query = "SP_XOA_NHANVIEN @MaNV";
                object[] thamso = new object[] { txtMaNhanVien.Text };
                int kq = DataProvider.ExecuteNonQuery(query, thamso);

                if (kq > 0)
                {
                    MessageBox.Show("Ban xoa Thanh Cong", "Thong Bao!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    // them thanh cong
                    // Sau khi xoa thanh cong bo Load de no cap nhat lai du lieu
                    Load_NhanVien();
                }
                else
                {
                    MessageBox.Show("Ban Xoa That Bai", "Thong Bao!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    // them that bai
                }
            }
        }
        /// <summary>
        /// Sự kiện click để chọn dòng 
        /// Lấy số thứ tự của dòng được chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex; // Lấy số thứ tự của dòng đang được chọn

            txtMaNhanVien.Text = dtgvNV.Rows[RowIndex].Cells[0].Value.ToString();
            txtHoTenNV.Text = dtgvNV.Rows[RowIndex].Cells[1].Value.ToString();

            if(dtgvNV.Rows[RowIndex].Cells[2].Value.ToString().CompareTo("Nữ") == 0)
            {
                rbNu.Checked = true;
            }
            else
            {
                rbNam.Checked = true;
            }

            txtCMND.Text = dtgvNV.Rows[RowIndex].Cells[3].Value.ToString();
            txtDiaChi.Text = dtgvNV.Rows[RowIndex].Cells[4].Value.ToString();
            txtSDT.Text = dtgvNV.Rows[RowIndex].Cells[5].Value.ToString();
            dtpNgayVL.Value = Convert.ToDateTime(dtgvNV.Rows[RowIndex].Cells[6].Value.ToString());
            txtTaiKhoan.Text = dtgvNV.Rows[RowIndex].Cells[7].Value.ToString();
            txtMatKhau.Text = dtgvNV.Rows[RowIndex].Cells[8].Value.ToString();
            txtMucLuong.Text = dtgvNV.Rows[RowIndex].Cells[9].Value.ToString();
            txtPhuCap.Text = dtgvNV.Rows[RowIndex].Cells[10].Value.ToString();


        }
        /// <summary>
        /// Lấy dữ liệu từ SQL cập nhật lên winform
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                List<SanPham> lst = new List<SanPham>();
                string query = "EXEC SP_SUA_NHANVIEN @MaNV , @HoTenNV , @GioiTinh , @CMND , @DiaChi , @SDT , @NgayVL , @TaiKhoan , @MatKhau , @MucLuong , @PhuCap";
                object[] thamso = new object[] { txtMaNhanVien.Text, txtHoTenNV.Text, rbNu.Checked == true ? "Nữ" : "Nam", txtCMND.Text, txtDiaChi.Text, txtSDT.Text, dtpNgayVL.Text, txtTaiKhoan.Text, txtMatKhau.Text, txtMucLuong.Text, txtPhuCap.Text };
                int kq = DataProvider.ExecuteNonQuery(query, thamso);

                if (kq > 0)
                {
                    MessageBox.Show("Ban Da Cap Nhat Thanh Cong", "Thong Bao!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    // them thanh cong
                    Load_NhanVien();
                }
                else
                {
                    MessageBox.Show("Ban Cap Nhat That Bai", "Thong Bao!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    // them that bai
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtHoTenNV_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
