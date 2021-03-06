﻿using System;
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
    public partial class frmLoaiPhong : Form
    {
        bool kt;
        public frmLoaiPhong()
        {
            InitializeComponent();
        }

        public void lockControl()
        {
            txtMaPhong.Enabled = false;
            txtTenLP.Enabled = false;
            txtTrangBi.Enabled = false;
            btnThem.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            lsvLoaiPhong.Enabled = true;
        }

        public void openControl()
        {
            txtMaPhong.Enabled = true;
            txtTenLP.Enabled = true;
            txtTrangBi.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            lsvLoaiPhong.Enabled = false;

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
            openControl();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            resetControl();
            txtMaPhong.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            lockControl();
            ENTITY.LoaiPhong lp = new ENTITY.LoaiPhong(txtMaPhong.Text.Trim(), txtTenLP.Text.Trim(), txtTrangBi.Text.Trim());
            DAL.LoaiPhong_Controler l = new DAL.LoaiPhong_Controler();
            if (kt == true)
            {
                l.insertLoaiPhong(lp);
            }
            showLsvLoaiPhong();
            resetControl();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            lockControl();
            resetControl();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = false;
            openControl();
            btnThem.Enabled= false;
            btnXoa.Enabled = false;
            ENTITY.LoaiPhong lp = new ENTITY.LoaiPhong(txtMaPhong.Text.Trim(), txtTenLP.Text.Trim(), txtTrangBi.Text.Trim());
            DAL.LoaiPhong_Controler l = new DAL.LoaiPhong_Controler();
            l.EditLoaiPhong(lp);
            showLsvLoaiPhong();
        }
        private void showLsvLoaiPhong()
        {
            lsvLoaiPhong.Items.Clear();
            DAL.sqlConnect sql = new DAL.sqlConnect();
            SqlDataReader dr = sql.getDataTable("LOAIPHONG");
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = dr["MaLoaiPhong"].ToString();
                item.SubItems.Add(dr["TenLoaiPhong"].ToString());
                item.SubItems.Add(dr["TrangBi"].ToString());
                lsvLoaiPhong.Items.Add(item);
            }
        }
        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {
            lockControl();
            showLsvLoaiPhong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lockControl();
            string query = "delete from LOAIPHONG where MaLoaiPhong = '" + txtMaPhong.Text.Trim() + "'";
            DAL.sqlConnect conn = new DAL.sqlConnect();
            conn.execNonQuery(query);
        }
    }
}
