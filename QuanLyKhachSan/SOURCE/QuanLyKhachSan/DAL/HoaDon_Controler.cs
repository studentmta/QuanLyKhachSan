using QuanLyKhachSan.ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    class HoaDon_Controler : sqlConnect
    {
        public void insertHoaDon(HoaDon hd)
        {
            openConnection();
            string query = "insert into HOADON (MaHoaDon, NgayThanhToan, SoTienDatTruoc, DonVi, MaNV) values (@MaHoaDon, @NgayThanhToan, @SoTienDatTruoc, @DonVi, @MaNV)";
            SqlCommand cmd = new SqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("@MaHOaDon", hd.MaHoaDon);
            cmd.Parameters.AddWithValue("@NgayThanhToan", hd.NgayThanhToan);
            cmd.Parameters.AddWithValue("@SoTienDatTruoc", hd.SoTienDatTruoc);
            cmd.Parameters.AddWithValue("@DonVi", hd.DonVi);
            cmd.Parameters.AddWithValue("@MaNV", hd.MaNV);
            cmd.ExecuteNonQuery();
        }

        public void EditHoaDon(HoaDon hd)
        {
            openConnection();
            string query = "update HOADON set NgayThanhToan = @NgayThanhToan, SoTienDatTruoc = @SoTienDatTruoc, DonVi = @DonVi, MaNV = @MaNV where MaHoaDon = @MaHoaDon";
            SqlCommand cmd = new SqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("@MaHoaDon", hd.MaHoaDon);
            cmd.Parameters.AddWithValue("@NgayThanhToan", hd.NgayThanhToan);
            cmd.Parameters.AddWithValue("@SoTienDatTruoc", hd.SoTienDatTruoc);
            cmd.Parameters.AddWithValue("@DonVi", hd.DonVi);
            cmd.Parameters.AddWithValue("@MaNV", hd.MaNV);
            cmd.ExecuteNonQuery();
        }
    }
}
