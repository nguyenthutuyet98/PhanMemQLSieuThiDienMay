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
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QuanLySieuThiDienMay
{
    public partial class frmQLSanPham : Form
    {
        private frmThemSanPham frmTSP;
        private frmMain frmM;
        private List<LoaiSP> lstLoaiSP;
        private int tmp;

        public frmQLSanPham(frmMain temp) //chuyền vào form cha
        {
            InitializeComponent();
            this.frmM = temp;
        }
        // Khai bao connection
        

        /// <summary>
        /// sử lý sự kiện click vào nút thêm trong form quản lý sản phẩm
        /// show form Thêm sản phẩm
        /// nếu form đã tồn tại thì cho form lên trên cùng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (frmTSP != null)
            {
                frmTSP.Focus();
            }
            else
            {
                frmTSP = new frmThemSanPham(this);
                frmTSP.MdiParent = frmM; // khẳng định cha con

                frmTSP.FormClosed += new FormClosedEventHandler(frmTSP_FormClosed);

                frmTSP.Show();
            }
        }

        /// <summary>
        /// sử lý sự kiện khi tắt form Thêm sản phẩm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void frmTSP_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmTSP = null;
        }
        /// <summary>
        /// Sự kiện lick vào Loại sản phẩm sẽ uploat lên danh sach loại sản phẩm
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
        /// <summary>
        /// Load sản phẩm từ cơ sở dữ liệu lên bảng datagidview c#
        /// </summary>
        public void Load_SanPham()
        {
            List<SanPham> lst = new List<SanPham>();
            string query = "EXEC SP_LOAD_SANPHAM";
            DataTable kq = DataProvider.ExecuteQuery(query);
            
                try
                {
                    foreach (DataRow item in kq.Rows)
                    {
                        SanPham tmp = new SanPham();
                        tmp.MaSP = int.Parse(item[0].ToString());
                        tmp.TenSP = item[1].ToString();
                        tmp.GiaBan = double.Parse(item[2].ToString());
                        tmp.MaLoaiSP = int.Parse(item[3].ToString());
                        tmp.NuocSX = item[4].ToString();
                        tmp.HinhAnh = item[5].ToString();
                        tmp.IsDelete = bool.Parse(item[6].ToString());
                        lst.Add(tmp);
                    }
                dtgvSP.DataSource = lst;
                }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmQLSanPham_Load(object sender, EventArgs e)
        {
            Load_SanPham();
            LoadLoaiSP();
        }
        /// <summary>
        /// Sự kiện click để chọn dòng 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int RowIndex = e.RowIndex; // Lấy số thứ tự của dòng đang được chọn

                txtMaSP.Text = dtgvSP.Rows[RowIndex].Cells[0].Value.ToString(); // Lấy dữ liệu của dòng thứ [0] từ bảng SQL
                txtTenSP.Text = dtgvSP.Rows[RowIndex].Cells[1].Value.ToString();
                txtGiaBan.Text = dtgvSP.Rows[RowIndex].Cells[2].Value.ToString();
                cbxLoaiSP.SelectedItem = lstLoaiSP[int.Parse(dtgvSP.Rows[RowIndex].Cells[3].Value.ToString()) - 1];
                txtNuocSX.Text = dtgvSP.Rows[RowIndex].Cells[4].Value.ToString();


                try
                {
                    pbHinh.ImageLocation = Application.StartupPath + "\\" + dtgvSP.Rows[RowIndex].Cells[5].Value.ToString();
                }
                catch (System.IO.FileNotFoundException ex)
                {
                    pbHinh.ImageLocation = Application.StartupPath + "\\imgSanPham\\no_picture.png";
                }

                if (bool.Parse(dtgvSP.Rows[RowIndex].Cells[6].Value.ToString()))
                {
                    ckbKinhDoanh.Checked = true;
                }
                else
                {
                    ckbKinhDoanh.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXOa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thong Bao!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                string query = "SP_XOA_SANPHAM @MaSP";
                object[] thamso = new object[] { Int32.Parse(txtMaSP.Text) };
                int kq = DataProvider.ExecuteNonQuery(query, thamso);

                if (kq > 0)
                {
                    MessageBox.Show("Ban xoa Thanh Cong", "Thong Bao!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    // them thanh cong
                    // Sau khi xoa thanh cong bo Load de no cap nhat lai du lieu
                    Load_SanPham();
                }
                else
                {
                    MessageBox.Show("Ban Xoa That Bai", "Thong Bao!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    // them that bai
                }
            }
        }
        
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Sự kiện click tìm kiếm theo tên sản phẩm, mã loại sản phẩm, nước sản xuất
        /// Tìm kiếm 1 lúc 3 thuộc tính
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<SanPham> lst = new List<SanPham>();
            string query = "SELECT MaSP , TenSP , GiaBan , MaLoaiSP , NuocSX , HinhAnh FROM SANPHAM WHERE TenSP LIKE N'%" + txtTimKiem.Text + "%' OR MaLoaiSP LIKE N'%" + txtTimKiem.Text + "%' OR NuocSX LIKE N'%" + txtTimKiem.Text + "%'" ;

            DataTable kq = DataProvider.ExecuteQuery(query);

            foreach (DataRow item in kq.Rows)
            {
                SanPham tmp = new SanPham();
                tmp.MaSP = int.Parse(item[0].ToString());
                tmp.TenSP = item[1].ToString();
                tmp.GiaBan = double.Parse(item[2].ToString());
                tmp.MaLoaiSP = int.Parse(item[3].ToString());
                tmp.NuocSX = item[4].ToString();
                tmp.HinhAnh = item[5].ToString();
                lst.Add(tmp);
            }
            dtgvSP.DataSource = lst;
        }
        /// <summary>
        /// Cập nhật cơ sở dữ liệu từ SQL lên màn hình winform
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                List<SanPham> lst = new List<SanPham>();
                object[] thamso;
                string query = "EXEC SP_SUA_SANPHAM @MaSP , @TenSP , @GiaBan , @MaLoaiSP , @NuocSX , @HinhAnh , @IsDelete";
                if (tmp != 1)
                {
                    string Hinh = "imgSanPham\\" + txtMaSP.Text + ".png";
                    thamso = new object[] { Int32.Parse(txtMaSP.Text), txtTenSP.Text, Double.Parse(txtGiaBan.Text), ((LoaiSP)cbxLoaiSP.SelectedItem).MaLoaiSP, txtNuocSX.Text, Hinh, Convert.ToInt32(ckbKinhDoanh.Checked).ToString() };

                }
                else
                {
                    thamso = new object[] { Int32.Parse(txtMaSP.Text), txtTenSP.Text, Double.Parse(txtGiaBan.Text), ((LoaiSP)cbxLoaiSP.SelectedItem).MaLoaiSP, txtNuocSX.Text, pbHinh.ImageLocation, Convert.ToInt32(ckbKinhDoanh.Checked).ToString() };
               
                }
                 int kq = DataProvider.ExecuteNonQuery(query, thamso);

                if (kq > 0)
                {
                    MessageBox.Show("Ban Da Cap Nhat Thanh Cong", "Thong Bao!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    // them thanh cong
                    Load_SanPham();
                }
                else
                {
                    MessageBox.Show("Ban Da Cap Nhat That Bai", "Thong Bao!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    // them that bai
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tmp = 1;
            OpenFileDialog ofd = new OpenFileDialog(); //Tạo ra hộp thoại để mở file

            ofd.Title = "Mời chọn hình sản phẩm";
            ofd.Filter = "Image|*.jpg;*.png;*.bmp;*.jpeg;*.gif";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)// Người dùng nhấn ok trong hộp thoại chọn ảnh
            {
                pbHinh.ImageLocation = ofd.FileName;// Thực hiện gán hình ảnh vào picturebox
            }
        }

        
        private void cbxLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbxLoaiSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dtgvSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
