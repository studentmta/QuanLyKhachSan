namespace QuanLyKhachSan.GUI
{
    partial class frmTK_TinhTrangPhong
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTTP = new System.Windows.Forms.DataGridView();
            this.bntTK = new System.Windows.Forms.Button();
            this.cbOption_ThongKe = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbOption_ThongKe);
            this.groupBox1.Controls.Add(this.bntTK);
            this.groupBox1.Controls.Add(this.dgvTTP);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 320);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tình Trạng Phòng";
            // 
            // dgvTTP
            // 
            this.dgvTTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTP.Location = new System.Drawing.Point(20, 92);
            this.dgvTTP.Name = "dgvTTP";
            this.dgvTTP.Size = new System.Drawing.Size(718, 205);
            this.dgvTTP.TabIndex = 0;
            // 
            // bntTK
            // 
            this.bntTK.Location = new System.Drawing.Point(423, 25);
            this.bntTK.Name = "bntTK";
            this.bntTK.Size = new System.Drawing.Size(121, 42);
            this.bntTK.TabIndex = 1;
            this.bntTK.Text = "Thống Kê";
            this.bntTK.UseVisualStyleBackColor = true;
            this.bntTK.Click += new System.EventHandler(this.bntTK_Click);
            // 
            // cbOption_ThongKe
            // 
            this.cbOption_ThongKe.FormattingEnabled = true;
            this.cbOption_ThongKe.Items.AddRange(new object[] {
            "Trống",
            "Full"});
            this.cbOption_ThongKe.Location = new System.Drawing.Point(51, 37);
            this.cbOption_ThongKe.Name = "cbOption_ThongKe";
            this.cbOption_ThongKe.Size = new System.Drawing.Size(306, 21);
            this.cbOption_ThongKe.TabIndex = 2;
            // 
            // frmTK_TinhTrangPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTK_TinhTrangPhong";
            this.Text = "frmTK_TinhTrangPhong";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTTP;
        private System.Windows.Forms.Button bntTK;
        private System.Windows.Forms.ComboBox cbOption_ThongKe;
    }
}