using System;
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
    public partial class frmTK_DSNhanVien : Form
    {
        public frmTK_DSNhanVien()
        {
            InitializeComponent();
        }

        private void frmTK_DSNhanVien_Load(object sender, EventArgs e)
        {
            loadDataGirdView();
            dgvNhanVien.AutoResizeColumns();
            dgvNhanVien.AutoResizeRows();
        }

       
        private void loadDataGirdView()
        {
            DAL.sqlConnect sql = new DAL.sqlConnect();
        }

        private void bntTK_Click(object sender, EventArgs e)
        {
            DAL.sqlConnect sql = new DAL.sqlConnect();
            dgvNhanVien.DataSource = sql.TK("select MaNV, TenNV,GioiTinh, NgaySinh, DiaChi,SDT,C.MaChucVu from NhanVien n, ChucVu C where n.MaChucVu=C.MaChucVu ");
           
        }
    }
}
