namespace Tinh_Tien_Nuoc
{
    partial class frmHistory
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
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.DANHBO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KYHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NHANKHAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIEUTHU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHINUOCTHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THOIGIAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DANHBO,
            this.TENKH,
            this.DIACHI,
            this.KYHD,
            this.GIA,
            this.NHANKHAU,
            this.TIEUTHU,
            this.PHINUOCTHAI,
            this.TONGTIEN,
            this.THOIGIAN});
            this.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistory.Location = new System.Drawing.Point(0, 0);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.Size = new System.Drawing.Size(727, 248);
            this.dgvHistory.TabIndex = 0;
            // 
            // DANHBO
            // 
            this.DANHBO.HeaderText = "DANH BỘ";
            this.DANHBO.Name = "DANHBO";
            this.DANHBO.ReadOnly = true;
            // 
            // TENKH
            // 
            this.TENKH.HeaderText = "TÊN KH";
            this.TENKH.Name = "TENKH";
            this.TENKH.ReadOnly = true;
            // 
            // DIACHI
            // 
            this.DIACHI.HeaderText = "ĐỊA CHỈ";
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.ReadOnly = true;
            // 
            // KYHD
            // 
            this.KYHD.HeaderText = "KỲ HĐ";
            this.KYHD.Name = "KYHD";
            this.KYHD.ReadOnly = true;
            // 
            // GIA
            // 
            this.GIA.HeaderText = "GIÁ";
            this.GIA.Name = "GIA";
            this.GIA.ReadOnly = true;
            // 
            // NHANKHAU
            // 
            this.NHANKHAU.HeaderText = "NHÂN KHẨU";
            this.NHANKHAU.Name = "NHANKHAU";
            this.NHANKHAU.ReadOnly = true;
            // 
            // TIEUTHU
            // 
            this.TIEUTHU.HeaderText = "TIÊU THỤ";
            this.TIEUTHU.Name = "TIEUTHU";
            this.TIEUTHU.ReadOnly = true;
            // 
            // PHINUOCTHAI
            // 
            this.PHINUOCTHAI.HeaderText = "PHÍ NƯỚC THẢI";
            this.PHINUOCTHAI.Name = "PHINUOCTHAI";
            this.PHINUOCTHAI.ReadOnly = true;
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.HeaderText = "TỔNG TIỀN";
            this.TONGTIEN.Name = "TONGTIEN";
            this.TONGTIEN.ReadOnly = true;
            // 
            // THOIGIAN
            // 
            this.THOIGIAN.HeaderText = "THỜI GIAN";
            this.THOIGIAN.Name = "THOIGIAN";
            this.THOIGIAN.ReadOnly = true;
            // 
            // frmHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 248);
            this.Controls.Add(this.dgvHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "History";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.frmHistory_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn DANHBO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn KYHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NHANKHAU;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIEUTHU;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHINUOCTHAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn THOIGIAN;
    }
}