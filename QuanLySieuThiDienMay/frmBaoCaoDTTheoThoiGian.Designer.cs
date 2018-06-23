namespace QuanLySieuThiDienMay
{
    partial class frmBaoCaoDTTheoThoiGian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoDTTheoThoiGian));
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.dtgvHoaDon = new System.Windows.Forms.DataGridView();
            this.txtTongOrder = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.lblTongOrder = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblNgayKetThuc = new System.Windows.Forms.Label();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.dtgvCTHD = new System.Windows.Forms.DataGridView();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.lblTim = new System.Windows.Forms.Label();
            this.btnInHD = new System.Windows.Forms.Button();
            this.lblDSHD = new System.Windows.Forms.Label();
            this.lblDSCTHD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemChiTiet.ForeColor = System.Drawing.Color.Red;
            this.btnXemChiTiet.Image = ((System.Drawing.Image)(resources.GetObject("btnXemChiTiet.Image")));
            this.btnXemChiTiet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemChiTiet.Location = new System.Drawing.Point(669, 54);
            this.btnXemChiTiet.Margin = new System.Windows.Forms.Padding(2);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(171, 69);
            this.btnXemChiTiet.TabIndex = 2;
            this.btnXemChiTiet.Text = "Xem c&hi tiết";
            this.btnXemChiTiet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // dtgvHoaDon
            // 
            this.dtgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHoaDon.Location = new System.Drawing.Point(11, 259);
            this.dtgvHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvHoaDon.Name = "dtgvHoaDon";
            this.dtgvHoaDon.ReadOnly = true;
            this.dtgvHoaDon.RowTemplate.Height = 24;
            this.dtgvHoaDon.Size = new System.Drawing.Size(448, 415);
            this.dtgvHoaDon.TabIndex = 3;
            this.dtgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHoaDon_CellClick);
            // 
            // txtTongOrder
            // 
            this.txtTongOrder.Enabled = false;
            this.txtTongOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtTongOrder.Location = new System.Drawing.Point(725, 707);
            this.txtTongOrder.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongOrder.Name = "txtTongOrder";
            this.txtTongOrder.Size = new System.Drawing.Size(176, 26);
            this.txtTongOrder.TabIndex = 17;
            this.txtTongOrder.Text = "0";
            this.txtTongOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtTongTien.ForeColor = System.Drawing.Color.Red;
            this.txtTongTien.Location = new System.Drawing.Point(401, 707);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(176, 26);
            this.txtTongTien.TabIndex = 16;
            this.txtTongTien.Text = "0";
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(123, 83);
            this.dtpNgayKetThuc.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(213, 26);
            this.dtpNgayKetThuc.TabIndex = 1;
            this.dtpNgayKetThuc.ValueChanged += new System.EventHandler(this.dtpNgayKetThuc_ValueChanged);
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(123, 29);
            this.dtpNgayBatDau.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(213, 26);
            this.dtpNgayBatDau.TabIndex = 0;
            this.dtpNgayBatDau.ValueChanged += new System.EventHandler(this.dtpNgayBatDau_ValueChanged);
            // 
            // lblTongOrder
            // 
            this.lblTongOrder.AutoSize = true;
            this.lblTongOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongOrder.ForeColor = System.Drawing.Color.Red;
            this.lblTongOrder.Location = new System.Drawing.Point(630, 714);
            this.lblTongOrder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongOrder.Name = "lblTongOrder";
            this.lblTongOrder.Size = new System.Drawing.Size(83, 15);
            this.lblTongOrder.TabIndex = 13;
            this.lblTongOrder.Text = "Tổng Or&der:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(306, 713);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(75, 15);
            this.lblTongTien.TabIndex = 12;
            this.lblTongTien.Text = "Tổng Ti&ền:";
            // 
            // lblNgayKetThuc
            // 
            this.lblNgayKetThuc.AutoSize = true;
            this.lblNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayKetThuc.Location = new System.Drawing.Point(17, 88);
            this.lblNgayKetThuc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayKetThuc.Name = "lblNgayKetThuc";
            this.lblNgayKetThuc.Size = new System.Drawing.Size(91, 13);
            this.lblNgayKetThuc.TabIndex = 11;
            this.lblNgayKetThuc.Text = "Ngày k&ết thúc:";
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.AutoSize = true;
            this.lblNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayBatDau.Location = new System.Drawing.Point(17, 39);
            this.lblNgayBatDau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(88, 13);
            this.lblNgayBatDau.TabIndex = 10;
            this.lblNgayBatDau.Text = "Ngày b&ắt đầu:";
            // 
            // dtgvCTHD
            // 
            this.dtgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCTHD.Location = new System.Drawing.Point(464, 259);
            this.dtgvCTHD.Name = "dtgvCTHD";
            this.dtgvCTHD.ReadOnly = true;
            this.dtgvCTHD.Size = new System.Drawing.Size(453, 415);
            this.dtgvCTHD.TabIndex = 4;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(464, 68);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(171, 41);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = " Tìm HĐ";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtTim.Location = new System.Drawing.Point(123, 131);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(213, 26);
            this.txtTim.TabIndex = 5;
            this.txtTim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTim_KeyDown);
            this.txtTim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTim_KeyPress);
            // 
            // lblTim
            // 
            this.lblTim.AutoSize = true;
            this.lblTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTim.Location = new System.Drawing.Point(17, 138);
            this.lblTim.Name = "lblTim";
            this.lblTim.Size = new System.Drawing.Size(53, 13);
            this.lblTim.TabIndex = 23;
            this.lblTim.Text = "Tìm HĐ:";
            // 
            // btnInHD
            // 
            this.btnInHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHD.Location = new System.Drawing.Point(135, 704);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(89, 29);
            this.btnInHD.TabIndex = 24;
            this.btnInHD.Text = "In HĐ";
            this.btnInHD.UseVisualStyleBackColor = true;
            this.btnInHD.Click += new System.EventHandler(this.btnInHD_Click);
            // 
            // lblDSHD
            // 
            this.lblDSHD.AutoSize = true;
            this.lblDSHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDSHD.Location = new System.Drawing.Point(94, 204);
            this.lblDSHD.Name = "lblDSHD";
            this.lblDSHD.Size = new System.Drawing.Size(254, 20);
            this.lblDSHD.TabIndex = 25;
            this.lblDSHD.Text = "BẢNG DANH SÁCH H&ÓA ĐƠN";
            // 
            // lblDSCTHD
            // 
            this.lblDSCTHD.AutoSize = true;
            this.lblDSCTHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSCTHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDSCTHD.Location = new System.Drawing.Point(531, 204);
            this.lblDSCTHD.Name = "lblDSCTHD";
            this.lblDSCTHD.Size = new System.Drawing.Size(333, 20);
            this.lblDSCTHD.TabIndex = 26;
            this.lblDSCTHD.Text = "BẢNG DANH SÁCH CHI TI&ẾT HÓA ĐƠN";
            // 
            // frmBaoCaoDTTheoThoiGian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 749);
            this.Controls.Add(this.lblDSCTHD);
            this.Controls.Add(this.lblDSHD);
            this.Controls.Add(this.btnInHD);
            this.Controls.Add(this.lblTim);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dtgvCTHD);
            this.Controls.Add(this.btnXemChiTiet);
            this.Controls.Add(this.dtgvHoaDon);
            this.Controls.Add(this.txtTongOrder);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.dtpNgayKetThuc);
            this.Controls.Add(this.dtpNgayBatDau);
            this.Controls.Add(this.lblTongOrder);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblNgayKetThuc);
            this.Controls.Add(this.lblNgayBatDau);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBaoCaoDTTheoThoiGian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Doanh Thu Theo Thời Gian";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBaoCaoDTTheoThoiGian_FormClosing);
            this.Load += new System.EventHandler(this.frmBaoCaoDTTheoThoiGian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.DataGridView dtgvHoaDon;
        private System.Windows.Forms.TextBox txtTongOrder;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Label lblTongOrder;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblNgayKetThuc;
        private System.Windows.Forms.Label lblNgayBatDau;
        private System.Windows.Forms.DataGridView dtgvCTHD;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label lblTim;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.Label lblDSHD;
        private System.Windows.Forms.Label lblDSCTHD;
    }
}