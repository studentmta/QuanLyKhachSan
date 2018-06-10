namespace QuanLyKhachSan.GUI
{
    partial class frmTK_DoanhThu
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvDT = new System.Windows.Forms.DataGridView();
            this.bntTK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDT)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bntTK);
            this.groupBox1.Controls.Add(this.dgvDT);
            this.groupBox1.Location = new System.Drawing.Point(35, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doanh thu theo loại phòng";
            // 
            // dgvDT
            // 
            this.dgvDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDT.Location = new System.Drawing.Point(27, 19);
            this.dgvDT.Name = "dgvDT";
            this.dgvDT.Size = new System.Drawing.Size(656, 202);
            this.dgvDT.TabIndex = 0;
            // 
            // bntTK
            // 
            this.bntTK.Location = new System.Drawing.Point(538, 178);
            this.bntTK.Name = "bntTK";
            this.bntTK.Size = new System.Drawing.Size(110, 27);
            this.bntTK.TabIndex = 2;
            this.bntTK.Text = "Thống Kê";
            this.bntTK.UseVisualStyleBackColor = true;
            this.bntTK.Click += new System.EventHandler(this.bntTK_Click);
            // 
            // frmTK_DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 288);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTK_DoanhThu";
            this.Text = "frmTK_DoanhThu";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button bntTK;
        private System.Windows.Forms.DataGridView dgvDT;
    }
}