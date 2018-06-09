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
            showLsvCV();
            resetControl();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = true;
            resetControl();
            txtMaCV.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            resetControl();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ENTITY.ChucVu cv = new ENTITY.ChucVu(txtMaCV.Text.Trim(), txtTenCV.Text.Trim());
            DAL.ChucVu_Controler ecv = new DAL.ChucVu_Controler();
            ecv.EditChucVu(cv);
            showLsvCV();
            resetControl();
        }

        private void frmChucVu_Load(object sender, EventArgs e)
        {
            showLsvCV();
        }
    }
}
