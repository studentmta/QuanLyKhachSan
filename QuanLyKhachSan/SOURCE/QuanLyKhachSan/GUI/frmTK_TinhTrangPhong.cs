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
    public partial class frmTK_TinhTrangPhong : Form
    {
        public frmTK_TinhTrangPhong()
        {
            InitializeComponent();
        }
        private void frmTK_TinhTrangPhong_Load(object sender, EventArgs e)
        {
            loadDataGirdView();
            dgvTTP.AutoResizeColumns();
            dgvTTP.AutoResizeRows();
        }


        private void loadDataGirdView()
        {
            DAL.sqlConnect sql = new DAL.sqlConnect();
        }


        private void bntTK_Click(object sender, EventArgs e)
        {
            if (cbOption_ThongKe.Text.Equals("Trống"))
            {
                DAL.sqlConnect sql = new DAL.sqlConnect();
                dgvTTP.DataSource = sql.TK("select MaPhong,TenPhong,TinhTrang from Phong  where TinhTrang=N'Trống' ");
                dgvTTP.AutoResizeColumns();
                dgvTTP.AutoResizeRows();
            }

            if (cbOption_ThongKe.Text.Equals("Full"))
            {
                DAL.sqlConnect sql = new DAL.sqlConnect();
                dgvTTP.DataSource = sql.TK("select MaPhong,TenPhong,TinhTrang from Phong  where TinhTrang=N'Full' ");
            }
        }
    }
}
