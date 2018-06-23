/*
 * ten: ngo thi ngoc diem, le thanh thien
 * lop: cd16tt2
 * ma so: 16211tt0449, 16211tt0473
 * giao vien: Le Tho
 * ten do an: quan ly cua hang dien may
 * phan duoc giao: Viet CSDL chung, phan Dang nhap va Thong ke bao cao
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLySieuThiDienMay.DTO
{
    public class CTHoaDon
    {
        private int soHD;
        private int maSP;
        private double giaBan;
        private int soLuong;
        private double thanhTien;

        public CTHoaDon() { }
        public CTHoaDon(int SoHD, int MaSP, double GiaBan, int SoLuong, double ThanhTien)
        {
            this.SoHD = SoHD;
            this.MaSP = MaSP;
            this.GiaBan = GiaBan;
            this.SoLuong = SoLuong;
            this.ThanhTien = ThanhTien;
        }

        public int SoHD
        {
            get { return soHD; }
            set { soHD = value; }
        }

        public int MaSP
        {
            get { return maSP; }
            set { maSP = value; }
        }

        public double GiaBan
        {
            get { return giaBan; }
            set { giaBan = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public double ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }
    }
}
