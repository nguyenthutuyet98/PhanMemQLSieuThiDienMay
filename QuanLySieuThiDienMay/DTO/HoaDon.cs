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
    public class HoaDon
    {
        private int soHD;
        private DateTime ngayLap;
        private int maNV;
        private double tongTien;

        public HoaDon() { }
        public HoaDon(int SoHD, DateTime NgayLap, int MaNV, double TongTien)
        {
            this.SoHD = SoHD;
            this.NgayLap = NgayLap;
            this.MaNV = MaNV;
            this.TongTien = TongTien;
        }

        public int SoHD
        {
            get { return soHD; }
            set { soHD = value; }
        }

        public DateTime NgayLap
        {
            get { return ngayLap; }
            set { ngayLap = value; }
        }

        public int MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public double TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }
    }
}
