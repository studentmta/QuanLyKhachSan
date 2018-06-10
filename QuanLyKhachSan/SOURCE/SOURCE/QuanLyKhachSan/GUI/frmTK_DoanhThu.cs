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
    public partial class frmTK_DoanhThu : Form
    {
        public frmTK_DoanhThu()
        {
            InitializeComponent();
        }
        private void frmTK_DoanhThu_Load(object sender, EventArgs e)
        {
            loadDataGirdView();
            dgvDT.AutoResizeColumns();
            dgvDT.AutoResizeRows();
        }


        private void loadDataGirdView()
        {
            DAL.sqlConnect sql = new DAL.sqlConnect();
        }
        private void bntTK_Click(object sender, EventArgs e)
        {
            DAL.sqlConnect sql = new DAL.sqlConnect();
            dgvDT.DataSource = sql.TK("select l.MaLoaiPhong, l.TenLoaiPhong,p.GiaPhong from Phong p,LoaiPhong l where l.MaLoaiPhong=p.MaLoaiPhong");
        }
    }
}
