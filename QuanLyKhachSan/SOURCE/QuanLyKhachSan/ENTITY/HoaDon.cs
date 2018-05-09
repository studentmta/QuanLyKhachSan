using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.ENTITY
{
    class HoaDon
    {
        public string MaHoaDon { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public string SoTienDatTruoc { get; set; }
        public string DonVi { get; set; }
        public string MaNV { get; set; }
        public HoaDon(string maHoaDon, DateTime ngayThanhToan, string soTienDatTruoc, string donVi, string maNV)
        {
            MaHoaDon = maHoaDon;
            NgayThanhToan = ngayThanhToan;
            SoTienDatTruoc = soTienDatTruoc;
            DonVi = donVi;
            MaNV = maNV;
        }
    }
}
