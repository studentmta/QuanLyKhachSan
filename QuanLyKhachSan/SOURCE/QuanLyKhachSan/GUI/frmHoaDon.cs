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
            txtMaCV.ResetText();
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ENTITY.HoaDon hd = new ENTITY.HoaDon(txtMaCV.Text.Trim(), dtNgayKetThuc.Value, textBox1.Text.Trim(), textBox2.Text.Trim(), textBox3.Text.Trim());
            DAL.HoaDon_Controler h = new DAL.HoaDon_Controler();
            if (kt == true)
            {
                h.insertHoaDon(hd);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            resetControl();
        }
    }
}
