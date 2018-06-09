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
            resetControl();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
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
            showLsvNhanVien();
        }
    }
}
