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
    public partial class frmPhong : Form
    {
        public frmPhong()
        {
            InitializeComponent();
        }

        public void lockControl()         {             txtDiaChi.Enabled = false;             txtHoTen.Enabled = false;             txtMaNV.Enabled = false;             txtMaPB.Enabled = false;             txtQuocTich.Enabled = false;             txtSDT.Enabled = false;             btnHuy.Enabled = false;             btnLuu.Enabled = false;             btnSua.Enabled = false;             btnXoa.Enabled = false;             btnThem.Enabled = true;         }

        private void loadList()
        {
            lsvNhanVien.Items.Clear();
            try             {                 SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NE70A7B\\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True");                 SqlCommand com = new SqlCommand("Select * from PHONG", conn);                 conn.Open();                 SqlDataReader dr = com.ExecuteReader();                 while (dr.Read())                 {
                    addList(dr);                 }             }             catch (Exception ex)             {                  throw;             }
        }

        private void addList(SqlDataReader dr)
        {
            ListViewItem item = new ListViewItem();
            item.Text = dr["MaPhong"].ToString();
            item.SubItems.Add(dr["TenPhong"].ToString());
            item.SubItems.Add(dr["TinhTrang"].ToString());
            item.SubItems.Add(dr["MaLoaiPhong"].ToString());
            item.SubItems.Add(dr["GiaPhong"].ToString());
            item.SubItems.Add(dr["DonVi"].ToString());
            lsvNhanVien.Items.Add(item);
        }

        private void frmPhong_Load(object sender, EventArgs e)
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
            if (key.Equals("Mã phòng"))
            {
                query = "select * from PHONG where MaPhong like '%" + value + "%'";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    addList(dr);
                }
            }
            else if (key.Equals("Tên phòng"))
            {
                query = "select * from PHONG where TenPhong like '%" + value + "%'";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    addList(dr);
                }
            }
            else if (key.Equals("Mã loại phòng"))
            {
                query = "select * from PHONG where MaLoaiPhong like '%" + value + "%'";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    addList(dr);
                }
            }
            else if (key.Equals("Giá phòng"))
            {
                query = "select * from PHONG where GiaPhong like '%" + value + "%'";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    addList(dr);
                }
            }
            else if (key.Equals("Tình trạng"))
            {
                query = "select * from PHONG where TinhTrang like '%" + value + "%'";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    addList(dr);
                }
            }
            else
            {
                query = "select * from PHONG where DonVi like '%" + value + "%'";
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
