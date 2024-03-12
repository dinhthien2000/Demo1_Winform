using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.Entities
{
    public class Khoa
    {
        public int MaKhoa { get; set; }
        public int TenKhoa { get; set; }

        public Khoa() { }

        public Khoa(int maKhoa, int tenKhoa)
        {
            MaKhoa = maKhoa;
            TenKhoa = tenKhoa;
        }
    }
}
