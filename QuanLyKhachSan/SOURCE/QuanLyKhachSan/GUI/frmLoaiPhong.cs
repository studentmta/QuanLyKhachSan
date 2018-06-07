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
    public partial class frmLoaiPhong : Form
    {
        bool kt;
        public frmLoaiPhong()
        {
            InitializeComponent();
        }

        private void resetControl()
        {
            txtMaPhong.ResetText();
            txtTenLP.ResetText();
            txtTrangBi.ResetText();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = true;
            resetControl();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ENTITY.LoaiPhong lp = new ENTITY.LoaiPhong(txtMaPhong.Text.Trim(), txtTenLP.Text.Trim(), txtTrangBi.Text.Trim());
            DAL.LoaiPhong_Controler l = new DAL.LoaiPhong_Controler();
            if (kt == true)
            {
                l.insertLoaiPhong(lp);
            }
            resetControl();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            resetControl();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ENTITY.LoaiPhong lp = new ENTITY.LoaiPhong(txtMaPhong.Text.Trim(), txtTenLP.Text.Trim(), txtTrangBi.Text.Trim());
            DAL.LoaiPhong_Controler l = new DAL.LoaiPhong_Controler();
            l.EditLoaiPhong(lp);
        }
    }
}
