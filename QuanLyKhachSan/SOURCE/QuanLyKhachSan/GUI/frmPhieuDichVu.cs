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
    public partial class frmPhieuDichVu : Form
    {
        public frmPhieuDichVu()
        {
            InitializeComponent();
        }

        public void lockControl()         {             txtMaCV.Enabled = false;             txtTenCV.Enabled = false;             textBox1.Enabled = false;             textBox2.Enabled = false;             btnHuy.Enabled = false;             btnLuu.Enabled = false;             btnSua.Enabled = false;             btnXoa.Enabled = false;             btnThem.Enabled = true;         }

        private void loadList()
        {
            lsvChucVu.Items.Clear();
            try             {                 SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NE70A7B\\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True");                 SqlCommand com = new SqlCommand("Select * from PHIEUDICHVU", conn);                 conn.Open();                 SqlDataReader dr = com.ExecuteReader();                 while (dr.Read())                 {
                    addList(dr);                 }             }             catch (Exception ex)             {                  throw;             }
        }

        private void addList(SqlDataReader dr)
        {
            ListViewItem item = new ListViewItem();
            item.Text = dr["MaPhieuDichVu"].ToString();
            item.SubItems.Add(dr["MaPhieuDangKy"].ToString());
            item.SubItems.Add(dr["TenDichVu"].ToString());
            item.SubItems.Add(dr["GiaDichVu"].ToString());
            lsvChucVu.Items.Add(item);
        }

        private void frmPhieuDichVu_Load(object sender, EventArgs e)
        {
            lockControl();
            lsvChucVu.FullRowSelect = true;
            loadList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadList();

        }
        
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            lsvChucVu.Items.Clear();
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NE70A7B\\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True");
            conn.Open();
            SqlDataReader dr = null;
            SqlCommand cmd = null;
            string key = comboBox1.Text.Trim();
            string value = txtTimKiem.Text.Trim();
            string query;
            if (key.Equals("Mã phiếu dịch vụ"))
            {
                query = "select * from PHIEUDICHVU where MaPhieuDichVu like '%" + value + "%'";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    addList(dr);
                }
            }
            else if (key.Equals("Mã phiếu đăng ký"))
            {
                query = "select * from PHIEUDICHVU where MaPhieuDangKy like '%" + value + "%'";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    addList(dr);
                }
            }
            else
            {
                query = "select * from PHIEUDICHVU where TenDichVu like '%" + value + "%'";
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
