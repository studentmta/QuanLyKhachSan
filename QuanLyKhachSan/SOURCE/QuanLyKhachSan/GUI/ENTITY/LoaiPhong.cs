using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.ENTITY
{
    class LoaiPhong
    {
        public string MaLoaiPhong { get; set; }
        public string TenLoaiPhong { get; set; }
        public string TrangBi { get; set; }
        public LoaiPhong(string maLoaiPhong, string tenLoaiPhong, string trangBi)
        {
            MaLoaiPhong = maLoaiPhong;
            TenLoaiPhong = tenLoaiPhong;
            TrangBi = trangBi;
        }
    }
}
