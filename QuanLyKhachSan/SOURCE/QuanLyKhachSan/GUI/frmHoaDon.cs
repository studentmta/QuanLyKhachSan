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
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ENTITY.HoaDon hd = new ENTITY.HoaDon(txtMaHD.Text.Trim(), dtNgaytt.Value, txtSoTienDatTruoc.Text.Trim(), txtDonVi.Text.Trim(), txtmaNV.Text.Trim());
            DAL.HoaDon_Controler h = new DAL.HoaDon_Controler();
            if (kt == true)
            {
                h.insertHoaDon(hd);
            }
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
            resetControl();
        }
    }
}
