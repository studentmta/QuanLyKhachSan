using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.ENTITY
{
    class PhieuDichVu
    {
        public string MaPhieuDichVu { get; set; }
        public string MaPhieuDangKy { get; set; }
        public string TenDichVu { get; set; }
        public string GiaDichVu { get; set; }
        public PhieuDichVu(string maPhieuDichVu, string maPhieuDangKy, string tenDichVu, string giaDichVu)
        {
            MaPhieuDichVu = maPhieuDichVu;
            MaPhieuDangKy = maPhieuDangKy;
            TenDichVu = tenDichVu;
            GiaDichVu = giaDichVu;
        }
    }
}
