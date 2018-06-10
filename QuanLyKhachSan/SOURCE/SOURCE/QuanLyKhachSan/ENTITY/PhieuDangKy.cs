using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.ENTITY
{
    class PhieuDangKy
    {
        public string MaPhieuDangKy { get; set; }
        public string MaKH { get; set; }
        public string MaNV { get; set; }
        public DateTime NgayLap { get; set; }
        public DateTime NgayDi { get; set; }
        public string MaPhong { get; set; }
        public string TraTruoc { get; set; }
        public string DonVi { get; set; }
        public PhieuDangKy(string maPhieuDangKy, string maKH, string maNV, DateTime ngayLap, DateTime ngayDi, string maPhong, string traTruoc, string donVi)
        {
            MaPhieuDangKy = maPhieuDangKy;
            MaKH = maKH;
            MaNV = maNV;
            NgayLap = ngayLap;
            NgayDi = ngayDi;
            MaPhong = maPhong;
            TraTruoc = traTruoc;
            DonVi = donVi;
        }
    }
}
