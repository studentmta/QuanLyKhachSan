namespace QuanLyKhachSan.GUI
{
    partial class frmPhieuDangKy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colQuocTich = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.colSoDienThoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cmbValue = new System.Windows.Forms.TextBox();
            this.cmbKey = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTraTruoc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.colDanToc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvNhanVien = new System.Windows.Forms.ListView();
            this.colNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtMaPhieuDK = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtNgayDi = new System.Windows.Forms.DateTimePicker();
            this.dtNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colQuocTich
            // 
            this.colQuocTich.Text = "Trả trước";
            this.colQuocTich.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colQuocTich.Width = 103;
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::QuanLyKhachSan.Properties.Resources.if_Remove_27874;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(647, 217);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(72, 32);
            this.btnHuy.TabIndex = 29;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::QuanLyKhachSan.Properties.Resources.if_save_all_1847;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(539, 217);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(72, 32);
            this.btnLuu.TabIndex = 28;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLyKhachSan.Properties.Resources.if_basket_1814090;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(431, 217);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(72, 32);
            this.btnXoa.TabIndex = 27;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QuanLyKhachSan.Properties.Resources.if_Settings_131786;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(323, 217);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(72, 32);
            this.btnSua.TabIndex = 26;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Image = global::QuanLyKhachSan.Properties.Resources.if_add1__32378;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(215, 217);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(72, 32);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(38, 35);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(93, 13);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "Mã phiếu đăng ký";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(38, 64);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(82, 13);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Mã khách hàng";
            // 
            // colSoDienThoai
            // 
            this.colSoDienThoai.Text = "Đơn vị";
            this.colSoDienThoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSoDienThoai.Width = 114;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(696, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã nhân viên";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btnTimKiem);
            this.groupBox3.Controls.Add(this.cmbValue);
            this.groupBox3.Controls.Add(this.cmbKey);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(851, 22);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(622, 0);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // cmbValue
            // 
            this.cmbValue.Location = new System.Drawing.Point(386, 1);
            this.cmbValue.Multiline = true;
            this.cmbValue.Name = "cmbValue";
            this.cmbValue.Size = new System.Drawing.Size(237, 21);
            this.cmbValue.TabIndex = 2;
            // 
            // cmbKey
            // 
            this.cmbKey.FormattingEnabled = true;
            this.cmbKey.Items.AddRange(new object[] {
            "Mã đăng ký",
            "Mã khách hàng",
            "Mã nhân viên",
            "Mã phòng",
            "Đơn vị"});
            this.cmbKey.Location = new System.Drawing.Point(265, 1);
            this.cmbKey.Name = "cmbKey";
            this.cmbKey.Size = new System.Drawing.Size(121, 21);
            this.cmbKey.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm theo";
            // 
            // colDiaChi
            // 
            this.colDiaChi.Text = "Ngày đi";
            this.colDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDiaChi.Width = 115;
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(492, 92);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(301, 20);
            this.txtDonVi.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(414, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mã phòng";
            // 
            // txtTraTruoc
            // 
            this.txtTraTruoc.Location = new System.Drawing.Point(492, 61);
            this.txtTraTruoc.Name = "txtTraTruoc";
            this.txtTraTruoc.Size = new System.Drawing.Size(301, 20);
            this.txtTraTruoc.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(412, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Trả trước";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(492, 32);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(301, 20);
            this.txtMaPhong.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(412, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Đơn vị";
            // 
            // colDanToc
            // 
            this.colDanToc.Text = "Mã phòng";
            this.colDanToc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDanToc.Width = 90;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.Text = "Mã nhân viên";
            this.colGioiTinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colGioiTinh.Width = 100;
            // 
            // colHoTen
            // 
            this.colHoTen.Text = "Mã khách hàng";
            this.colHoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHoTen.Width = 104;
            // 
            // colMaNV
            // 
            this.colMaNV.Text = "Mã phiếu đăng ký";
            this.colMaNV.Width = 106;
            // 
            // lsvNhanVien
            // 
            this.lsvNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaNV,
            this.colHoTen,
            this.colGioiTinh,
            this.colNgaySinh,
            this.colDiaChi,
            this.colDanToc,
            this.colQuocTich,
            this.colSoDienThoai});
            this.lsvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvNhanVien.Location = new System.Drawing.Point(3, 16);
            this.lsvNhanVien.Name = "lsvNhanVien";
            this.lsvNhanVien.Size = new System.Drawing.Size(845, 125);
            this.lsvNhanVien.TabIndex = 0;
            this.lsvNhanVien.UseCompatibleStateImageBehavior = false;
            this.lsvNhanVien.View = System.Windows.Forms.View.Details;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Text = "Ngày lập";
            this.colNgaySinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colNgaySinh.Width = 109;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lsvNhanVien);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 38);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(851, 144);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(857, 185);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(131, 92);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(244, 20);
            this.txtMaNV.TabIndex = 14;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(131, 61);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(244, 20);
            this.txtMaKH.TabIndex = 13;
            // 
            // txtMaPhieuDK
            // 
            this.txtMaPhieuDK.Location = new System.Drawing.Point(131, 32);
            this.txtMaPhieuDK.Name = "txtMaPhieuDK";
            this.txtMaPhieuDK.Size = new System.Drawing.Size(244, 20);
            this.txtMaPhieuDK.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtNgayDi);
            this.groupBox1.Controls.Add(this.dtNgayLap);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.lblMaNV);
            this.groupBox1.Controls.Add(this.lblHoTen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDonVi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTraTruoc);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtMaPhong);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.txtMaPhieuDK);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(857, 265);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu đăng ký";
            // 
            // dtNgayDi
            // 
            this.dtNgayDi.CustomFormat = "";
            this.dtNgayDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayDi.Location = new System.Drawing.Point(131, 153);
            this.dtNgayDi.Name = "dtNgayDi";
            this.dtNgayDi.Size = new System.Drawing.Size(244, 22);
            this.dtNgayDi.TabIndex = 33;
            // 
            // dtNgayLap
            // 
            this.dtNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayLap.Location = new System.Drawing.Point(131, 122);
            this.dtNgayLap.Name = "dtNgayLap";
            this.dtNgayLap.Size = new System.Drawing.Size(244, 22);
            this.dtNgayLap.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Ngày đi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Ngày lập";
            // 
            // frmPhieuDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPhieuDangKy";
            this.Text = "Phiếu đăng ký";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader colQuocTich;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.ColumnHeader colSoDienThoai;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox cmbValue;
        private System.Windows.Forms.ComboBox cmbKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader colDiaChi;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTraTruoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColumnHeader colDanToc;
        private System.Windows.Forms.ColumnHeader colGioiTinh;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colMaNV;
        private System.Windows.Forms.ListView lsvNhanVien;
        private System.Windows.Forms.ColumnHeader colNgaySinh;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtMaPhieuDK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtNgayDi;
        private System.Windows.Forms.DateTimePicker dtNgayLap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}