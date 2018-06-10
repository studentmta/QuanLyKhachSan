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
            resetControl();
            txtMaPhieuDK.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            resetControl();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
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
            showLsvPKD();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = "delete from PhieuDangKy where MaPhieuDangKy = '" + txtMaPhieuDK.Text.Trim() + "'";
            DAL.sqlConnect conn = new DAL.sqlConnect();
            conn.execNonQuery(query);
        }
    }
}
