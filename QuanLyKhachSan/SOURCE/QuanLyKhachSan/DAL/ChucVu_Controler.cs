using QuanLyKhachSan.ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    class ChucVu_Controler : sqlConnect
    {
        public void insertChucVu(ChucVu cv)
        {
            try
            {
                openConnection();
                string query = "insert into CHUCVU(MaChucVu, TenChucVu) values (@MaChucVu, @TenChucVu)";
                SqlCommand cmd = new SqlCommand(query, Conn);
                cmd.Parameters.AddWithValue("@MaChucVu", cv.MaChucVu);
                cmd.Parameters.AddWithValue("@TenChucVu", cv.TenChucVu);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
        }

        public void EditChucVu(ChucVu cv)
        {
            openConnection();
            string query = "update CHUCVU set TenChucVu = @TenChucVu where MaChucVu = @MaChucVu";
            SqlCommand cmd = new SqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("@MaChucVu", cv.MaChucVu);
            cmd.Parameters.AddWithValue("@TenChucVu", cv.TenChucVu);
            cmd.ExecuteNonQuery();
        }
    }
}
