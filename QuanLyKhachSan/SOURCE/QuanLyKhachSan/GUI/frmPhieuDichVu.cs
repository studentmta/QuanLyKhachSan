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
            resetControl();
            txtMaPhieuDV.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            resetControl();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
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
            showLsvPDV();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = "delete from PHIEUDICHVU where MaPhieuDichVu = '" + txtMaPhieuDK.Text.Trim() + "'";
            DAL.sqlConnect conn = new DAL.sqlConnect();
            conn.execNonQuery(query);
        }
    }
}
