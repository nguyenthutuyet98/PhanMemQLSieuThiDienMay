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
    public class NhanVien
    {
        private int maNV;
        private string hoTen;
        private string gioiTinh;
        private string cMND;
        private string diaChi;
        private string soDT;
        private DateTime ngayVL;
        private string taiKhoan;
        private string matKhau;
        private double mucLuong;
        private double phuCap;

        public NhanVien() { }
        public NhanVien(int MaNV, string HoTen, string GioiTinh, string CMND, string DiaChi, string SoDT,
            DateTime NgayVL, string TaiKhoan, string MatKhau, double MucLuong, double PhuCap)
        {
            this.MaNV = MaNV;
            this.HoTen = HoTen;
            this.GioiTinh = GioiTinh;
            this.CMND = CMND;
            this.DiaChi = DiaChi;
            this.SoDT = SoDT;
            this.TaiKhoan = TaiKhoan;
            this.MatKhau = MatKhau;
            this.MucLuong = MucLuong;
            this.PhuCap = PhuCap;
        }

        public int MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        public string CMND
        {
            get { return cMND; }
            set { cMND = value; }
        }

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public string SoDT
        {
            get { return soDT; }
            set { soDT = value; }
        }

        public DateTime NgayVL
        {
            get { return ngayVL; }
            set { ngayVL = value; }
        }

        public string TaiKhoan
        {
            get { return taiKhoan; }
            set { taiKhoan = value; }
        }

        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        public double MucLuong
        {
            get { return mucLuong; }
            set { mucLuong = value; }
        }

        public double PhuCap
        {
            get { return phuCap; }
            set { phuCap = value; }
        }
    }
}
