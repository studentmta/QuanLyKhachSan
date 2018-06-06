using QuanLyKhachSan.ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    class LoaiPhong_Controler : sqlConnect
    {
        public void insertLoaiPhong(LoaiPhong lp)
        {
            openConnection();
            string query = "insert into LOAIPHONG (MaLoaiPhong, TenLoaiPhong, TrangBi) values (@MaLoaiPhong, @TenLoaiPhong, @TrangBi)";
            SqlCommand cmd = new SqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("@MaLoaiPhong", lp.MaLoaiPhong);
            cmd.Parameters.AddWithValue("@TenLoaiPhong", lp.TenLoaiPhong);
            cmd.Parameters.AddWithValue("@TrangBi", lp.TrangBi);
            cmd.ExecuteNonQuery();
        }
    }
}
