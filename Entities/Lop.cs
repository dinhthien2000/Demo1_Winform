using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.Entities
{
    public class Lop
    {
        public string MaLop{ get; set; }
        public string TenLop { get; set; }

        public Lop()
        {
        }

        public Lop(string maLop, string tenLop)
        {
            MaLop = maLop;
            TenLop = tenLop;
        }
    }
}
