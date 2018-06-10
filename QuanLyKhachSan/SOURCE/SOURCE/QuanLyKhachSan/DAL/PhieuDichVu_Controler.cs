using QuanLyKhachSan.ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    class PhieuDichVu_Controler : sqlConnect
    {
        public void insertPhieuDichVu(PhieuDichVu p)
        {
            openConnection();
            string query = "insert into PHIEUDICHVU(MaPhieuDichVu, MaPhieuDangKy, TenDichVu, GiaDichVu) values (@MaPhieuDichVu, @MaPhieuDangKy, @TenDichVu, @GiaDichVu)";
            SqlCommand cmd = new SqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("@MaPhieuDichVu", p.MaPhieuDichVu);
            cmd.Parameters.AddWithValue("@MaPhieuDangKy", p.MaPhieuDangKy);
            cmd.Parameters.AddWithValue("@TenDichVu", p.TenDichVu);
            cmd.Parameters.AddWithValue("@GiaDichVu", p.GiaDichVu);
            cmd.ExecuteNonQuery();
        }

        public void EditPhieuDichVu(PhieuDichVu p)
        {
            openConnection();
            string query = "update PHIEUDICHVU set MaPhieuDangKy = @MaPhieuDangKy, TenDichVu = @TenDichVu, GiaDichVu = @GiaDichVu where MaPhieuDichVu = @MaPhieuDichVu";
            SqlCommand cmd = new SqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("@MaPhieuDichVu", p.MaPhieuDichVu);
            cmd.Parameters.AddWithValue("@MaPhieuDangKy", p.MaPhieuDangKy);
            cmd.Parameters.AddWithValue("@TenDichVu", p.TenDichVu);
            cmd.Parameters.AddWithValue("@GiaDichVu", p.GiaDichVu);
            cmd.ExecuteNonQuery();
        }
    }
}
