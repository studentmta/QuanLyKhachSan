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

        private void resetControl()
        {
            txtCMND.ResetText();
            txtDiaChi.ResetText();
            txtHoTen.ResetText();
            txtMaKH.ResetText();
            txtQuocTich.ResetText();
            txtSDT.ResetText();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = true;
            resetControl();
            txtMaKH.Focus();
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
            ENTITY.KhachHang kh = new ENTITY.KhachHang(txtMaKH.Text.Trim(), txtHoTen.Text.Trim(), txtCMND.Text.Trim(), txtDiaChi.Text.Trim(), checkGioiTinh(), txtSDT.Text.Trim(), txtQuocTich.Text.Trim());
            DAL.KhachHang_Controler k = new DAL.KhachHang_Controler();
            if (kt == true)
            {
                k.insertKhachHang(kh);
            }
            showLSvKhachHang();
            resetControl();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ENTITY.KhachHang kh = new ENTITY.KhachHang(txtMaKH.Text.Trim(), txtHoTen.Text.Trim(), txtCMND.Text.Trim(), txtDiaChi.Text.Trim(), checkGioiTinh(), txtSDT.Text.Trim(), txtQuocTich.Text.Trim());
            DAL.KhachHang_Controler k = new DAL.KhachHang_Controler();
            k.EditKhachHang(kh);
            showLSvKhachHang();
        }
        private void showLSvKhachHang()
        {
            lsvKhachHang.Items.Clear();
            DAL.sqlConnect sql = new DAL.sqlConnect();
            SqlDataReader dr = sql.getDataTable("KHACHHANG");
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = dr["MaKH"].ToString();
                item.SubItems.Add(dr["TenKH"].ToString());
                item.SubItems.Add(dr["CMND"].ToString());
                item.SubItems.Add(dr["DiaChi"].ToString());
                item.SubItems.Add(dr["GioiTinh"].ToString());
                item.SubItems.Add(dr["SDT"].ToString());
                item.SubItems.Add(dr["QuocTich"].ToString());
                lsvKhachHang.Items.Add(item);
            }
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            showLSvKhachHang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = "delete from KHACHHANG where MaKH = '" + txtMaKH.Text.Trim() + "'";
            DAL.sqlConnect conn = new DAL.sqlConnect();
            conn.execNonQuery(query);
        }
    }
}
