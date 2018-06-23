namespace QuanLySieuThiDienMay
{
    partial class frmBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanHang));
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.dateTPNgayLap = new System.Windows.Forms.DateTimePicker();
            this.dtgvHoaDon = new System.Windows.Forms.DataGridView();
            this.ColumnTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnGiam = new System.Windows.Forms.Button();
            this.btnTang = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTatCa = new System.Windows.Forms.Button();
            this.flowLPUC = new System.Windows.Forms.FlowLayoutPanel();
            this.flowlpLoaiSP = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTimKiem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).BeginInit();
            this.flowlpLoaiSP.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayLap.Location = new System.Drawing.Point(25, 19);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(53, 13);
            this.lblNgayLap.TabIndex = 36;
            this.lblNgayLap.Text = "Ngày Lập";
            // 
            // dateTPNgayLap
            // 
            this.dateTPNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTPNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTPNgayLap.Location = new System.Drawing.Point(126, 12);
            this.dateTPNgayLap.Name = "dateTPNgayLap";
            this.dateTPNgayLap.Size = new System.Drawing.Size(117, 22);
            this.dateTPNgayLap.TabIndex = 38;
            // 
            // dtgvHoaDon
            // 
            this.dtgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTenSP,
            this.ColumnSoLuong,
            this.ColumnGiaBan,
            this.ColumnThanhTien,
            this.MaSP});
            this.dtgvHoaDon.Location = new System.Drawing.Point(12, 59);
            this.dtgvHoaDon.Name = "dtgvHoaDon";
            this.dtgvHoaDon.ReadOnly = true;
            this.dtgvHoaDon.Size = new System.Drawing.Size(453, 289);
            this.dtgvHoaDon.TabIndex = 39;
            // 
            // ColumnTenSP
            // 
            this.ColumnTenSP.HeaderText = "Tên Sản phẩm";
            this.ColumnTenSP.Name = "ColumnTenSP";
            this.ColumnTenSP.ReadOnly = true;
            this.ColumnTenSP.Width = 150;
            // 
            // ColumnSoLuong
            // 
            this.ColumnSoLuong.HeaderText = "Số Lượng";
            this.ColumnSoLuong.Name = "ColumnSoLuong";
            this.ColumnSoLuong.ReadOnly = true;
            this.ColumnSoLuong.Width = 60;
            // 
            // ColumnGiaBan
            // 
            this.ColumnGiaBan.HeaderText = "Giá Bán";
            this.ColumnGiaBan.Name = "ColumnGiaBan";
            this.ColumnGiaBan.ReadOnly = true;
            // 
            // ColumnThanhTien
            // 
            this.ColumnThanhTien.HeaderText = "Thành Tiền";
            this.ColumnThanhTien.Name = "ColumnThanhTien";
            this.ColumnThanhTien.ReadOnly = true;
            // 
            // MaSP
            // 
            this.MaSP.HeaderText = "MaSP";
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(361, 363);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 70);
            this.btnXoa.TabIndex = 55;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnGiam
            // 
            this.btnGiam.Image = ((System.Drawing.Image)(resources.GetObject("btnGiam.Image")));
            this.btnGiam.Location = new System.Drawing.Point(211, 363);
            this.btnGiam.Name = "btnGiam";
            this.btnGiam.Size = new System.Drawing.Size(70, 70);
            this.btnGiam.TabIndex = 54;
            this.btnGiam.UseVisualStyleBackColor = true;
            this.btnGiam.Click += new System.EventHandler(this.btnGiam_Click);
            // 
            // btnTang
            // 
            this.btnTang.Image = ((System.Drawing.Image)(resources.GetObject("btnTang.Image")));
            this.btnTang.Location = new System.Drawing.Point(39, 363);
            this.btnTang.Name = "btnTang";
            this.btnTang.Size = new System.Drawing.Size(70, 70);
            this.btnTang.TabIndex = 53;
            this.btnTang.UseVisualStyleBackColor = true;
            this.btnTang.Click += new System.EventHandler(this.btnTang_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnHoaDon.Image")));
            this.btnHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.Location = new System.Drawing.Point(28, 457);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(157, 46);
            this.btnHoaDon.TabIndex = 56;
            this.btnHoaDon.Text = "Xuất Hóa Đơn";
            this.btnHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.ForeColor = System.Drawing.Color.Black;
            this.txtTongTien.Location = new System.Drawing.Point(343, 466);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(122, 29);
            this.txtTongTien.TabIndex = 58;
            this.txtTongTien.Text = "0";
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(249, 472);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(88, 20);
            this.lblTongTien.TabIndex = 57;
            this.lblTongTien.Text = "Tổng Tiền";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(1285, 15);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(34, 33);
            this.btnTimKiem.TabIndex = 67;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(1095, 20);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(184, 20);
            this.txtTimKiem.TabIndex = 66;
            // 
            // btnTatCa
            // 
            this.btnTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTatCa.Image = ((System.Drawing.Image)(resources.GetObject("btnTatCa.Image")));
            this.btnTatCa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTatCa.Location = new System.Drawing.Point(3, 3);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(74, 28);
            this.btnTatCa.TabIndex = 61;
            this.btnTatCa.Text = "Tất cả";
            this.btnTatCa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTatCa.UseVisualStyleBackColor = true;
            this.btnTatCa.Click += new System.EventHandler(this.btnTatCa_Click);
            // 
            // flowLPUC
            // 
            this.flowLPUC.AutoScroll = true;
            this.flowLPUC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.flowLPUC.Location = new System.Drawing.Point(525, 53);
            this.flowLPUC.Name = "flowLPUC";
            this.flowLPUC.Size = new System.Drawing.Size(722, 472);
            this.flowLPUC.TabIndex = 68;
            // 
            // flowlpLoaiSP
            // 
            this.flowlpLoaiSP.Controls.Add(this.btnTatCa);
            this.flowlpLoaiSP.Location = new System.Drawing.Point(489, 12);
            this.flowlpLoaiSP.Name = "flowlpLoaiSP";
            this.flowlpLoaiSP.Size = new System.Drawing.Size(600, 35);
            this.flowlpLoaiSP.TabIndex = 69;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(1087, 4);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(202, 13);
            this.lblTimKiem.TabIndex = 70;
            this.lblTimKiem.Text = "Tìm kiếm theo tên sản phẩm và nước SX.";
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 528);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.flowlpLoaiSP);
            this.Controls.Add(this.flowLPUC);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.btnHoaDon);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnGiam);
            this.Controls.Add(this.btnTang);
            this.Controls.Add(this.dtgvHoaDon);
            this.Controls.Add(this.dateTPNgayLap);
            this.Controls.Add(this.lblNgayLap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán Hàng";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).EndInit();
            this.flowlpLoaiSP.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.DateTimePicker dateTPNgayLap;
        private System.Windows.Forms.DataGridView dtgvHoaDon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnGiam;
        private System.Windows.Forms.Button btnTang;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTatCa;
        private System.Windows.Forms.FlowLayoutPanel flowLPUC;
        private System.Windows.Forms.FlowLayoutPanel flowlpLoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.Label lblTimKiem;
    }
}