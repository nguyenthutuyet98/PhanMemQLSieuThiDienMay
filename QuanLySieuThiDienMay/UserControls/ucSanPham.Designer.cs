namespace QuanLySieuThiDienMay.UserControls
{
    partial class ucSanPham
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSanPham));
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.picbIMG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbIMG)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaBan.ForeColor = System.Drawing.Color.Red;
            this.lblGiaBan.Location = new System.Drawing.Point(72, 163);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblGiaBan.Size = new System.Drawing.Size(69, 20);
            this.lblGiaBan.TabIndex = 8;
            this.lblGiaBan.Text = "100000";
            this.lblGiaBan.Click += new System.EventHandler(this.lblGiaBan_Click);
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.Location = new System.Drawing.Point(4, 145);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(78, 13);
            this.lblTenSP.TabIndex = 7;
            this.lblTenSP.Text = "Tên Sản Phẩm";
            this.lblTenSP.Click += new System.EventHandler(this.lblTenSP_Click);
            // 
            // picbIMG
            // 
            this.picbIMG.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picbIMG.ErrorImage")));
            this.picbIMG.Location = new System.Drawing.Point(18, 12);
            this.picbIMG.Name = "picbIMG";
            this.picbIMG.Size = new System.Drawing.Size(130, 130);
            this.picbIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbIMG.TabIndex = 6;
            this.picbIMG.TabStop = false;
            this.picbIMG.Click += new System.EventHandler(this.picbIMG_Click);
            // 
            // ucSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.lblGiaBan);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.picbIMG);
            this.Name = "ucSanPham";
            this.Size = new System.Drawing.Size(168, 194);
            this.Load += new System.EventHandler(this.ucSanPham_Load);
            this.Click += new System.EventHandler(this.ucSanPham_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picbIMG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.PictureBox picbIMG;
    }
}
