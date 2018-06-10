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
        bool kt;
        public frmPhong()
        {
            InitializeComponent();
        }

        public void lockControl()
        {
            txtMaPhong.Enabled = false;
            txtTenPhong.Enabled = false;
            txtTinhTrang.Enabled = false;
            txtMaLP.Enabled = false;
            txtGiaPhong.Enabled = false;
            txtDonVi.Enabled = false;
            btnThem.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            lsvPhong.Enabled = true;
        }
        public void openControl()
        {
            txtMaPhong.Enabled = true;
            txtTenPhong.Enabled = true;
            txtTinhTrang.Enabled = true;
            txtMaLP.Enabled = true;
            txtGiaPhong.Enabled = true;
            txtDonVi.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            lsvPhong.Enabled = false;
        }

        private void resetControl()
        {
            txtDonVi.ResetText();
            txtGiaPhong.ResetText();
            txtMaLP.ResetText();
            txtMaPhong.ResetText();
            txtTenPhong.ResetText();
            txtTinhTrang.ResetText();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = true;
            openControl();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            resetControl();
            txtMaPhong.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            lockControl();
            resetControl();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            lockControl();
            ENTITY.Phong p = new ENTITY.Phong(txtMaPhong.Text.Trim(), txtTenPhong.Text.Trim(), txtTinhTrang.Text.Trim(), txtMaLP.Text.Trim(), txtGiaPhong.Text.Trim(), txtDonVi.Text.Trim());
            DAL.Phong_Controler a = new DAL.Phong_Controler();
            if (kt==true)
            {
                a.insertPhong(p);
            }
            showLsvPhong();
            resetControl();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = false;
            openControl();
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            ENTITY.Phong p = new ENTITY.Phong(txtMaPhong.Text.Trim(), txtTenPhong.Text.Trim(), txtTinhTrang.Text.Trim(), txtMaLP.Text.Trim(), txtGiaPhong.Text.Trim(), txtDonVi.Text.Trim());
            DAL.Phong_Controler a = new DAL.Phong_Controler();
            a.EditPhong(p);
            showLsvPhong();
        }
        private void showLsvPhong()
        {
            lsvPhong.Items.Clear();
            DAL.sqlConnect sql = new DAL.sqlConnect();
            SqlDataReader dr = sql.getDataTable("PHONG");
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = dr["MaPhong"].ToString();
                item.SubItems.Add(dr["TenPhong"].ToString());
                item.SubItems.Add(dr["TinhTrang"].ToString());
                item.SubItems.Add(dr["MaLoaiPhong"].ToString());
                item.SubItems.Add(dr["GiaPhong"].ToString());
                item.SubItems.Add(dr["DonVi"].ToString());
                lsvPhong.Items.Add(item);
            }
        }
        private void frmPhong_Load(object sender, EventArgs e)
        {
            lockControl();
            showLsvPhong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lockControl();
            string query = "delete from PHONG where MaPhong = '" + txtMaPhong.Text.Trim() + "'";
            DAL.sqlConnect conn = new DAL.sqlConnect();
            conn.execNonQuery(query);
        }
    }
}
