/*
 * ten: nguyen thu tuyet,le thanh thien
 * lop: cd16tt2
 * ma so: 16211tt0881, 16211tt0473
 * giao vien: Le Tho
 * ten do an: quan ly cua hang dien may
 * phan duoc giao: quan ly san pham, quan ly nhan vien, quan ly ban hang
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLySieuThiDienMay.DTO
{
    public class SanPham
    {
        private int maSP;
        private string tenSP;
        private double giaBan;
        private int maLoaiSP;
        private string nuocSX;
        private string hinhAnh;
        private bool isDelete;



        public SanPham() { }

        public SanPham(int MaSP, string TenSP, double GiaBan, int MaLoaiSP, string NuocSX, string HinhAnh, bool IsDelete)
        {
            this.MaSP = MaSP;
            this.TenSP = TenSP;
            this.GiaBan = GiaBan;
            this.MaLoaiSP = MaLoaiSP;
            this.NuocSX = NuocSX;
            this.HinhAnh = HinhAnh;
            this.IsDelete = IsDelete;
        }
        


        public int MaSP
        {
            get { return maSP; }
            set { maSP = value; }
        }
        public string TenSP
        {
            get { return tenSP; }
            set { tenSP = value; }
        }
        public double GiaBan
        {
            get { return giaBan; }
            set { giaBan = value; }
        }
        public int MaLoaiSP
        {
            get { return maLoaiSP; }
            set { maLoaiSP = value; }
        }
        public string NuocSX
        {
            get { return nuocSX; }
            set { nuocSX = value; }
        }

        public string HinhAnh
        {
            get { return hinhAnh; }
            set { hinhAnh = value; }
        }

        public bool IsDelete
        {
            get { return isDelete; }
            set { isDelete = value; }
        }
    }
}
