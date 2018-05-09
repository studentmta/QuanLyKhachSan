using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.ENTITY
{
    class NhanVien
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string MaChucVu { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public NhanVien(string maNV, string tenNV, string maChuVu, string gioiTinh, DateTime ngaySinh, string diaChi, string sDT)
        {
            MaNV = maNV;
            TenNV = tenNV;
            MaChucVu = maChuVu;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            SDT = sDT;
        }
    }
}
