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
            resetControl();
            txtMaPhong.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            resetControl();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
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
            showLsvPhong();
        }
    }
}
