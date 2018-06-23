/*
 * ten: le thanh thien
 * lop: cd16tt2
 * ma so: 16211tt0473
 * giao vien: Le Tho
 * ten do an: quan ly cua hang dien may
 * phan duoc giao: quan ly ban hang(bao quat)
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLySieuThiDienMay.UserControls;
using QuanLySieuThiDienMay.DTO;
using System.Drawing.Printing;

namespace QuanLySieuThiDienMay
{
    public partial class frmBanHang : Form
    {
        private List<ucSanPham> ucSP = new List<ucSanPham>();
        private List<SanPham> lstSanPham = new List<SanPham>();
        private List<LoaiSP> lstLoaiSP = new List<LoaiSP>();
        private List<HoaDon> lstHoaDon = new List<HoaDon>();
        private List<CTHoaDon> lstCTHoaDon = new List<CTHoaDon>();
        private double TongTien = 0;
        private NhanVien currentNV;
        private int SoHD; 

        public NhanVien CurrentNV
        {
            get { return currentNV; }
            set { currentNV = value; }
        }
        
        public frmBanHang(NhanVien CurrentNV)
        {
            InitializeComponent();

            this.CurrentNV = CurrentNV;
        }

        /// <summary>
        /// khi chạy form bán hàng thì 
        /// load loại sản phẩm
        /// load sản phẩm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBanHang_Load(object sender, EventArgs e)
        {
            string query1 = "SP_LOAD_LOAISP";
            DataTable Loaisp = DataProvider.ExecuteQuery(query1);
            foreach (DataRow item in Loaisp.Rows)
            {
                LoaiSP temp = new LoaiSP();
                temp.MaLoaiSP = Int32.Parse(item[0].ToString());
                temp.TenLoaiSP = item[1].ToString();
                lstLoaiSP.Add(temp);
            }

            for (int i = 0; i < lstLoaiSP.Count; i++)
            {
                Button btnLoaiSP = new Button();
                btnLoaiSP.Text = lstLoaiSP[i].TenLoaiSP;
                btnLoaiSP.Tag = lstLoaiSP[i].MaLoaiSP;
                btnLoaiSP.Font = new Font(new FontFamily("Microsoft Sans Serif"), 9.75F, FontStyle.Bold);
                btnLoaiSP.Height = 28;
                btnLoaiSP.Width = 120;

                btnLoaiSP.Click += new EventHandler(btnLoaiSP_Click);

                flowlpLoaiSP.Controls.Add(btnLoaiSP);
            }



            string query2 = "SP_LOAD_SANPHAM";
            DataTable kq =  DataProvider.ExecuteQuery(query2);

            foreach(DataRow item in kq.Rows)
            {
                SanPham temp = new SanPham();
                temp.MaSP = Int32.Parse(item[0].ToString());
                temp.TenSP = item[1].ToString();
                temp.GiaBan = Double.Parse(item[2].ToString());
                temp.MaLoaiSP = Int32.Parse(item[3].ToString());
                temp.NuocSX = item[4].ToString();
                temp.HinhAnh = item[5].ToString();
                temp.IsDelete = bool.Parse(item[6].ToString());
                lstSanPham.Add(temp);
            }

            flowLPUC.SuspendLayout();

            for (int i = 0; i < lstSanPham.Count; i++)
            {
                if (lstSanPham[i].IsDelete == false)
                {
                    ucSanPham tmp = new ucSanPham(lstSanPham[i]);

                    tmp.Click += new EventHandler(ucSanPham_Click);

                    flowLPUC.Controls.Add(tmp);
                    ucSP.Add(tmp);
                }
            }
            flowLPUC.ResumeLayout();
        }

        /// <summary>
        /// khi click vào btn loại sản phẩm nào thì cho sản phẩm đó hiện lên và ngược lại
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btnLoaiSP_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            for (int i = 0; i < lstSanPham.Count; i++)
            {
                ucSP[i].Visible = false;
                if(lstSanPham[i].MaLoaiSP == Int32.Parse(btn.Tag.ToString()))
                {
                    ucSP[i].Visible = true;
                }
            }

        }

        double ThanhTien(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// khi click vào sản phẩm thì thông tin sản phẩm sẽ đc đưa vào datagridview hóa đơn
        /// khi click trùng sản phẩm thì số lượng tăng lên và thành tiền tăng
        /// và cập nhật tổng tiền
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ucSanPham_Click(object sender, EventArgs e)
        {
            ucSanPham uc = sender as ucSanPham;
            bool IsFound = false;

            for (int i = 0; i < dtgvHoaDon.Rows.Count - 1; i++)
            {
                if (uc.Sp.TenSP.CompareTo(dtgvHoaDon.Rows[i].Cells[0].Value.ToString()) == 0)
                {
                    dtgvHoaDon.Rows[i].Cells[1].Value = Int32.Parse(dtgvHoaDon.Rows[i].Cells[1].Value.ToString()) + 1;
                    dtgvHoaDon.Rows[i].Cells[3].Value = ThanhTien(Int32.Parse(dtgvHoaDon.Rows[i].Cells[1].Value.ToString()), Int32.Parse(dtgvHoaDon.Rows[i].Cells[2].Value.ToString()));
                    TongTien += double.Parse(dtgvHoaDon.Rows[i].Cells[2].Value.ToString());

                    IsFound = true;
                }
            }

            if (IsFound == false)
            {
                dtgvHoaDon.Rows.Add(uc.Sp.TenSP, 1, uc.Sp.GiaBan, ThanhTien(1, Int32.Parse(uc.Sp.GiaBan.ToString())), uc.Sp.MaSP);
                TongTien += uc.Sp.GiaBan;
            }

            txtTongTien.Text = TongTien.ToString();
        }

        /// <summary>
        /// khi chọn 1 hoặc nhiều sản phẩm trong datagridview sau đó click btn tăng 
        /// thì tất cả những sản phẩm đó được tăng 1, và cập nhật thành tiền và tổng tiền
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTang_Click(object sender, EventArgs e)
        {
            int currentRow = -1;
            int dem = 0;
            var selectedCells = dtgvHoaDon.SelectedCells;
            for (int i = selectedCells.Count - 1; i >= 0; i--)
            {
                int RowIndex = selectedCells[i].RowIndex;
                if (currentRow != RowIndex && RowIndex != -1 && RowIndex >= dem)
                {
                    currentRow = RowIndex;
                    dem = RowIndex;
                    dtgvHoaDon.Rows[currentRow].Cells[1].Value = Int32.Parse(dtgvHoaDon.Rows[currentRow].Cells[1].Value.ToString()) + 1;
                    dtgvHoaDon.Rows[currentRow].Cells[3].Value = ThanhTien(Int32.Parse(dtgvHoaDon.Rows[currentRow].Cells[1].Value.ToString()), Int32.Parse(dtgvHoaDon.Rows[currentRow].Cells[2].Value.ToString()));
                    TongTien += double.Parse(dtgvHoaDon.Rows[currentRow].Cells[2].Value.ToString());
                    
                }
            }

            txtTongTien.Text = TongTien.ToString();
        }

        /// <summary>
        /// khi chon 1 hoặc nhiều sản phẩm trong datagridview sau đó click btn giam
        /// thì tất cả những sản phẩm đó được giảm 1, và cập nhật thành tiền và tổng tiền
        /// khi số lượng sản phẩm là 1 thì khi click btn giảm thì sản phẩm đó bị xóa ra khỏi datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGiam_Click(object sender, EventArgs e)
        {
            int currentRow = -1;
            int dem = 0;
            var selectedCells = dtgvHoaDon.SelectedCells;
            for (int i = selectedCells.Count - 1; i >= 0; i--)
            {
                int RowIndex = selectedCells[i].RowIndex;
                if (currentRow !=  RowIndex && RowIndex != -1 && RowIndex >= dem)
                {
                    currentRow = RowIndex;
                    dem = RowIndex;
                    if (Int32.Parse(dtgvHoaDon.Rows[currentRow].Cells[1].Value.ToString()) > 1)
                    {
                        dtgvHoaDon.Rows[currentRow].Cells[1].Value = Int32.Parse(dtgvHoaDon.Rows[currentRow].Cells[1].Value.ToString()) - 1;
                        dtgvHoaDon.Rows[currentRow].Cells[3].Value = ThanhTien(Int32.Parse(dtgvHoaDon.Rows[currentRow].Cells[1].Value.ToString()), Int32.Parse(dtgvHoaDon.Rows[currentRow].Cells[2].Value.ToString()));
                        TongTien -= double.Parse(dtgvHoaDon.Rows[currentRow].Cells[2].Value.ToString());
                    }
                    else
                    {
                        TongTien -= double.Parse(dtgvHoaDon.Rows[currentRow].Cells[2].Value.ToString());
                        dtgvHoaDon.Rows.RemoveAt(currentRow);
                        currentRow = -1;
                    }
                    txtTongTien.Text = TongTien.ToString();
                }
            }
            
            
        }

        /// <summary>
        /// khi chon 1 hoặc nhiều sản phẩm trong datagridview sau đó click btn xoa
        /// thì tất cả những sản phẩm đó bị xóa và cập nhật thành tiền và tổng tiền
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            var selectedCells = dtgvHoaDon.SelectedCells;
            for (int i = selectedCells.Count - 1; i >= 0; i--)
            {
                int RowIndex = selectedCells[i].RowIndex;
                if (RowIndex != -1)
                {
                    TongTien -= double.Parse(dtgvHoaDon.Rows[RowIndex].Cells[2].Value.ToString());
                    dtgvHoaDon.Rows.RemoveAt(RowIndex);
                    txtTongTien.Text = TongTien.ToString();
                }
            }
        }

        /// <summary>
        /// khi click vào btn tất cả thì sẽ hiện ra tất cả sản phẩm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTatCa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ucSP.Count; i++)
            {
                ucSP[i].Visible = true;
            }
        }

        /// <summary>
        /// khi click vào btn hóa đơn thì sẽ lưu hóa đơn và chi tiết hóa đơn xuống sql
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                string query3 = "SP_THEM_HOADON @NgayLap , @MaNV , @TongTien";

                object[] temp = new object[] 
                            {
                                dateTPNgayLap.Text,
                                CurrentNV.MaNV,
                                txtTongTien.Text
                            };

                int hd = DataProvider.ExecuteNonQuery(query3, temp);
                if (hd > 0)
                {
                    int CThd = 0;
                    string query4 = "SP_GETLAST_HOADON";
                    SoHD = Int32.Parse(DataProvider.ExecuteScalar(query4).ToString());

                    string query5 = "SP_THEM_CTHOADON @SoHD , @MaSP , @GiaBan , @SoLuong , @ThanhTien";

                    for (int i = 0; i < dtgvHoaDon.Rows.Count - 1; i++)
                    {
                        object[] temp1 = new object[]
                                     {
                                         SoHD,
                                         Int32.Parse(dtgvHoaDon.Rows[i].Cells[4].Value.ToString()),
                                         Int32.Parse(dtgvHoaDon.Rows[i].Cells[2].Value.ToString()),
                                         Int32.Parse(dtgvHoaDon.Rows[i].Cells[1].Value.ToString()),
                                         Int32.Parse(dtgvHoaDon.Rows[i].Cells[3].Value.ToString())
                                     };
                        CThd = DataProvider.ExecuteNonQuery(query5, temp1);
                    }

                    if (CThd > 0)
                    {
                        MessageBox.Show("Ban Da Them Thanh Cong", "Thong Bao!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (MessageBox.Show("Bạn có muốn in hóa đơn không?", "Thong Bao!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
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
                    }
                    else
                    {
                        MessageBox.Show("Ban Them That Bai", "Thong Bao!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
                else
                {
                    MessageBox.Show("Ban Them That Bai", "Thong Bao!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            graphic.DrawString("    Nhân viên: " + CurrentNV.HoTen, font, new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + (int)FontHeight + 10;
            graphic.DrawString("    Số HD: " + SoHD, font, new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + (int)FontHeight + 10;
            graphic.DrawString("    Ngày lập: " + DateTime.Now, font, new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + (int)FontHeight + 15;
            string top = "    Sản phẩm".PadRight(22) + "   SL".PadRight(5) /*+ "Đơn giá".PadRight(9)*/ + "  Thành Tiền";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight; //make the spacing consistent
            graphic.DrawString("    -----------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + (int)FontHeight + 10;
            int index = 0;
            for (int i = 0; i < dtgvHoaDon.Rows.Count - 1; i++)
            {
                graphic.DrawString(Convert.ToString(dtgvHoaDon.Rows[i].Cells[0].Value).Substring(0, 14)+"...", font, new SolidBrush(Color.Black), startX + 35, startY + offset);
                graphic.DrawString(Convert.ToString(dtgvHoaDon.Rows[i].Cells[1].Value), font, new SolidBrush(Color.Black), startX + 220, startY + offset);
                graphic.DrawString(Convert.ToInt64(dtgvHoaDon.Rows[i].Cells[3].Value).ToString(), font, new SolidBrush(Color.Black), startX + 250, startY + offset);
                offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            }
            offset = offset - 1 - (int)FontHeight + 5;
            graphic.DrawString("    -----------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + 12;
            graphic.DrawString("    TỔNG TIỀN ", font, new SolidBrush(Color.Black), startX, startY + offset);

            if (txtTongTien.Text.Length == 6)
            {
                graphic.DrawString(txtTongTien.Text, new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX + 250, startY + offset);
            }
            else
            {
                graphic.DrawString(txtTongTien.Text, new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX + 250, startY + offset);
            }

            offset = offset + (int)FontHeight + 10;

            graphic.DrawString("Hẹn gặp lại!", new Font("Courier New", 12, FontStyle.Italic), new SolidBrush(Color.Black), startX + 95, startY + offset);

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ucSP.Count; i++)
            {
                ucSP[i].Visible = false;
            }

            string query = "SELECT MaSP FROM SANPHAM WHERE TenSP LIKE N'%" + txtTimKiem.Text + "%' OR NuocSX LIKE N'%" + txtTimKiem.Text + "%'" ;

            DataTable kq = DataProvider.ExecuteQuery(query);

            foreach (DataRow item in kq.Rows)
            {
                for (int i = 0; i < ucSP.Count; i++)
                {
                    if (ucSP[i].Sp.MaSP == Int32.Parse(item[0].ToString()))
                    {
                        ucSP[i].Visible = true;
                    }
                }
            }
        }


    }
}
