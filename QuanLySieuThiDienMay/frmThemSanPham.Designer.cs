namespace QuanLySieuThiDienMay
{
    partial class frmThemSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemSanPham));
            this.cbxLoaiSP = new System.Windows.Forms.ComboBox();
            this.lblTTSP = new System.Windows.Forms.Label();
            this.txtNuocSX = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.lblNuocSX = new System.Windows.Forms.Label();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.lblLoaiSP = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.pbHinh = new System.Windows.Forms.PictureBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxLoaiSP
            // 
            this.cbxLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbxLoaiSP.FormattingEnabled = true;
            this.cbxLoaiSP.Location = new System.Drawing.Point(146, 167);
            this.cbxLoaiSP.Name = "cbxLoaiSP";
            this.cbxLoaiSP.Size = new System.Drawing.Size(266, 28);
            this.cbxLoaiSP.TabIndex = 2;
            this.cbxLoaiSP.SelectedIndexChanged += new System.EventHandler(this.cbxLoaiSP_SelectedIndexChanged);
            this.cbxLoaiSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxLoaiSP_KeyPress);
            // 
            // lblTTSP
            // 
            this.lblTTSP.AutoSize = true;
            this.lblTTSP.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTTSP.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTTSP.Location = new System.Drawing.Point(198, 20);
            this.lblTTSP.Name = "lblTTSP";
            this.lblTTSP.Size = new System.Drawing.Size(273, 32);
            this.lblTTSP.TabIndex = 57;
            this.lblTTSP.Text = "Thông Tin Sản Phẩm";
            this.lblTTSP.Click += new System.EventHandler(this.lblTTSP_Click);
            // 
            // txtNuocSX
            // 
            this.txtNuocSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtNuocSX.Location = new System.Drawing.Point(146, 284);
            this.txtNuocSX.Name = "txtNuocSX";
            this.txtNuocSX.Size = new System.Drawing.Size(266, 26);
            this.txtNuocSX.TabIndex = 4;
            this.txtNuocSX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNuocSX_KeyDown);
            this.txtNuocSX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNuocSX_KeyPress);
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtGiaBan.Location = new System.Drawing.Point(146, 226);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(266, 26);
            this.txtGiaBan.TabIndex = 3;
            this.txtGiaBan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGiaBan_KeyDown);
            this.txtGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaBan_KeyPress);
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtTenSP.Location = new System.Drawing.Point(146, 102);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(266, 26);
            this.txtTenSP.TabIndex = 1;
            this.txtTenSP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenSP_KeyDown);
            this.txtTenSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenSP_KeyPress);
            // 
            // lblNuocSX
            // 
            this.lblNuocSX.AutoSize = true;
            this.lblNuocSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblNuocSX.Location = new System.Drawing.Point(55, 284);
            this.lblNuocSX.Name = "lblNuocSX";
            this.lblNuocSX.Size = new System.Drawing.Size(75, 20);
            this.lblNuocSX.TabIndex = 52;
            this.lblNuocSX.Text = "Nước SX";
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblGiaBan.Location = new System.Drawing.Point(55, 229);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(70, 20);
            this.lblGiaBan.TabIndex = 51;
            this.lblGiaBan.Text = "Gía Bán";
            // 
            // lblLoaiSP
            // 
            this.lblLoaiSP.AutoSize = true;
            this.lblLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblLoaiSP.Location = new System.Drawing.Point(54, 170);
            this.lblLoaiSP.Name = "lblLoaiSP";
            this.lblLoaiSP.Size = new System.Drawing.Size(96, 20);
            this.lblLoaiSP.TabIndex = 50;
            this.lblLoaiSP.Text = "Mã Loại SP";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblTenSP.Location = new System.Drawing.Point(55, 105);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(64, 20);
            this.lblTenSP.TabIndex = 49;
            this.lblTenSP.Text = "Tên SP";
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(322, 347);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(73, 37);
            this.btnXoa.TabIndex = 111;
            this.btnXoa.Text = "Thoát";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(146, 347);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 37);
            this.btnThem.TabIndex = 110;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // pbHinh
            // 
            this.pbHinh.Image = ((System.Drawing.Image)(resources.GetObject("pbHinh.Image")));
            this.pbHinh.InitialImage = null;
            this.pbHinh.Location = new System.Drawing.Point(512, 102);
            this.pbHinh.Name = "pbHinh";
            this.pbHinh.Size = new System.Drawing.Size(193, 165);
            this.pbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHinh.TabIndex = 112;
            this.pbHinh.TabStop = false;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnChonAnh.Location = new System.Drawing.Point(537, 284);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(106, 34);
            this.btnChonAnh.TabIndex = 113;
            this.btnChonAnh.Text = "Chọn Ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // frmThemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 460);
            this.Controls.Add(this.btnChonAnh);
            this.Controls.Add(this.pbHinh);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbxLoaiSP);
            this.Controls.Add(this.lblTTSP);
            this.Controls.Add(this.txtNuocSX);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.lblNuocSX);
            this.Controls.Add(this.lblGiaBan);
            this.Controls.Add(this.lblLoaiSP);
            this.Controls.Add(this.lblTenSP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThemSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Sản Phẩm";
            this.Load += new System.EventHandler(this.frmThemSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxLoaiSP;
        private System.Windows.Forms.Label lblTTSP;
        private System.Windows.Forms.TextBox txtNuocSX;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label lblNuocSX;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.Label lblLoaiSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.PictureBox pbHinh;
        private System.Windows.Forms.Button btnChonAnh;
    }
}