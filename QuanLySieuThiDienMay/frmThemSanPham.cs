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
    public partial class frmThemSanPham : Form
    {
        private frmQLSanPham frmQLSP;
        private List<LoaiSP> lstLoaiSP;
        public frmThemSanPham(frmQLSanPham frm)
        {
            InitializeComponent();

            frmQLSP = frm;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblTTSP_Click(object sender, EventArgs e)
        {

        }

        private void frmThemSanPham_Load(object sender, EventArgs e)
        {
            LoadLoaiSP();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Lỗi bỏ trống ô nhập
            if (txtTenSP.Text == "")
            {
                MessageBox.Show(" Vui lòng nhập vào ô!! ", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // return bởi vì không muốn code chạy khi nhấn nút thêm 
            }
            if (cbxLoaiSP.Text == "")
            {
                MessageBox.Show(" Vui lòng nhập vào ô!! ", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // return bởi vì không muốn code chạy khi nhấn nút thêm 
            }
            if (txtGiaBan.Text == "")
            {
                MessageBox.Show(" Vui lòng nhập vào ô!! ", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // return bởi vì không muốn code chạy khi nhấn nút thêm 
            }
            if (txtNuocSX.Text == "")
            {
                MessageBox.Show(" Vui lòng nhập vào ô!! ", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // return bởi vì không muốn code chạy khi nhấn nút thêm 
            }

            if (txtTenSP.Text.Length > 100)
            {
                MessageBox.Show(" Bạn đã nhập quá kí tự cho phép (TenSP VARCHAR(100)) ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtNuocSX.Text.Length > 50)
            {
                MessageBox.Show(" Bạn đã nhập quá kí tự cho phép (NuocSX VARCHAR(50)) ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string query = "EXEC SP_THEM_SANPHAM @TenSP , @GiaBan , @MaLoaiSP , @NuocSX , @HinhAnh";
                object[] thamso = new object[] { txtTenSP.Text, Double.Parse(txtGiaBan.Text), ((LoaiSP)cbxLoaiSP.SelectedItem).MaLoaiSP, txtNuocSX.Text, pbHinh.ImageLocation };
                int kq = DataProvider.ExecuteNonQuery(query, thamso);

                if (kq > 0)
                {
                    MessageBox.Show("Ban Da Them Thanh Cong", "Thong Bao!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    // them thanh cong

                    frmQLSP.Load_SanPham();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ban Them That Bai", "Thong Bao!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    // them that bai
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTenSP_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTenSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86) // Ràng buộc người dùng không cho phép người dùng coppy + past
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtGiaBan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86) // Ràng buộc người dùng không cho phép người dùng coppy + past
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void txtNuocSX_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNuocSX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86) // Ràng buộc người dùng không cho phép người dùng coppy + past
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); //Tạo ra hộp thoại để mở file

            ofd.Title = "Mời chọn hình sản phẩm";
            ofd.Filter = "Image|*.jpg;*.png;*.bmp;*.jpeg;*.gif";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)// Người dùng nhấn ok trong hộp thoại chọn ảnh
            {
                pbHinh.ImageLocation = ofd.FileName; // Thực hiện gán hình ảnh vào picturebox
            }
        }
        /// <summary>
        /// Load dữ liệu loại sản phẩm lên winform
        /// </summary>
        public void LoadLoaiSP()
        {
            lstLoaiSP = new List<LoaiSP>();
            string query = "EXEC SP_LOAD_LOAISP";
            DataTable kq = DataProvider.ExecuteQuery(query);

            foreach (DataRow item in kq.Rows)
            {
                LoaiSP tmp = new LoaiSP();
                tmp.MaLoaiSP = int.Parse(item[0].ToString());
                tmp.TenLoaiSP = item[1].ToString();

                lstLoaiSP.Add(tmp);
            }

            cbxLoaiSP.DataSource = lstLoaiSP;
            cbxLoaiSP.DisplayMember = "TenLoaiSP";
        }
        private void cbxLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbxLoaiSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

    }
}
