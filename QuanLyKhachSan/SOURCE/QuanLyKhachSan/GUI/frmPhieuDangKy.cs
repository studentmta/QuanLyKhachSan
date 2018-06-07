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
            resetControl();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ENTITY.PhieuDangKy pkd = new ENTITY.PhieuDangKy(txtMaPhieuDK.Text.Trim(), txtMaKH.Text.Trim(), txtMaNV.Text.Trim(), dtNgayLap.Value, dtNgayDi.Value, txtMaPhong.Text.Trim(), txtTraTruoc.Text.Trim(), txtDonVi.Text.Trim());
            DAL.PhieuDangKy_Controler p = new DAL.PhieuDangKy_Controler();
            p.EditPhieuDangKy(pkd);
        }
    }
}
