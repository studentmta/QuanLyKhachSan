using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.GUI
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        public void lockControl()         {             txtMaNV.Enabled = false;             txtHoTen.Enabled = false;             txtDiaChi.Enabled = false;             txtDanToc.Enabled = false;             txtBacLuong.Enabled = false;             dtNgaySinh.Enabled = false;             rdbNam.Enabled = false;             rdbNu.Enabled = false;             btnHuy.Enabled = false;             btnLuu.Enabled = false;             btnSua.Enabled = false;             btnXoa.Enabled = false;             btnThem.Enabled = true;         }

        private void loadList()
        {
            lsvNhanVien.Items.Clear();
            try             {                 SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NE70A7B\\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True");                 SqlCommand com = new SqlCommand("Select * from NHANVIEN", conn);                 conn.Open();                 SqlDataReader dr = com.ExecuteReader();                 while (dr.Read())                 {
                    addList(dr);                 }             }             catch (Exception ex)             {                  throw;             }
        }

        private void addList(SqlDataReader dr)
        {
            ListViewItem item = new ListViewItem();
            item.Text = dr["MaNV"].ToString();
            item.SubItems.Add(dr["TenNV"].ToString());
            item.SubItems.Add(dr["MaChucVu"].ToString());
            item.SubItems.Add(dr["GioiTinh"].ToString());
            item.SubItems.Add(dr["NgaySinh"].ToString());
            item.SubItems.Add(dr["DiaChi"].ToString());
            item.SubItems.Add(dr["SDT"].ToString());
            lsvNhanVien.Items.Add(item);
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            lockControl();
            lsvNhanVien.FullRowSelect = true;
            loadList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadList();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            lsvNhanVien.Items.Clear();
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NE70A7B\\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True");
            conn.Open();
            SqlDataReader dr = null;
            SqlCommand cmd = null;
            string key = cmbKey.Text.Trim();
            string value = cmbValue.Text.Trim();
            string query;
            if (key.Equals("Mã nhân viên"))
            {
                query = "select * from NHANVIEN where MaNV like '%" + value + "%'";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    addList(dr);
                }
            }
            else if (key.Equals("Tên nhân viên"))
            {
                query = "select * from NHANVIEN where TenNV like '%" + value + "%'";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    addList(dr);
                }
            }
            else if (key.Equals("Mã chức vụ"))
            {
                query = "select * from NHANVIEN where MaChucVu like '%" + value + "%'";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    addList(dr);
                }
            }
            else if (key.Equals("Giới tính"))
            {
                query = "select * from NHANVIEN where GioiTinh like '%" + value + "%'";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    addList(dr);
                }
            }
            else if (key.Equals("Ngày sinh"))
            {
                query = "select * from NHANVIEN where NgaySinh like '%" + value + "%'";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    addList(dr);
                }
            }
            else if (key.Equals("Địa chỉ"))
            {
                query = "select * from NHANVIEN where DiaChi like '%" + value + "%'";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    addList(dr);
                }
            }
            else
            {
                query = "select * from NHANVIEN where SDT like '%" + value + "%'";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    addList(dr);
                }
            }
        }
    }
}
