using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.ENTITY
{
    class ChucVu
    {
        public string MaChucVu { get; set; }
        public string TenChucVu { get; set; }

        public ChucVu(string maChucVu, string tenChucVu)
        {
            MaChucVu = maChucVu;
            TenChucVu = tenChucVu;
        }
    }
}
