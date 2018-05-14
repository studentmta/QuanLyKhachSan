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
    public partial class frmPhieuDangKy : Form
    {
        public frmPhieuDangKy()
        {
            InitializeComponent();
        }

        public void lockControl()         {             txtMaNV.Enabled = false;             txtHoTen.Enabled = false;             txtDiaChi.Enabled = false;             txtMaPB.Enabled = false;             txtQuocTich.Enabled = false;             txtSDT.Enabled = false;             dtNgayBatDau.Enabled = false;             dtNgayKetThuc.Enabled = false;             btnHuy.Enabled = false;             btnLuu.Enabled = false;             btnSua.Enabled = false;             btnXoa.Enabled = false;             btnThem.Enabled = true;         }

        private void loadList()
        {
            lsvNhanVien.Items.Clear();
            try             {                 SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NE70A7B\\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True");                 SqlCommand com = new SqlCommand("Select * from PHIEUDANGKY", conn);                 conn.Open();                 SqlDataReader dr = com.ExecuteReader();                 while (dr.Read())                 {
                    addList(dr);                 }             }             catch (Exception ex)             {                  throw;             }
        }

        private void addList(SqlDataReader dr)
        {
            ListViewItem item = new ListViewItem();
            item.Text = dr["MaPhieuDangKy"].ToString();
            item.SubItems.Add(dr["MaKH"].ToString());
            item.SubItems.Add(dr["MaNV"].ToString());
            item.SubItems.Add(dr["NgayLap"].ToString());
            item.SubItems.Add(dr["NgayDi"].ToString());
            item.SubItems.Add(dr["MaPhong"].ToString());
            item.SubItems.Add(dr["TraTruoc"].ToString());
            item.SubItems.Add(dr["DonVi"].ToString());
            lsvNhanVien.Items.Add(item);
        }

        private void frmPhieuDangKy_Load(object sender, EventArgs e)
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
            if (key.Equals("Mã đăng ký"))
            {
                query = "select * from PHIEUDANGKY where MaPhieuDangKy like '%" + value + "%'";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    addList(dr);
                }
            }
            else if (key.Equals("Mã khách hàng"))
            {
                query = "select * from PHIEUDANGKY where MaKH like '%" + value + "%'";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    addList(dr);
                }
            }
            else if (key.Equals("Mã nhân viên"))
            {
                query = "select * from PHIEUDANGKY where MaNV like '%" + value + "%'";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    addList(dr);
                }
            }
            else if (key.Equals("Ngày lập"))
            {
                query = "select * from PHIEUDANGKY where NgayLap like '%" + value + "%'";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    addList(dr);
                }
            }
            else if (key.Equals("Ngày đi"))
            {
                query = "select * from PHIEUDANGKY where NgayDi like '%" + value + "%'";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    addList(dr);
                }
            }
            else if (key.Equals("Mã phòng"))
            {
                query = "select * from PHIEUDANGKY where MaPhong like '%" + value + "%'";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    addList(dr);
                }
            }
            else if (key.Equals("Trả trước"))
            {
                query = "select * from PHIEUDANGKY where TraTruoc like '%" + value + "%'";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    addList(dr);
                }
            }
            else
            {
                query = "select * from PHIEUDANGKY where DonVi like '%" + value + "%'";
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
