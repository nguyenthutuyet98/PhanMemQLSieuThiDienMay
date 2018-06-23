namespace QuanLySieuThiDienMay
{
    partial class frmBaoCaoDTTheoNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoDTTheoNhanVien));
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtTongOrder = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.dtgvHoaDon = new System.Windows.Forms.DataGridView();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.dtgvCTHD = new System.Windows.Forms.DataGridView();
            this.btnTim = new System.Windows.Forms.Button();
            this.lblTim = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnInHD = new System.Windows.Forms.Button();
            this.lblDSCTHD = new System.Windows.Forms.Label();
            this.lblDSHD = new System.Windows.Forms.Label();
            this.lblTongOrder = new System.Windows.Forms.Label();
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
            this.btnXemChiTiet.Location = new System.Drawing.Point(645, 73);
            this.btnXemChiTiet.Margin = new System.Windows.Forms.Padding(2);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(168, 57);
            this.btnXemChiTiet.TabIndex = 1;
            this.btnXemChiTiet.Text = "Xem c&hi tiết";
            this.btnXemChiTiet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtMaNV.Location = new System.Drawing.Point(116, 53);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(275, 26);
            this.txtMaNV.TabIndex = 0;
            this.txtMaNV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaNV_KeyDown);
            this.txtMaNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaNV_KeyPress);
            // 
            // txtTongOrder
            // 
            this.txtTongOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.txtTongOrder.Location = new System.Drawing.Point(696, 696);
            this.txtTongOrder.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongOrder.Name = "txtTongOrder";
            this.txtTongOrder.Size = new System.Drawing.Size(213, 26);
            this.txtTongOrder.TabIndex = 26;
            this.txtTongOrder.Text = "0";
            this.txtTongOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.txtTongTien.ForeColor = System.Drawing.Color.Red;
            this.txtTongTien.Location = new System.Drawing.Point(696, 651);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(213, 26);
            this.txtTongTien.TabIndex = 25;
            this.txtTongTien.Text = "0";
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtgvHoaDon
            // 
            this.dtgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHoaDon.Location = new System.Drawing.Point(11, 224);
            this.dtgvHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvHoaDon.Name = "dtgvHoaDon";
            this.dtgvHoaDon.ReadOnly = true;
            this.dtgvHoaDon.RowTemplate.Height = 24;
            this.dtgvHoaDon.Size = new System.Drawing.Size(430, 404);
            this.dtgvHoaDon.TabIndex = 2;
            this.dtgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHoaDon_CellClick);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(562, 657);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(75, 15);
            this.lblTongTien.TabIndex = 22;
            this.lblTongTien.Text = "Tổng Ti&ền:";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.Location = new System.Drawing.Point(16, 59);
            this.lblMaNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(53, 15);
            this.lblMaNV.TabIndex = 21;
            this.lblMaNV.Text = "Mã N&V:";
            // 
            // dtgvCTHD
            // 
            this.dtgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCTHD.Location = new System.Drawing.Point(446, 224);
            this.dtgvCTHD.Name = "dtgvCTHD";
            this.dtgvCTHD.ReadOnly = true;
            this.dtgvCTHD.Size = new System.Drawing.Size(502, 404);
            this.dtgvCTHD.TabIndex = 3;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(484, 77);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(105, 48);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "Tìm HĐ";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // lblTim
            // 
            this.lblTim.AutoSize = true;
            this.lblTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTim.Location = new System.Drawing.Point(16, 120);
            this.lblTim.Name = "lblTim";
            this.lblTim.Size = new System.Drawing.Size(59, 15);
            this.lblTim.TabIndex = 36;
            this.lblTim.Text = "Tìm HĐ:";
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtTim.Location = new System.Drawing.Point(116, 114);
            this.txtTim.Margin = new System.Windows.Forms.Padding(2);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(275, 26);
            this.txtTim.TabIndex = 4;
            this.txtTim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTim_KeyDown);
            this.txtTim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTim_KeyPress);
            // 
            // btnInHD
            // 
            this.btnInHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHD.Location = new System.Drawing.Point(188, 663);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(132, 45);
            this.btnInHD.TabIndex = 38;
            this.btnInHD.Text = "In H&Đ";
            this.btnInHD.UseVisualStyleBackColor = true;
            this.btnInHD.Click += new System.EventHandler(this.btnInHD_Click);
            // 
            // lblDSCTHD
            // 
            this.lblDSCTHD.AutoSize = true;
            this.lblDSCTHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSCTHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDSCTHD.Location = new System.Drawing.Point(524, 172);
            this.lblDSCTHD.Name = "lblDSCTHD";
            this.lblDSCTHD.Size = new System.Drawing.Size(333, 20);
            this.lblDSCTHD.TabIndex = 40;
            this.lblDSCTHD.Text = "BẢNG DANH SÁCH CHI TI&ẾT HÓA ĐƠN";
            // 
            // lblDSHD
            // 
            this.lblDSHD.AutoSize = true;
            this.lblDSHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDSHD.Location = new System.Drawing.Point(87, 172);
            this.lblDSHD.Name = "lblDSHD";
            this.lblDSHD.Size = new System.Drawing.Size(254, 20);
            this.lblDSHD.TabIndex = 39;
            this.lblDSHD.Text = "BẢNG DANH SÁCH H&ÓA ĐƠN";
            // 
            // lblTongOrder
            // 
            this.lblTongOrder.AutoSize = true;
            this.lblTongOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongOrder.Location = new System.Drawing.Point(562, 702);
            this.lblTongOrder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongOrder.Name = "lblTongOrder";
            this.lblTongOrder.Size = new System.Drawing.Size(83, 15);
            this.lblTongOrder.TabIndex = 41;
            this.lblTongOrder.Text = "Tổng Or&der:";
            // 
            // frmBaoCaoDTTheoNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 736);
            this.Controls.Add(this.lblTongOrder);
            this.Controls.Add(this.lblDSCTHD);
            this.Controls.Add(this.lblDSHD);
            this.Controls.Add(this.btnInHD);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.lblTim);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dtgvCTHD);
            this.Controls.Add(this.btnXemChiTiet);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtTongOrder);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.dtgvHoaDon);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblMaNV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBaoCaoDTTheoNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Doanh Thu Theo Nhân Viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBaoCaoDTTheoNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.frmBaoCaoDTTheoNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtTongOrder;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.DataGridView dtgvHoaDon;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.DataGridView dtgvCTHD;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label lblTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.Label lblDSCTHD;
        private System.Windows.Forms.Label lblDSHD;
        private System.Windows.Forms.Label lblTongOrder;
    }
}