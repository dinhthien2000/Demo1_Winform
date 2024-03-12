using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.Entities
{
    public class NienKhoa
    {
        public int MaNienKhoa { get; set; }
        public int TenNienKHoa { get; set; }

        public NienKhoa() { }

        public NienKhoa(int maNienKhoa, int tenNienKHoa)
        {
            MaNienKhoa = maNienKhoa;
            TenNienKHoa = tenNienKHoa;
        }


    }
}
