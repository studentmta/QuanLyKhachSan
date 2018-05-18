using QuanLyKhachSan.ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    class PhieuDangKy_Controler : sqlConnect
    {
        public void insertPhieuDangKy(PhieuDangKy p)
        {
            openConnection();
            string query = "insert into PHIEUDANGKY(MaPhieuDangKy, MaKH, MaNV, NgayLap, NgayDi, MaPhong, TraTruoc, DonVi) values (@MaPhieuDangKy, @MaKH, @MaNV, @NgayLap, @NgayDi, @MaPhong, @TraTruoc, @DonVi)";
            SqlCommand cmd = new SqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("@MaPhieuDangKy", p.MaPhieuDangKy);
            cmd.Parameters.AddWithValue("@MaKH", p.MaKH);
            cmd.Parameters.AddWithValue("@MaNV", p.MaNV);
            cmd.Parameters.AddWithValue("@NgayLap", p.NgayLap);
            cmd.Parameters.AddWithValue("@NgayDi", p.NgayDi);
            cmd.Parameters.AddWithValue("@MaPhong", p.MaPhong);
            cmd.Parameters.AddWithValue("@TraTruoc", p.TraTruoc);
            cmd.Parameters.AddWithValue("@DonVi", p.DonVi);
            cmd.ExecuteNonQuery();
        }
    }
}
