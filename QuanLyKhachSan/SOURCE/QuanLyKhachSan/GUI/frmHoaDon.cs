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
    public partial class frmHoaDon : Form
    {
        bool kt;
        public frmHoaDon()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        public void lockControl()         {             txtMaCV.Enabled = false;             dtNgayKetThuc.Enabled = false;             textBox1.Enabled = false;             textBox2.Enabled = false;             textBox3.Enabled = false;             btnHuy.Enabled = false;             btnLuu.Enabled = false;             btnSua.Enabled = false;             btnXoa.Enabled = false;             btnThem.Enabled = true;         }

        private void loadList()
        {
            lsvChucVu.Items.Clear();
            try             {                 SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NE70A7B\\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True");                 SqlCommand com = new SqlCommand("Select * from HOADON", conn);                 conn.Open();                 SqlDataReader dr = com.ExecuteReader();                 while (dr.Read())                 {
                    addList(dr);                 }             }             catch (Exception ex)             {                  throw;             }
        }

        private void addList(SqlDataReader dr)
        {
            ListViewItem item = new ListViewItem();
            item.Text = dr["MaHoaDon"].ToString();
            item.SubItems.Add(dr["NgayThanhToan"].ToString());
            item.SubItems.Add(dr["SoTienDatTruoc"].ToString());
            item.SubItems.Add(dr["DonVi"].ToString());
            item.SubItems.Add(dr["MaNV"].ToString());
            lsvChucVu.Items.Add(item);
        }


        private void frmHoaDon_Load(object sender, EventArgs e)
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
            if (key.Equals("Mã hóa đơn"))
            {
                query = "select * from HOADON where MaHoaDon like '%" + value + "%'";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    addList(dr);
                }
            }

            else if (key.Equals("Ngày thanh toán"))
            {
                query = "select * from HOADON where NgayThanhToan like '%" + value + "%'";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    addList(dr);
                }
            }
            else
            {
                query = "select * from HOADON where MaNV like '%" + value + "%'";
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
            txtMaCV.ResetText();
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ENTITY.HoaDon hd = new ENTITY.HoaDon(txtMaCV.Text.Trim(), dtNgayKetThuc.Value, textBox1.Text.Trim(), textBox2.Text.Trim(), textBox3.Text.Trim());
            DAL.HoaDon_Controler h = new DAL.HoaDon_Controler();
            if (kt == true)
            {
                h.insertHoaDon(hd);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            resetControl();
>>>>>>> tuanthinh
        }
    }
}
