using QuanLyKhachSan.ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    class Phong_Controler : sqlConnect
    {
        public void insertPhong(Phong p)
        {
            openConnection();
            string query = "insert into PHONG(MaPhong, TenPhong, TinhTrang, MaLoaiPhong, GiaPhong, DonVi) values (@MaPhong, @TenPhong, @TinhTrang, @MaLoaiPhong, @GiaPhong, @DonVi)";
            SqlCommand cmd = new SqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("@MaPhong", p.MaPhong);
            cmd.Parameters.AddWithValue("@TenPhong", p.TenPhong);
            cmd.Parameters.AddWithValue("@TinhTrang", p.TinhTrang);
            cmd.Parameters.AddWithValue("@MaLoaiPhong", p.MaLoaiPhong);
            cmd.Parameters.AddWithValue("@GiaPhong", p.GiaPhong);
            cmd.Parameters.AddWithValue("@DonVi", p.DonVi);
            cmd.ExecuteNonQuery();
        }

        public void EditPhong(Phong p)
        {
            openConnection();
            string query = "update PHONG set TenPhong = @TenPhong, TinhTrang = @TinhTrang, MaLoaiPhong = @MaLoaiPhong, GiaPhong = @GiaPhong, DonVi = @DonVi where MaPhong = @MaPhong";
            SqlCommand cmd = new SqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("@MaPhong", p.MaPhong);
            cmd.Parameters.AddWithValue("@TenPhong", p.TenPhong);
            cmd.Parameters.AddWithValue("@TinhTrang", p.TinhTrang);
            cmd.Parameters.AddWithValue("@MaLoaiPhong", p.MaLoaiPhong);
            cmd.Parameters.AddWithValue("@GiaPhong", p.GiaPhong);
            cmd.Parameters.AddWithValue("@DonVi", p.DonVi);
            cmd.ExecuteNonQuery();
        }
    }
}
