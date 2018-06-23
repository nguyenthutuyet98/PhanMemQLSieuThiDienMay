namespace QuanLySieuThiDienMay
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnsMain = new System.Windows.Forms.MenuStrip();
            this.hethong2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.banhangToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thongkeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thongketheoTGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongketheoNVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangxuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quanlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanlysanphamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanlynhanvienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsTemp = new System.Windows.Forms.MenuStrip();
            this.hethong1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangnhapToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sttThongTin = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnsMain.SuspendLayout();
            this.mnsTemp.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMain
            // 
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hethong2ToolStripMenuItem,
            this.quanlyToolStripMenuItem});
            this.mnsMain.Location = new System.Drawing.Point(0, 24);
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.Size = new System.Drawing.Size(284, 24);
            this.mnsMain.TabIndex = 1;
            this.mnsMain.Text = "Menu";
            this.mnsMain.Visible = false;
            // 
            // hethong2ToolStripMenuItem
            // 
            this.hethong2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.banhangToolStripMenuItem1,
            this.thongkeToolStripMenuItem1,
            this.dangxuatToolStripMenuItem,
            this.thoatToolStripMenuItem1});
            this.hethong2ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hethong2ToolStripMenuItem.Image")));
            this.hethong2ToolStripMenuItem.Name = "hethong2ToolStripMenuItem";
            this.hethong2ToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.hethong2ToolStripMenuItem.Text = "Hệ Thống";
            // 
            // banhangToolStripMenuItem1
            // 
            this.banhangToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("banhangToolStripMenuItem1.Image")));
            this.banhangToolStripMenuItem1.Name = "banhangToolStripMenuItem1";
            this.banhangToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.banhangToolStripMenuItem1.Text = "Bán Hàng";
            this.banhangToolStripMenuItem1.Click += new System.EventHandler(this.banghangToolStripMenuItem1_Click);
            // 
            // thongkeToolStripMenuItem1
            // 
            this.thongkeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thongketheoTGToolStripMenuItem,
            this.thongketheoNVToolStripMenuItem});
            this.thongkeToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("thongkeToolStripMenuItem1.Image")));
            this.thongkeToolStripMenuItem1.Name = "thongkeToolStripMenuItem1";
            this.thongkeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.thongkeToolStripMenuItem1.Text = "Thống Kê";
            // 
            // thongketheoTGToolStripMenuItem
            // 
            this.thongketheoTGToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thongketheoTGToolStripMenuItem.Image")));
            this.thongketheoTGToolStripMenuItem.Name = "thongketheoTGToolStripMenuItem";
            this.thongketheoTGToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.thongketheoTGToolStripMenuItem.Text = "Thống Kê Theo Thời Gian";
            this.thongketheoTGToolStripMenuItem.Click += new System.EventHandler(this.thongketheoTGToolStripMenuItem_Click);
            // 
            // thongketheoNVToolStripMenuItem
            // 
            this.thongketheoNVToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thongketheoNVToolStripMenuItem.Image")));
            this.thongketheoNVToolStripMenuItem.Name = "thongketheoNVToolStripMenuItem";
            this.thongketheoNVToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.thongketheoNVToolStripMenuItem.Text = "Thống Kê Theo Nhân Viên";
            this.thongketheoNVToolStripMenuItem.Click += new System.EventHandler(this.thongketheoNVToolStripMenuItem_Click);
            // 
            // dangxuatToolStripMenuItem
            // 
            this.dangxuatToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dangxuatToolStripMenuItem.Image")));
            this.dangxuatToolStripMenuItem.Name = "dangxuatToolStripMenuItem";
            this.dangxuatToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dangxuatToolStripMenuItem.Text = "Đăng Xuất";
            this.dangxuatToolStripMenuItem.Click += new System.EventHandler(this.dangxuatToolStripMenuItem_Click);
            // 
            // thoatToolStripMenuItem1
            // 
            this.thoatToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("thoatToolStripMenuItem1.Image")));
            this.thoatToolStripMenuItem1.Name = "thoatToolStripMenuItem1";
            this.thoatToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.thoatToolStripMenuItem1.Text = "Thoát";
            this.thoatToolStripMenuItem1.Click += new System.EventHandler(this.thoatToolStripMenuItem1_Click);
            // 
            // quanlyToolStripMenuItem
            // 
            this.quanlyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanlysanphamToolStripMenuItem,
            this.quanlynhanvienToolStripMenuItem});
            this.quanlyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quanlyToolStripMenuItem.Image")));
            this.quanlyToolStripMenuItem.Name = "quanlyToolStripMenuItem";
            this.quanlyToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.quanlyToolStripMenuItem.Text = "Quản Lý";
            // 
            // quanlysanphamToolStripMenuItem
            // 
            this.quanlysanphamToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quanlysanphamToolStripMenuItem.Image")));
            this.quanlysanphamToolStripMenuItem.Name = "quanlysanphamToolStripMenuItem";
            this.quanlysanphamToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.quanlysanphamToolStripMenuItem.Text = "Quản Lý Sản Phẩm";
            this.quanlysanphamToolStripMenuItem.Click += new System.EventHandler(this.quanlysanphamToolStripMenuItem_Click);
            // 
            // quanlynhanvienToolStripMenuItem
            // 
            this.quanlynhanvienToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quanlynhanvienToolStripMenuItem.Image")));
            this.quanlynhanvienToolStripMenuItem.Name = "quanlynhanvienToolStripMenuItem";
            this.quanlynhanvienToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.quanlynhanvienToolStripMenuItem.Text = "Quản Lý Nhân Viên";
            this.quanlynhanvienToolStripMenuItem.Click += new System.EventHandler(this.quanlynhanvienToolStripMenuItem_Click);
            // 
            // mnsTemp
            // 
            this.mnsTemp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hethong1ToolStripMenuItem});
            this.mnsTemp.Location = new System.Drawing.Point(0, 0);
            this.mnsTemp.Name = "mnsTemp";
            this.mnsTemp.Size = new System.Drawing.Size(284, 24);
            this.mnsTemp.TabIndex = 3;
            this.mnsTemp.Text = "menuStrip1";
            // 
            // hethong1ToolStripMenuItem
            // 
            this.hethong1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dangnhapToolStripMenuItem1,
            this.thoatToolStripMenuItem});
            this.hethong1ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hethong1ToolStripMenuItem.Image")));
            this.hethong1ToolStripMenuItem.Name = "hethong1ToolStripMenuItem";
            this.hethong1ToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.hethong1ToolStripMenuItem.Text = "Hệ Thống";
            // 
            // dangnhapToolStripMenuItem1
            // 
            this.dangnhapToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("dangnhapToolStripMenuItem1.Image")));
            this.dangnhapToolStripMenuItem1.Name = "dangnhapToolStripMenuItem1";
            this.dangnhapToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.dangnhapToolStripMenuItem1.Text = "Đăng Nhập";
            this.dangnhapToolStripMenuItem1.Click += new System.EventHandler(this.dangnhapToolStripMenuItem1_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thoatToolStripMenuItem.Image")));
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sttThongTin});
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sttThongTin
            // 
            this.sttThongTin.Name = "sttThongTin";
            this.sttThongTin.Size = new System.Drawing.Size(0, 17);
            this.sttThongTin.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mnsMain);
            this.Controls.Add(this.mnsTemp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsMain;
            this.Name = "frmMain";
            this.Text = "Siêu Thị Điện Máy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnsMain.ResumeLayout(false);
            this.mnsMain.PerformLayout();
            this.mnsTemp.ResumeLayout(false);
            this.mnsTemp.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMain;
        private System.Windows.Forms.ToolStripMenuItem hethong2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanlysanphamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanlynhanvienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem banhangToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thongkeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thongketheoTGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongketheoNVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangxuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip mnsTemp;
        private System.Windows.Forms.ToolStripMenuItem hethong1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangnhapToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sttThongTin;

        public System.EventHandler thongkeToolStripMenuItem1_Click { get; set; }
    }
}

