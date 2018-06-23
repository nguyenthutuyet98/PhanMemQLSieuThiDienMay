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
    public class LoaiSP
    {
        private int maLoaiSP;
        private string tenLoaiSP;

        public LoaiSP() { }
        public LoaiSP(int MaLoaiSP, string TenLoaiSP)
        {
            this.MaLoaiSP = MaLoaiSP;
            this.TenLoaiSP = TenLoaiSP;
        }

        public int MaLoaiSP
        {
            get { return maLoaiSP; }
            set { maLoaiSP = value; }
        }

        public string TenLoaiSP
        {
            get { return tenLoaiSP; }
            set { tenLoaiSP = value; }
        }
    }
}
