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
        bool kt;
        public frmPhieuDangKy()
        {
            InitializeComponent();
        }

        public void lockControl()
        {
            txtMaPhieuDK.Enabled = false;
            txtMaKH.Enabled = false;
            txtMaNV.Enabled = false;
            dtNgayLap.Enabled = false;
            dtNgayDi.Enabled = false;
            txtMaPhong.Enabled = false;
            txtTraTruoc.Enabled = false;
            txtDonVi.Enabled = false;
            btnThem.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            lsvPhieuDangKy.Enabled = true;
        }
        public void openControl()
        {
            txtMaPhieuDK.Enabled = true;
            txtMaKH.Enabled = true;
            txtMaNV.Enabled = true;
            dtNgayLap.Enabled = true;
            dtNgayDi.Enabled = true;
            txtMaPhong.Enabled = true;
            txtTraTruoc.Enabled = true;
            txtDonVi.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            lsvPhieuDangKy.Enabled = false;
        }

        private void resetControl()
        {
            txtDonVi.ResetText();
            txtMaKH.ResetText();
            txtMaNV.ResetText();
            txtMaPhieuDK.ResetText();
            txtMaPhong.ResetText();
            txtTraTruoc.ResetText();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = true;
            openControl();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            resetControl();
            txtMaPhieuDK.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            lockControl();
            resetControl();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            lockControl();
            ENTITY.PhieuDangKy pkd = new ENTITY.PhieuDangKy(txtMaPhieuDK.Text.Trim(), txtMaKH.Text.Trim(), txtMaNV.Text.Trim(), dtNgayLap.Value, dtNgayDi.Value, txtMaPhong.Text.Trim(), txtTraTruoc.Text.Trim(), txtDonVi.Text.Trim());
            DAL.PhieuDangKy_Controler p = new DAL.PhieuDangKy_Controler();
            if (kt==true)
            {
                p.insertPhieuDangKy(pkd);
            }
            showLsvPKD();
            resetControl();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = false;
            openControl();
            txtMaPhieuDK.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            ENTITY.PhieuDangKy pkd = new ENTITY.PhieuDangKy(txtMaPhieuDK.Text.Trim(), txtMaKH.Text.Trim(), txtMaNV.Text.Trim(), dtNgayLap.Value, dtNgayDi.Value, txtMaPhong.Text.Trim(), txtTraTruoc.Text.Trim(), txtDonVi.Text.Trim());
            DAL.PhieuDangKy_Controler p = new DAL.PhieuDangKy_Controler();
            p.EditPhieuDangKy(pkd);
            showLsvPKD();
        }
        private void showLsvPKD()
        {
            lsvPhieuDangKy.Items.Clear();
            DAL.sqlConnect sql = new DAL.sqlConnect();
            SqlDataReader dr = sql.getDataTable("PHIEUDANGKY");
            while (dr.Read())
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
                lsvPhieuDangKy.Items.Add(item);
            }
        }
        private void frmPhieuDangKy_Load(object sender, EventArgs e)
        {
            lockControl();
            showLsvPKD();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lockControl();
            string query = "delete from PhieuDangKy where MaPhieuDangKy = '" + txtMaPhieuDK.Text.Trim() + "'";
            DAL.sqlConnect conn = new DAL.sqlConnect();
            conn.execNonQuery(query);
        }
    }
}
