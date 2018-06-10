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
    public partial class frmChucVu : Form
    {
        bool kt;
        public frmChucVu()
        {
            InitializeComponent();
        }

        public void lockControl()
        {
            txtMaCV.Enabled = false;
            txtTenCV.Enabled = false;
            btnThem.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            lsvChucVu.Enabled = true;
        }
        public void openControl()
        {
            txtMaCV.Enabled = true;
            txtTenCV.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            lsvChucVu.Enabled = false;
        }

        #region func
        public void showLsvCV()
        {
            lsvChucVu.Items.Clear();
            DAL.sqlConnect conn = new DAL.sqlConnect();
            SqlDataReader dr = conn.getDataTable("CHUCVU");
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = dr["MaChucVu"].ToString();
                item.SubItems.Add(dr["TenChucVu"].ToString());
                lsvChucVu.Items.Add(item);
            }
        }

        private void resetControl()
        {
            txtMaCV.ResetText();
            txtTenCV.ResetText();
        }
        #endregion
        private void btnLuu_Click(object sender, EventArgs e)
        {
            ENTITY.ChucVu cv = new ENTITY.ChucVu(txtMaCV.Text.Trim(), txtTenCV.Text.Trim());
            DAL.ChucVu_Controler c = new DAL.ChucVu_Controler();
            if (kt == true)
            {
                c.insertChucVu(cv);
            }
            lockControl();
            showLsvCV();
            resetControl();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = true;
            openControl();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            resetControl();
            txtMaCV.Focus();
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
            txtMaCV.Enabled = false;
            btnThem.Enabled = false;
            txtMaCV.Focus();
            ENTITY.ChucVu cv = new ENTITY.ChucVu(txtMaCV.Text.Trim(), txtTenCV.Text.Trim());
            DAL.ChucVu_Controler ecv = new DAL.ChucVu_Controler();
            ecv.EditChucVu(cv);
            showLsvCV();
            resetControl();
        }

        private void frmChucVu_Load(object sender, EventArgs e)
        {
            lockControl();
            showLsvCV();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = "delete from CHUCVU where MaChucVu = '" + txtMaCV.Text.Trim() + "'";
            DAL.sqlConnect conn = new DAL.sqlConnect();
            conn.execNonQuery(query);
            lockControl();
        }
    }
}
