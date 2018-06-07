using QuanLyKhachSan.ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    class NhanVien_Controler : sqlConnect
    {
        public void insertNhanVien(NhanVien nv)
        {
            openConnection();
            string query = "insert into NHANVIEN(MaNV, TenNV, MaChucVu, GioiTinh, NgaySinh, DiaChi, SDT) values (@MaNV, @TenNV, @MaChucVu, @GioiTinh, @NgaySinh, @DiaChi, @SDT)";
            SqlCommand cmd = new SqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
            cmd.Parameters.AddWithValue("@TenNV", nv.TenNV);
            cmd.Parameters.AddWithValue("@MaChucVu", nv.MaChucVu);
            cmd.Parameters.AddWithValue("@GioiTinh", nv.GioiTinh);
            cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh);
            cmd.Parameters.AddWithValue("@DiaChi", nv.DiaChi);
            cmd.Parameters.AddWithValue("@SDT", nv.SDT);
            cmd.ExecuteNonQuery();
        }

        public void EditNhanVien(NhanVien nv)
        {
            openConnection();
            string query = "update NHANVIEN set TenNV = @TenNV, MaChucVu = @MaChucVu, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, DiaChi = @DiaChi, SDT = @SDT where MaNV = @MaNV";
            SqlCommand cmd = new SqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
            cmd.Parameters.AddWithValue("@TenNV", nv.TenNV);
            cmd.Parameters.AddWithValue("@MaChucVu", nv.MaChucVu);
            cmd.Parameters.AddWithValue("@GioiTinh", nv.GioiTinh);
            cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh);
            cmd.Parameters.AddWithValue("@DiaChi", nv.DiaChi);
            cmd.Parameters.AddWithValue("@SDT", nv.SDT);
            cmd.ExecuteNonQuery();
        }
    }
}
