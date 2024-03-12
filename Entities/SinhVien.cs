using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.Entities
{
    public class SinhVien
    {
        public int Masv { get; set; }
        public int HoTen { get; set; }
        public int Lop { get; set; }
        public int GioiTinh { get; set; }
        public int DiaChi { get; set; }
        public int NgaySinh { get; set; }
        public int Email { get; set; }
        public int NienKhoa { get; set; }
        public int Khoa { get; set; }

        public SinhVien()
        {
        }

        public SinhVien(int masv, int hoTen, int lop, int gioiTinh, int diaChi, int ngaySinh, int email, int nienKhoa, int khoa)
        {
            Masv = masv;
            HoTen = hoTen;
            Lop = lop;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            NgaySinh = ngaySinh;
            Email = email;
            NienKhoa = nienKhoa;
            Khoa = khoa;
        }
    }
}
