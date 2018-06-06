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
            resetControl();
        }
    }
}
