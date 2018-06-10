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
        private void resetControl()
        {
            txtMaHD.ResetText();
            txtmaNV.ResetText();
            txtDonVi.ResetText();
            txtSoTienDatTruoc.ResetText();
            txtTimKiem.ResetText();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = true;
            resetControl();
            txtMaHD.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ENTITY.HoaDon hd = new ENTITY.HoaDon(txtMaHD.Text.Trim(), dtNgaytt.Value, txtSoTienDatTruoc.Text.Trim(), txtDonVi.Text.Trim(), txtmaNV.Text.Trim());
            DAL.HoaDon_Controler h = new DAL.HoaDon_Controler();
            if (kt == true)
            {
                h.insertHoaDon(hd);
            }
            showLsvHD();
            resetControl();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            resetControl();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ENTITY.HoaDon hoaDon = new ENTITY.HoaDon(txtMaHD.Text.Trim(), dtNgaytt.Value, txtSoTienDatTruoc.Text.Trim(), txtDonVi.Text.Trim(), txtmaNV.Text.Trim());
            DAL.HoaDon_Controler editHoaDon = new DAL.HoaDon_Controler();
            editHoaDon.EditHoaDon(hoaDon);
            showLsvHD();
            resetControl();
        }
        private void showLsvHD()
        {
            lsvHoaDon.Items.Clear();
            DAL.sqlConnect sql = new DAL.sqlConnect();
            SqlDataReader dr = sql.getDataTable("HOADON");
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = dr["MaHoaDon"].ToString();
                item.SubItems.Add(dr["NgayThanhToan"].ToString());
                item.SubItems.Add(dr["SoTienDatTruoc"].ToString());
                item.SubItems.Add(dr["DonVi"].ToString());
                item.SubItems.Add(dr["MaNV"].ToString());
                lsvHoaDon.Items.Add(item);
            }
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            showLsvHD();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = "delete from HOADON where MaHoaDon = '" + txtMaHD.Text.Trim() + "'";
            DAL.sqlConnect conn = new DAL.sqlConnect();
            conn.execNonQuery(query);
        }
    }
}
