using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.ENTITY
{
    class KhachHang
    {
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string CMND { get; set; }
        public string DiaChi { get; set; }
        public string GioiTinh { get; set; }
        public string SDT { get; set; }
        public string QuocTich { get; set; }
        public KhachHang(string maKH, string tenKH, string cmnd, string diaChi, string gioiTinh, string sdt, string quocTich)
        {
            MaKH = maKH;
            TenKH = tenKH;
            CMND = cmnd;
            DiaChi = diaChi;
            GioiTinh = gioiTinh;
            SDT = sdt;
            QuocTich = quocTich;
        }


    }
}
