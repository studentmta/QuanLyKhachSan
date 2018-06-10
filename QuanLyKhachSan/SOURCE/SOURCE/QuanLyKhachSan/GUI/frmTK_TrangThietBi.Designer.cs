namespace QuanLyKhachSan.GUI
{
    partial class frmTK_TrangThietBi
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
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.dgvTB = new System.Windows.Forms.DataGridView();
            this.bntTB = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bntTB);
            this.groupBox1.Controls.Add(this.dgvTB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trang Bị";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgvTB
            // 
            this.dgvTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTB.Location = new System.Drawing.Point(3, 16);
            this.dgvTB.Name = "dgvTB";
            this.dgvTB.Size = new System.Drawing.Size(654, 213);
            this.dgvTB.TabIndex = 0;
            // 
            // bntTB
            // 
            this.bntTB.Location = new System.Drawing.Point(480, 152);
            this.bntTB.Name = "bntTB";
            this.bntTB.Size = new System.Drawing.Size(106, 36);
            this.bntTB.TabIndex = 1;
            this.bntTB.Text = "Thống Kê";
            this.bntTB.UseVisualStyleBackColor = true;
            this.bntTB.Click += new System.EventHandler(this.bntTB_Click);
            // 
            // frmTK_TrangThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTK_TrangThietBi";
            this.Text = "frmTK_TrangThietBi";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button bntTB;
        private System.Windows.Forms.DataGridView dgvTB;
    }
}