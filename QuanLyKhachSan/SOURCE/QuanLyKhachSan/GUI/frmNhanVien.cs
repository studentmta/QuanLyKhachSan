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
        bool kt;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        public void lockControl()
        {
            txtMaNV.Enabled = false;
            txtChucVu.Enabled = false;
            txtTenNV.Enabled = false;
            dtNgaySinh.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSDT.Enabled = false;
            btnThem.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            lsvNhanVien.Enabled = true;
        }
        public void openControl()
        {
            txtMaNV.Enabled = true;
            txtChucVu.Enabled = true;
            txtTenNV.Enabled = true;
            dtNgaySinh.Enabled = true;
            txtDiaChi.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            lsvNhanVien.Enabled = false;
        }

        private void resetControl()
        {
            txtChucVu.ResetText();
            txtDiaChi.ResetText();
            txtMaNV.ResetText();
            txtSDT.ResetText();
            txtTenNV.ResetText();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = true;
            openControl();
            txtMaNV.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            resetControl();
            txtMaNV.Focus();
        }
        private bool checkGioiTinh()
        {
            bool gioitinh;
            if (rdbNam.Checked == true)
            {
                gioitinh = true;
            }
            else
            {
                gioitinh = false;
            }
            return gioitinh;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            lockControl();
            ENTITY.NhanVien nv = new ENTITY.NhanVien(txtMaNV.Text.Trim(), txtTenNV.Text.Trim(), txtChucVu.Text.Trim(), checkGioiTinh(), dtNgaySinh.Value, txtDiaChi.Text.Trim(), txtSDT.Text.Trim());
            DAL.NhanVien_Controler n = new DAL.NhanVien_Controler();
            if (kt==true)
            {
                n.insertNhanVien(nv);
            }
            showLsvNhanVien();
            resetControl();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            lockControl();
            resetControl();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = false;
            openControl();
            txtMaNV.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            ENTITY.NhanVien nv = new ENTITY.NhanVien(txtMaNV.Text.Trim(), txtTenNV.Text.Trim(), txtChucVu.Text.Trim(), checkGioiTinh(), dtNgaySinh.Value, txtDiaChi.Text.Trim(), txtSDT.Text.Trim());
            DAL.NhanVien_Controler n = new DAL.NhanVien_Controler();
            n.EditNhanVien(nv);
            showLsvNhanVien();
        }

        private void showLsvNhanVien()
        {
            lsvNhanVien.Items.Clear();
            DAL.sqlConnect sql = new DAL.sqlConnect();
            SqlDataReader dr = sql.getDataTable("NHANVIEN");
            while (dr.Read())
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
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            lockControl();
            showLsvNhanVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lockControl();
            string query = "delete from NHANVIEN where MaNV = '" + txtMaNV.Text.Trim() + "'";
            DAL.sqlConnect conn = new DAL.sqlConnect();
            conn.execNonQuery(query);
        }
    }
}
