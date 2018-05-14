using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.ENTITY
{
    class Phong
    {
        public string MaPhong { get; set; }
        public string TenPhong { get; set; }
        public string TinhTrang { get; set; }
        public string MaLoaiPhong { get; set; }
        public string GiaPhong { get; set; }
        public string DonVi { get; set; }
        public Phong(string maPhong, string tenPhong, string tinhTrang, string maLoaiPhong, string giaPhong, string donVi)
        {
            MaPhong = maPhong;
            TenPhong = tenPhong;
            TinhTrang = tinhTrang;
            MaLoaiPhong = maLoaiPhong;
            GiaPhong = giaPhong;
            DonVi = donVi;
        }
    }
}
