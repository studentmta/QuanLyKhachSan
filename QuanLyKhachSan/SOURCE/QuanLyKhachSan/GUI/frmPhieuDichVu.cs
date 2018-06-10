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
        bool kt;
        public frmPhieuDichVu()
        {
            InitializeComponent();
        }

        public void lockControl()
        {
            txtMaPhieuDV.Enabled = false;
            txtMaPhieuDK.Enabled = false;
            txtTenDV.Enabled = false;
            txtGiaDichVu.Enabled = false;
            btnThem.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            lsvPDV.Enabled = true;
        }
        public void openControl()
        {
            txtMaPhieuDV.Enabled = true;
            txtMaPhieuDK.Enabled = true;
            txtTenDV.Enabled = true;
            txtGiaDichVu.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            lsvPDV.Enabled = false;

        }

        private void resetControl()
        {
            txtGiaDichVu.ResetText();
            txtMaPhieuDK.ResetText();
            txtMaPhieuDV.ResetText();
            txtTenDV.ResetText();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = true;
            openControl();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            resetControl();
            txtMaPhieuDV.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            lockControl();
            resetControl();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            lockControl();
            ENTITY.PhieuDichVu pdv = new ENTITY.PhieuDichVu(txtMaPhieuDV.Text.Trim(), txtMaPhieuDK.Text.Trim(), txtTenDV.Text.Trim(), txtGiaDichVu.Text.Trim());
            DAL.PhieuDichVu_Controler p = new DAL.PhieuDichVu_Controler();
            if (kt==true)
            {
                p.insertPhieuDichVu(pdv);
            }
            showLsvPDV();
            resetControl();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = false;
            openControl();
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            ENTITY.PhieuDichVu pdv = new ENTITY.PhieuDichVu(txtMaPhieuDV.Text.Trim(), txtMaPhieuDK.Text.Trim(), txtTenDV.Text.Trim(), txtGiaDichVu.Text.Trim());
            DAL.PhieuDichVu_Controler p = new DAL.PhieuDichVu_Controler();
            p.EditPhieuDichVu(pdv);
            showLsvPDV();
        }
        private void showLsvPDV()
        {
            lsvPDV.Items.Clear();
            DAL.sqlConnect sql = new DAL.sqlConnect();
            SqlDataReader dr = sql.getDataTable("PHIEUDICHVU");
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = dr["MaPhieuDichVu"].ToString();
                item.SubItems.Add(dr["MaPhieuDangKy"].ToString());
                item.SubItems.Add(dr["TenDichVu"].ToString());
                item.SubItems.Add(dr["GiaDichVu"].ToString());
                lsvPDV.Items.Add(item);
            }
        }
        private void frmPhieuDichVu_Load(object sender, EventArgs e)
        {
            lockControl();
            showLsvPDV();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lockControl();
            string query = "delete from PHIEUDICHVU where MaPhieuDichVu = '" + txtMaPhieuDK.Text.Trim() + "'";
            DAL.sqlConnect conn = new DAL.sqlConnect();
            conn.execNonQuery(query);
        }
    }
}
