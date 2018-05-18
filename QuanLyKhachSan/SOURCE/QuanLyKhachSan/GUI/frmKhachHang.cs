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
    public partial class frmKhachHang : Form
    {
        bool kt;
        public frmKhachHang()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        public void lockControl()         {             txtMaNV.Enabled = false;             txtHoTen.Enabled = false;             txtDiaChi.Enabled = false;             txtMaPB.Enabled = false;             txtQuocTich.Enabled = false;             txtSDT.Enabled = false;             rdbNam.Enabled = false;             rdbNu.Enabled = false;             btnHuy.Enabled = false;             btnLuu.Enabled = false;             btnSua.Enabled = false;             btnXoa.Enabled = false;             btnThem.Enabled = true;         }

        private void loadList()
        {
            lsvNhanVien.Items.Clear();
            try             {                 SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NE70A7B\\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True");                 SqlCommand com = new SqlCommand("Select * from KHACHHANG", conn);                 conn.Open();                 SqlDataReader dr = com.ExecuteReader();                 while (dr.Read())                 {
                    addList(dr);                 }             }             catch (Exception ex)             {                  throw;             }
        }

        private void addList(SqlDataReader dr)
        {
            ListViewItem item = new ListViewItem();
            item.Text = dr["MaKH"].ToString();
            item.SubItems.Add(dr["TenKH"].ToString());
            item.SubItems.Add(dr["CMND"].ToString());
            item.SubItems.Add(dr["DiaChi"].ToString());
            item.SubItems.Add(dr["GioiTinh"].ToString());
            item.SubItems.Add(dr["SDT"].ToString());
            item.SubItems.Add(dr["QuocTich"].ToString());
            lsvNhanVien.Items.Add(item);
        }


        private void frmKhachHang_Load(object sender, EventArgs e)
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
            if (key.Equals("Mã khách hàng"))
            {
                query = "select * from KHACHHANG where MaKH like '%" + value + "%'";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    addList(dr);
                }
            }
            else if (key.Equals("Tên khách hàng"))
            {
                query = "select * from KHACHHANG where TenKH like '%" + value + "%'";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    addList(dr);
                }
            }
            else if (key.Equals("CMND"))
            {
                query = "select * from KHACHHANG where CMND like '%" + value + "%'";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    addList(dr);
                }
            }
            else if (key.Equals("Địa chỉ"))
            {
                query = "select * from KHACHHANG where DiaChi like '%" + value + "%'";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    addList(dr);
                }
            }
            else if (key.Equals("Giới tính"))
            {
                query = "select * from KHACHHANG where GioiTinh like '%" + value + "%'";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    addList(dr);
                }
            }
            else if(key.Equals("Số điên thoại"))
            {
                query = "select * from KHACHHANG where SDT like '%" + value + "%'";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    addList(dr);
                }
            }
            else
            {
                query = "select * from KHACHHANG where QuocTich like '%" + value + "%'";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    addList(dr);
                }
            }
=======
        private void resetControl()
        {
            txtMaNV.ResetText();
            txtHoTen.ResetText();
            txtDiaChi.ResetText();
            txtMaPB.ResetText();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

>>>>>>> tuanthinh
        }
    }
}
