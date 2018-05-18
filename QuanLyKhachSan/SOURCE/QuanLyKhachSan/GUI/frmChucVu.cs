using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void resetControl()
        {
            txtMaCV.ResetText();
            txtTenCV.ResetText();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ENTITY.ChucVu cv = new ENTITY.ChucVu(txtMaCV.Text.Trim(), txtTenCV.Text.Trim());
            DAL.ChucVu_Controler c = new DAL.ChucVu_Controler();
            if (kt == true)
            {
                c.insertChucVu(cv);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            resetControl();
        }
    }
}
