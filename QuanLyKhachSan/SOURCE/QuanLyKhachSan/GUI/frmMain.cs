﻿using System;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.frmNhanVien frm = new frmNhanVien();
            frm.ShowDialog();
        }

        private void chứcVụToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GUI.frmChucVu frm = new frmChucVu();
            frm.ShowDialog();
        }
        private void Kháchhang_Click(object sender, EventArgs e)
        {
            GUI.frmKhachHang frm = new frmKhachHang();
            frm.ShowDialog();
        }

        private void Phòng_Click(object sender, EventArgs e)
        {
            GUI.frmPhong frm = new frmPhong();
            frm.ShowDialog();
        }

        private void Loạiphong_Click(object sender, EventArgs e)
        {
            GUI.frmLoaiPhong frm = new frmLoaiPhong();
            frm.ShowDialog();
        }

        private void Phiếudangky_Click(object sender, EventArgs e)
        {
            GUI.frmPhieuDangKy frm = new frmPhieuDangKy();
            frm.ShowDialog();
        }

        private void Phiếudichvu_Click(object sender, EventArgs e)
        {
            GUI.frmPhieuDichVu frm = new frmPhieuDichVu();
            frm.ShowDialog();
        }

        private void Hóadon_Click(object sender, EventArgs e)
        {
            GUI.frmHoaDon frm = new frmHoaDon();
            frm.ShowDialog();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.frmTK_DSNhanVien frm = new frmTK_DSNhanVien();
            frm.ShowDialog();
        }

        private void nhânViênTrìnhĐộHọcVấnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GUI.frmTK_TrangThietBi frm = new frmTK_TrangThietBi();
            frm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GUI.frmTK_DoanhThu frm = new frmTK_DoanhThu();
            frm.ShowDialog();
        }

        private void nhânViênChứcVụToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GUI.frmTK_TinhTrangPhong frm = new frmTK_TinhTrangPhong();
            frm.ShowDialog();
        }
    }
}
