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
    public partial class frmKhachHang : Form
    {
        bool kt;
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void resetControl()
        {
            txtCMND.ResetText();
            txtDiaChi.ResetText();
            txtHoTen.ResetText();
            txtMaKH.ResetText();
            txtQuocTich.ResetText();
            txtSDT.ResetText();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = true;
            resetControl();
        }
        private bool checkGioiTinh()
        {
            bool gioitinh;
            if (rdbNam.Checked == true)
            {
                gioitinh = true;
            }
            else
            {
                gioitinh = false;
            }
            return gioitinh;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            ENTITY.KhachHang kh = new ENTITY.KhachHang(txtMaKH.Text.Trim(), txtHoTen.Text.Trim(), txtCMND.Text.Trim(), txtDiaChi.Text.Trim(), checkGioiTinh(), txtSDT.Text.Trim(), txtQuocTich.Text.Trim());
            DAL.KhachHang_Controler k = new DAL.KhachHang_Controler();
            if (kt == true)
            {
                k.insertKhachHang(kh);
            }
            resetControl();
        }
    }
}
