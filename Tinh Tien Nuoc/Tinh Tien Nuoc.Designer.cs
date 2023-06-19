namespace Tinh_Tien_Nuoc
{
    partial class frmTinhTienNuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTinhTienNuoc));
            this.lbHoTen = new System.Windows.Forms.Label();
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txbDanhBo = new System.Windows.Forms.TextBox();
            this.lbDanhBo = new System.Windows.Forms.Label();
            this.lbKyHoaDon = new System.Windows.Forms.Label();
            this.nudThang = new System.Windows.Forms.NumericUpDown();
            this.lbSplash = new System.Windows.Forms.Label();
            this.nudNam = new System.Windows.Forms.NumericUpDown();
            this.lbLoaiGia = new System.Windows.Forms.Label();
            this.cbLoaiGia = new System.Windows.Forms.ComboBox();
            this.lbNhanKhau = new System.Windows.Forms.Label();
            this.txtNhanKhau = new System.Windows.Forms.TextBox();
            this.lbTieuThu = new System.Windows.Forms.Label();
            this.txtTieuThu = new System.Windows.Forms.TextBox();
            this.lbm3 = new System.Windows.Forms.Label();
            this.crvPhieuTinhTien = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txtPhiNuocThai = new System.Windows.Forms.TextBox();
            this.lbChiNhanhCapNuocSo2 = new System.Windows.Forms.Label();
            this.gbPhieuTinhTien = new System.Windows.Forms.GroupBox();
            this.txtNguoiLap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnLichSu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).BeginInit();
            this.gbPhieuTinhTien.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbHoTen.Location = new System.Drawing.Point(139, 44);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(49, 13);
            this.lbHoTen.TabIndex = 0;
            this.lbHoTen.Text = "Họ Tên";
            // 
            // txbHoTen
            // 
            this.txbHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHoTen.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txbHoTen.Location = new System.Drawing.Point(187, 41);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.Size = new System.Drawing.Size(451, 20);
            this.txbHoTen.TabIndex = 2;
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbDiaChi.Location = new System.Drawing.Point(7, 81);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(48, 13);
            this.lbDiaChi.TabIndex = 2;
            this.lbDiaChi.Text = "Địa Chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDiaChi.Location = new System.Drawing.Point(60, 78);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(417, 20);
            this.txtDiaChi.TabIndex = 3;
            // 
            // txbDanhBo
            // 
            this.txbDanhBo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbDanhBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDanhBo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txbDanhBo.Location = new System.Drawing.Point(60, 41);
            this.txbDanhBo.MaxLength = 7;
            this.txbDanhBo.Name = "txbDanhBo";
            this.txbDanhBo.Size = new System.Drawing.Size(65, 20);
            this.txbDanhBo.TabIndex = 1;
            this.txbDanhBo.TextChanged += new System.EventHandler(this.txbDanhBo_TextChanged);
            // 
            // lbDanhBo
            // 
            this.lbDanhBo.AutoSize = true;
            this.lbDanhBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhBo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbDanhBo.Location = new System.Drawing.Point(6, 44);
            this.lbDanhBo.Name = "lbDanhBo";
            this.lbDanhBo.Size = new System.Drawing.Size(56, 13);
            this.lbDanhBo.TabIndex = 5;
            this.lbDanhBo.Text = "Danh Bộ";
            // 
            // lbKyHoaDon
            // 
            this.lbKyHoaDon.AutoSize = true;
            this.lbKyHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKyHoaDon.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbKyHoaDon.Location = new System.Drawing.Point(7, 117);
            this.lbKyHoaDon.Name = "lbKyHoaDon";
            this.lbKyHoaDon.Size = new System.Drawing.Size(75, 13);
            this.lbKyHoaDon.TabIndex = 6;
            this.lbKyHoaDon.Text = "Kỳ Hóa Đơn";
            // 
            // nudThang
            // 
            this.nudThang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nudThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudThang.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nudThang.Location = new System.Drawing.Point(81, 115);
            this.nudThang.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudThang.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThang.Name = "nudThang";
            this.nudThang.Size = new System.Drawing.Size(44, 20);
            this.nudThang.TabIndex = 4;
            this.nudThang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThang.ValueChanged += new System.EventHandler(this.txbDanhBo_TextChanged);
            // 
            // lbSplash
            // 
            this.lbSplash.AutoSize = true;
            this.lbSplash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSplash.Location = new System.Drawing.Point(126, 115);
            this.lbSplash.Name = "lbSplash";
            this.lbSplash.Size = new System.Drawing.Size(13, 20);
            this.lbSplash.TabIndex = 8;
            this.lbSplash.Text = "/";
            // 
            // nudNam
            // 
            this.nudNam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nudNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNam.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nudNam.Location = new System.Drawing.Point(137, 115);
            this.nudNam.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.nudNam.Minimum = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            this.nudNam.Name = "nudNam";
            this.nudNam.Size = new System.Drawing.Size(53, 20);
            this.nudNam.TabIndex = 5;
            this.nudNam.Value = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            this.nudNam.ValueChanged += new System.EventHandler(this.txbDanhBo_TextChanged);
            // 
            // lbLoaiGia
            // 
            this.lbLoaiGia.AutoSize = true;
            this.lbLoaiGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiGia.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbLoaiGia.Location = new System.Drawing.Point(205, 117);
            this.lbLoaiGia.Name = "lbLoaiGia";
            this.lbLoaiGia.Size = new System.Drawing.Size(54, 13);
            this.lbLoaiGia.TabIndex = 10;
            this.lbLoaiGia.Text = "Loại Giá";
            // 
            // cbLoaiGia
            // 
            this.cbLoaiGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cbLoaiGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiGia.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbLoaiGia.FormattingEnabled = true;
            this.cbLoaiGia.Items.AddRange(new object[] {
            "D - HỘ DÂN",
            "K - KINH DOANH",
            "N - HỘ NGHÈO",
            "Q - CƠ QUAN",
            "S - S.X VẬT CHẤT"});
            this.cbLoaiGia.Location = new System.Drawing.Point(260, 114);
            this.cbLoaiGia.Name = "cbLoaiGia";
            this.cbLoaiGia.Size = new System.Drawing.Size(111, 21);
            this.cbLoaiGia.TabIndex = 6;
            // 
            // lbNhanKhau
            // 
            this.lbNhanKhau.AutoSize = true;
            this.lbNhanKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhanKhau.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbNhanKhau.Location = new System.Drawing.Point(377, 118);
            this.lbNhanKhau.Name = "lbNhanKhau";
            this.lbNhanKhau.Size = new System.Drawing.Size(70, 13);
            this.lbNhanKhau.TabIndex = 12;
            this.lbNhanKhau.Text = "Nhân Khẩu";
            // 
            // txtNhanKhau
            // 
            this.txtNhanKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhanKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhanKhau.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNhanKhau.Location = new System.Drawing.Point(445, 114);
            this.txtNhanKhau.Name = "txtNhanKhau";
            this.txtNhanKhau.Size = new System.Drawing.Size(52, 20);
            this.txtNhanKhau.TabIndex = 7;
            this.txtNhanKhau.TextChanged += new System.EventHandler(this.txtNhanKhau_TextChanged);
            // 
            // lbTieuThu
            // 
            this.lbTieuThu.AutoSize = true;
            this.lbTieuThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuThu.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbTieuThu.Location = new System.Drawing.Point(505, 118);
            this.lbTieuThu.Name = "lbTieuThu";
            this.lbTieuThu.Size = new System.Drawing.Size(58, 13);
            this.lbTieuThu.TabIndex = 14;
            this.lbTieuThu.Text = "Tiêu Thụ";
            // 
            // txtTieuThu
            // 
            this.txtTieuThu.BackColor = System.Drawing.Color.White;
            this.txtTieuThu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTieuThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTieuThu.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtTieuThu.Location = new System.Drawing.Point(561, 116);
            this.txtTieuThu.Name = "txtTieuThu";
            this.txtTieuThu.Size = new System.Drawing.Size(57, 20);
            this.txtTieuThu.TabIndex = 8;
            this.txtTieuThu.TextChanged += new System.EventHandler(this.txtTieuThu_TextChanged);
            // 
            // lbm3
            // 
            this.lbm3.AutoSize = true;
            this.lbm3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbm3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbm3.Location = new System.Drawing.Point(620, 118);
            this.lbm3.Name = "lbm3";
            this.lbm3.Size = new System.Drawing.Size(20, 13);
            this.lbm3.TabIndex = 16;
            this.lbm3.Text = "m³";
            // 
            // crvPhieuTinhTien
            // 
            this.crvPhieuTinhTien.ActiveViewIndex = -1;
            this.crvPhieuTinhTien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crvPhieuTinhTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvPhieuTinhTien.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvPhieuTinhTien.Location = new System.Drawing.Point(-2, 288);
            this.crvPhieuTinhTien.Name = "crvPhieuTinhTien";
            this.crvPhieuTinhTien.ShowCloseButton = false;
            this.crvPhieuTinhTien.ShowCopyButton = false;
            this.crvPhieuTinhTien.ShowGotoPageButton = false;
            this.crvPhieuTinhTien.ShowGroupTreeButton = false;
            this.crvPhieuTinhTien.ShowLogo = false;
            this.crvPhieuTinhTien.ShowPageNavigateButtons = false;
            this.crvPhieuTinhTien.ShowParameterPanelButton = false;
            this.crvPhieuTinhTien.ShowRefreshButton = false;
            this.crvPhieuTinhTien.ShowTextSearchButton = false;
            this.crvPhieuTinhTien.ShowZoomButton = false;
            this.crvPhieuTinhTien.Size = new System.Drawing.Size(800, 0);
            this.crvPhieuTinhTien.TabIndex = 17;
            this.crvPhieuTinhTien.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvPhieuTinhTien.Visible = false;
            // 
            // txtPhiNuocThai
            // 
            this.txtPhiNuocThai.Enabled = false;
            this.txtPhiNuocThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhiNuocThai.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPhiNuocThai.Location = new System.Drawing.Point(587, 78);
            this.txtPhiNuocThai.Name = "txtPhiNuocThai";
            this.txtPhiNuocThai.Size = new System.Drawing.Size(50, 20);
            this.txtPhiNuocThai.TabIndex = 19;
            this.txtPhiNuocThai.TextChanged += new System.EventHandler(this.txtPhiNuocThai_TextChanged);
            // 
            // lbChiNhanhCapNuocSo2
            // 
            this.lbChiNhanhCapNuocSo2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbChiNhanhCapNuocSo2.AutoSize = true;
            this.lbChiNhanhCapNuocSo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChiNhanhCapNuocSo2.ForeColor = System.Drawing.SystemColors.Info;
            this.lbChiNhanhCapNuocSo2.Location = new System.Drawing.Point(162, 23);
            this.lbChiNhanhCapNuocSo2.Name = "lbChiNhanhCapNuocSo2";
            this.lbChiNhanhCapNuocSo2.Size = new System.Drawing.Size(477, 50);
            this.lbChiNhanhCapNuocSo2.TabIndex = 20;
            this.lbChiNhanhCapNuocSo2.Text = "CÔNG TY CỔ PHẦN CẤP NƯỚC CẦN THƠ 2\r\nCHI NHÁNH CẤP NƯỚC SỐ 2";
            this.lbChiNhanhCapNuocSo2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbPhieuTinhTien
            // 
            this.gbPhieuTinhTien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbPhieuTinhTien.Controls.Add(this.txtNguoiLap);
            this.gbPhieuTinhTien.Controls.Add(this.label2);
            this.gbPhieuTinhTien.Controls.Add(this.label1);
            this.gbPhieuTinhTien.Controls.Add(this.btnTinhTien);
            this.gbPhieuTinhTien.Controls.Add(this.txbHoTen);
            this.gbPhieuTinhTien.Controls.Add(this.txtPhiNuocThai);
            this.gbPhieuTinhTien.Controls.Add(this.txbDanhBo);
            this.gbPhieuTinhTien.Controls.Add(this.lbHoTen);
            this.gbPhieuTinhTien.Controls.Add(this.lbDiaChi);
            this.gbPhieuTinhTien.Controls.Add(this.txtDiaChi);
            this.gbPhieuTinhTien.Controls.Add(this.lbm3);
            this.gbPhieuTinhTien.Controls.Add(this.lbDanhBo);
            this.gbPhieuTinhTien.Controls.Add(this.txtTieuThu);
            this.gbPhieuTinhTien.Controls.Add(this.lbKyHoaDon);
            this.gbPhieuTinhTien.Controls.Add(this.lbTieuThu);
            this.gbPhieuTinhTien.Controls.Add(this.nudThang);
            this.gbPhieuTinhTien.Controls.Add(this.txtNhanKhau);
            this.gbPhieuTinhTien.Controls.Add(this.lbSplash);
            this.gbPhieuTinhTien.Controls.Add(this.lbNhanKhau);
            this.gbPhieuTinhTien.Controls.Add(this.nudNam);
            this.gbPhieuTinhTien.Controls.Add(this.cbLoaiGia);
            this.gbPhieuTinhTien.Controls.Add(this.lbLoaiGia);
            this.gbPhieuTinhTien.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbPhieuTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPhieuTinhTien.ForeColor = System.Drawing.SystemColors.Info;
            this.gbPhieuTinhTien.Location = new System.Drawing.Point(37, 91);
            this.gbPhieuTinhTien.Name = "gbPhieuTinhTien";
            this.gbPhieuTinhTien.Size = new System.Drawing.Size(723, 178);
            this.gbPhieuTinhTien.TabIndex = 21;
            this.gbPhieuTinhTien.TabStop = false;
            this.gbPhieuTinhTien.Text = "Thông Tin Phiếu Tính Tiền";
            // 
            // txtNguoiLap
            // 
            this.txtNguoiLap.BackColor = System.Drawing.Color.White;
            this.txtNguoiLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoiLap.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNguoiLap.Location = new System.Drawing.Point(445, 146);
            this.txtNguoiLap.Name = "txtNguoiLap";
            this.txtNguoiLap.Size = new System.Drawing.Size(192, 20);
            this.txtNguoiLap.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(377, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Người Lập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(516, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Phí BVMT";
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTinhTien.BackgroundImage = global::Tinh_Tien_Nuoc.Properties.Resources.icon;
            this.btnTinhTien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTinhTien.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTinhTien.FlatAppearance.BorderSize = 0;
            this.btnTinhTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTien.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnTinhTien.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTinhTien.Location = new System.Drawing.Point(644, 54);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(74, 97);
            this.btnTinhTien.TabIndex = 18;
            this.btnTinhTien.UseVisualStyleBackColor = false;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnLichSu
            // 
            this.btnLichSu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLichSu.FlatAppearance.BorderSize = 0;
            this.btnLichSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichSu.Image = global::Tinh_Tien_Nuoc.Properties.Resources.Network_URL_History_icon;
            this.btnLichSu.Location = new System.Drawing.Point(731, 14);
            this.btnLichSu.Name = "btnLichSu";
            this.btnLichSu.Size = new System.Drawing.Size(54, 49);
            this.btnLichSu.TabIndex = 22;
            this.btnLichSu.UseVisualStyleBackColor = true;
            this.btnLichSu.Click += new System.EventHandler(this.btnLichSu_Click);
            // 
            // frmTinhTienNuoc
            // 
            this.AcceptButton = this.btnTinhTien;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(797, 273);
            this.Controls.Add(this.btnLichSu);
            this.Controls.Add(this.gbPhieuTinhTien);
            this.Controls.Add(this.lbChiNhanhCapNuocSo2);
            this.Controls.Add(this.crvPhieuTinhTien);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTinhTienNuoc";
            this.Text = "Tính Tiền Nước";
            this.Load += new System.EventHandler(this.frmTinhTienNuoc_Load);
            this.Shown += new System.EventHandler(this.frmTinhTienNuoc_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.nudThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).EndInit();
            this.gbPhieuTinhTien.ResumeLayout(false);
            this.gbPhieuTinhTien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.TextBox txbHoTen;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txbDanhBo;
        private System.Windows.Forms.Label lbDanhBo;
        private System.Windows.Forms.Label lbKyHoaDon;
        private System.Windows.Forms.NumericUpDown nudThang;
        private System.Windows.Forms.Label lbSplash;
        private System.Windows.Forms.NumericUpDown nudNam;
        private System.Windows.Forms.Label lbLoaiGia;
        private System.Windows.Forms.ComboBox cbLoaiGia;
        private System.Windows.Forms.Label lbNhanKhau;
        private System.Windows.Forms.TextBox txtNhanKhau;
        private System.Windows.Forms.Label lbTieuThu;
        private System.Windows.Forms.TextBox txtTieuThu;
        private System.Windows.Forms.Label lbm3;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvPhieuTinhTien;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.TextBox txtPhiNuocThai;
        private System.Windows.Forms.Label lbChiNhanhCapNuocSo2;
        private System.Windows.Forms.GroupBox gbPhieuTinhTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNguoiLap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLichSu;
    }
}

