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

namespace QuanLySieuThiDienMay
{
    public partial class frmThemNhanVien : Form
    {
        private frmQLNhanVien frmQLNV;

        public frmThemNhanVien(frmQLNhanVien frm)
        {
            InitializeComponent();
            frmQLNV = frm;
        }
        /// <summary>
        /// Bắt sự kiện ràng buộc các thuộc tính khi nhấn nút thêm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            // Lỗi bỏ trống ô nhập
            if (txtHoTenNV.Text == "")
            {
                MessageBox.Show(" Vui lòng nhập vào ô Họ Tên!! ", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // return bởi vì không muốn code chạy khi nhấn nút thêm 
            }
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show(" Vui lòng nhập vào ô Tài Khoản!! ", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // return bởi vì không muốn code chạy khi nhấn nút thêm 
            }
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show(" Vui lòng nhập vào ô Mật Khẩu!! ", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // return bởi vì không muốn code chạy khi nhấn nút thêm 
            }
            if (txtSoDT.Text == "")
            {
                MessageBox.Show(" Vui lòng nhập vào ô Số ĐT!! ", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // return bởi vì không muốn code chạy khi nhấn nút thêm 
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show(" Vui lòng nhập vào ô Địa chỉ!! ", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // return bởi vì không muốn code chạy khi nhấn nút thêm 
            }
            if (txtCMND.Text == "")
            {
                MessageBox.Show(" Vui lòng nhập vào ô CMND!! ", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // return bởi vì không muốn code chạy khi nhấn nút thêm 
            }
            if (txtMucLuong.Text == "")
            {
                MessageBox.Show(" Vui lòng nhập vào ô Mức lương!! ", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // return bởi vì không muốn code chạy khi nhấn nút thêm 
            }
            if (txtPhuCap.Text == "")
            {
                MessageBox.Show(" Vui lòng nhập vào ô Phụ cấp!! ", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // return bởi vì không muốn code chạy khi nhấn nút thêm 
            }

            if (txtHoTenNV.Text.Length > 30)
            {
                MessageBox.Show(" Bạn đã nhập quá kí tự cho phép cho Họ tên (HoTenNV VARCHAR(30)) ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtSoDT.Text.Length < 10 || txtSoDT.Text.Length > 11)
            {
                MessageBox.Show(" Bạn đã nhập quá kí tự cho phép cho Số ĐT!!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Int32.Parse(txtSoDT.Text[0].ToString()) != 0)
            {
                MessageBox.Show(" Số đầu tiên trong ô ĐT phải bắt đầu là số 0! ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtCMND.Text.Length > 9)
            {
                MessageBox.Show(" Bạn đã nhập quá kí tự cho phép trong ô CMND!!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (rbNu.Checked != true)
            {
                if (rbNam.Checked != true)
                {
                    MessageBox.Show(" Bạn chưa có checked vào trường giới tính nào!! ", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            string query = "EXEC SP_THEM_NHANVIEN @HoTenNV , @GioiTinh , @CMND , @DiaChi , @SDT , @NgayVL , @TaiKhoan , @MatKhau , @MucLuong , @PhuCap";
            object[] thamso = new object[] { txtHoTenNV.Text, rbNu.Checked == true ? "Nữ" : "Nam", txtCMND.Text, txtDiaChi.Text, txtSoDT.Text, dtNgayVL.Value, txtTaiKhoan.Text, txtMatKhau.Text, txtMucLuong.Text, txtPhuCap.Text };
            int kq = DataProvider.ExecuteNonQuery(query, thamso);

            if (kq > 0)
            {
                MessageBox.Show("Ban Da Them Thanh Cong", "Thong Bao!", MessageBoxButtons.OK, MessageBoxIcon.Question);

                frmQLNV.Load_NhanVien();
                
                // them thanh cong
                this.Close();
            }
            else
            {
                MessageBox.Show("Ban Them That Bai", "Thong Bao!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                // them that bai
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtHoTenNV_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSoDT_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {
           
        }
        /// <summary>
        /// Ràng buộc người dùng nhập kí tự trong ô số ĐT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSoDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) // Ràng buộc người dùng không cho nhập vào chữ cái 
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Ràng buộc người dùng dùng COPPY/PAST
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSoDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86) // Ràng buộc người dùng không cho phép người dùng coppy + past
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void txtHoTenNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) // Ràng buộc người dùng không cho nhập vào số
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtHoTenNV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86) // Ràng buộc người dùng không cho phép người dùng coppy + past
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) // Ràng buộc người dùng không cho nhập vào chữ cái 
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtCMND_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86) // Ràng buộc người dùng không cho phép người dùng coppy + past
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void txtMucLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) // Ràng buộc người dùng không cho nhập vào chữ cái 
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtMucLuong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86) // Ràng buộc người dùng không cho phép người dùng coppy + past
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void txtPhuCap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) // Ràng buộc người dùng không cho nhập vào chữ cái 
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPhuCap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86) // Ràng buộc người dùng không cho phép người dùng coppy + past
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void frmThemNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void rbNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
