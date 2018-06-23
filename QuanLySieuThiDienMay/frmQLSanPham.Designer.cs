namespace QuanLySieuThiDienMay
{
    partial class frmQLSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLSanPham));
            this.cbxLoaiSP = new System.Windows.Forms.ComboBox();
            this.dtgvSP = new System.Windows.Forms.DataGridView();
            this.pbHinh = new System.Windows.Forms.PictureBox();
            this.lblTTSP = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXOa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtNuocSX = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lblNuocSX = new System.Windows.Forms.Label();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.lblLoaiSP = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.ckbKinhDoanh = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxLoaiSP
            // 
            this.cbxLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbxLoaiSP.FormattingEnabled = true;
            this.cbxLoaiSP.Location = new System.Drawing.Point(869, 210);
            this.cbxLoaiSP.Name = "cbxLoaiSP";
            this.cbxLoaiSP.Size = new System.Drawing.Size(266, 28);
            this.cbxLoaiSP.TabIndex = 3;
            this.cbxLoaiSP.SelectedIndexChanged += new System.EventHandler(this.cbxLoaiSP_SelectedIndexChanged);
            this.cbxLoaiSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxLoaiSP_KeyPress);
            // 
            // dtgvSP
            // 
            this.dtgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSP.Location = new System.Drawing.Point(12, 23);
            this.dtgvSP.Name = "dtgvSP";
            this.dtgvSP.ReadOnly = true;
            this.dtgvSP.Size = new System.Drawing.Size(745, 352);
            this.dtgvSP.TabIndex = 64;
            this.dtgvSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSP_CellClick);
            this.dtgvSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSP_CellContentClick);
            // 
            // pbHinh
            // 
            this.pbHinh.Image = ((System.Drawing.Image)(resources.GetObject("pbHinh.Image")));
            this.pbHinh.Location = new System.Drawing.Point(1168, 102);
            this.pbHinh.Name = "pbHinh";
            this.pbHinh.Size = new System.Drawing.Size(182, 158);
            this.pbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHinh.TabIndex = 63;
            this.pbHinh.TabStop = false;
            // 
            // lblTTSP
            // 
            this.lblTTSP.AutoSize = true;
            this.lblTTSP.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTTSP.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTTSP.Location = new System.Drawing.Point(845, 23);
            this.lblTTSP.Name = "lblTTSP";
            this.lblTTSP.Size = new System.Drawing.Size(273, 32);
            this.lblTTSP.TabIndex = 62;
            this.lblTTSP.Text = "Thông Tin Sản Phẩm";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(999, 422);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(119, 42);
            this.btnCapNhat.TabIndex = 61;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXOa
            // 
            this.btnXOa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnXOa.Image = ((System.Drawing.Image)(resources.GetObject("btnXOa.Image")));
            this.btnXOa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXOa.Location = new System.Drawing.Point(504, 494);
            this.btnXOa.Name = "btnXOa";
            this.btnXOa.Size = new System.Drawing.Size(97, 42);
            this.btnXOa.TabIndex = 60;
            this.btnXOa.Text = "Xóa";
            this.btnXOa.UseVisualStyleBackColor = true;
            this.btnXOa.Click += new System.EventHandler(this.btnXOa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(253, 494);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 42);
            this.btnThem.TabIndex = 59;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtTimKiem.Location = new System.Drawing.Point(274, 430);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(266, 26);
            this.txtTimKiem.TabIndex = 58;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(560, 424);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(41, 38);
            this.btnTimKiem.TabIndex = 57;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtNuocSX
            // 
            this.txtNuocSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtNuocSX.Location = new System.Drawing.Point(869, 327);
            this.txtNuocSX.Name = "txtNuocSX";
            this.txtNuocSX.Size = new System.Drawing.Size(266, 26);
            this.txtNuocSX.TabIndex = 5;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtGiaBan.Location = new System.Drawing.Point(869, 269);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(266, 26);
            this.txtGiaBan.TabIndex = 4;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtTenSP.Location = new System.Drawing.Point(869, 145);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(266, 26);
            this.txtTenSP.TabIndex = 2;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtMaSP.Location = new System.Drawing.Point(869, 81);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(266, 26);
            this.txtMaSP.TabIndex = 1;
            // 
            // lblNuocSX
            // 
            this.lblNuocSX.AutoSize = true;
            this.lblNuocSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblNuocSX.Location = new System.Drawing.Point(778, 327);
            this.lblNuocSX.Name = "lblNuocSX";
            this.lblNuocSX.Size = new System.Drawing.Size(75, 20);
            this.lblNuocSX.TabIndex = 52;
            this.lblNuocSX.Text = "Nước SX";
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblGiaBan.Location = new System.Drawing.Point(778, 272);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(70, 20);
            this.lblGiaBan.TabIndex = 51;
            this.lblGiaBan.Text = "Gía Bán";
            // 
            // lblLoaiSP
            // 
            this.lblLoaiSP.AutoSize = true;
            this.lblLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblLoaiSP.Location = new System.Drawing.Point(778, 210);
            this.lblLoaiSP.Name = "lblLoaiSP";
            this.lblLoaiSP.Size = new System.Drawing.Size(68, 20);
            this.lblLoaiSP.TabIndex = 50;
            this.lblLoaiSP.Text = "Loại SP";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblTenSP.Location = new System.Drawing.Point(778, 148);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(64, 20);
            this.lblTenSP.TabIndex = 49;
            this.lblTenSP.Text = "Tên SP";
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblMaSP.Location = new System.Drawing.Point(778, 89);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(59, 20);
            this.lblMaSP.TabIndex = 48;
            this.lblMaSP.Text = "Mã SP";
            // 
            // ckbKinhDoanh
            // 
            this.ckbKinhDoanh.AutoSize = true;
            this.ckbKinhDoanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ckbKinhDoanh.Location = new System.Drawing.Point(869, 376);
            this.ckbKinhDoanh.Name = "ckbKinhDoanh";
            this.ckbKinhDoanh.Size = new System.Drawing.Size(177, 24);
            this.ckbKinhDoanh.TabIndex = 142;
            this.ckbKinhDoanh.Text = "Ngừng Kinh Doanh?";
            this.ckbKinhDoanh.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(1217, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 143;
            this.button1.Text = "Chọn Ảnh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmQLSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 586);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ckbKinhDoanh);
            this.Controls.Add(this.cbxLoaiSP);
            this.Controls.Add(this.dtgvSP);
            this.Controls.Add(this.pbHinh);
            this.Controls.Add(this.lblTTSP);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnXOa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtNuocSX);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.lblNuocSX);
            this.Controls.Add(this.lblGiaBan);
            this.Controls.Add(this.lblLoaiSP);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.lblMaSP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQLSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sản Phẩm";
            this.Load += new System.EventHandler(this.frmQLSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxLoaiSP;
        private System.Windows.Forms.DataGridView dtgvSP;
        private System.Windows.Forms.PictureBox pbHinh;
        private System.Windows.Forms.Label lblTTSP;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXOa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtNuocSX;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lblNuocSX;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.Label lblLoaiSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.CheckBox ckbKinhDoanh;
        private System.Windows.Forms.Button button1;
    }
}