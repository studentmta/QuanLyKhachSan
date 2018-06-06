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
            resetControl();
        }
    }
}
