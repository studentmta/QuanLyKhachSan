using QuanLyKhachSan.ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    class KhachHang_Controler : sqlConnect
    {
        public void insertKhachHang(KhachHang kh)
        {
            try
            {
                openConnection();
                string query = "insert into KHACHHANG(MaKH, TenKH, CMND, DiaChi, GioiTinh, SDT, QuocTich) values (@MaKH, @TenKH, @CMND, @DiaChi, @GioiTinh, @SDT, @QuocTich)";
                SqlCommand cmd = new SqlCommand(query, Conn);
                cmd.Parameters.AddWithValue("@MaKH", kh.MaKH);
                cmd.Parameters.AddWithValue("@TenKH", kh.TenKH);
                cmd.Parameters.AddWithValue("@CMND", kh.CMND);
                cmd.Parameters.AddWithValue("@DiaChi", kh.DiaChi);
                cmd.Parameters.AddWithValue("@GioiTinh", kh.GioiTinh);
                cmd.Parameters.AddWithValue("@SDT", kh.SDT);
                cmd.Parameters.AddWithValue("@QuocTich", kh.QuocTich);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
        }

        public void EditKhachHang(KhachHang kh)
        {
            openConnection();
            string query = "update KHACHHANG set TenKH = @TenKH, CMND = @CMND, DiaChi = @DiaChi, GioiTinh = @GioiTinh, SDT = @SDT, QuocTich = @QuocTich where MaKH = @MaKH";
            SqlCommand cmd = new SqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("@MaKH", kh.MaKH);
            cmd.Parameters.AddWithValue("@TenKH", kh.TenKH);
            cmd.Parameters.AddWithValue("@CMND", kh.CMND);
            cmd.Parameters.AddWithValue("@DiaChi", kh.DiaChi);
            cmd.Parameters.AddWithValue("@GioiTinh", kh.GioiTinh);
            cmd.Parameters.AddWithValue("@SDT", kh.SDT);
            cmd.Parameters.AddWithValue("@QuocTich", kh.QuocTich);
            cmd.ExecuteNonQuery();
        }
    }
}
