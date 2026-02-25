namespace Memory_Card.From
{
    partial class frmDangNhap
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpDangNhap = new System.Windows.Forms.GroupBox();
            this.lblDN = new System.Windows.Forms.Label();
            this.lblTenNguoiChoi = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnGuest = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitle.Location = new System.Drawing.Point(195, 100);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(588, 61);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "MEMORY CARD GAME";
            // 
            // grpDangNhap
            // 
            this.grpDangNhap.BackColor = System.Drawing.Color.White;
            this.grpDangNhap.Controls.Add(this.btnThoat);
            this.grpDangNhap.Controls.Add(this.btnGuest);
            this.grpDangNhap.Controls.Add(this.btnPlay);
            this.grpDangNhap.Controls.Add(this.txtPlayerName);
            this.grpDangNhap.Controls.Add(this.lblTenNguoiChoi);
            this.grpDangNhap.Controls.Add(this.lblDN);
            this.grpDangNhap.Location = new System.Drawing.Point(281, 212);
            this.grpDangNhap.Name = "grpDangNhap";
            this.grpDangNhap.Size = new System.Drawing.Size(399, 351);
            this.grpDangNhap.TabIndex = 1;
            this.grpDangNhap.TabStop = false;
            // 
            // lblDN
            // 
            this.lblDN.AutoSize = true;
            this.lblDN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDN.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDN.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDN.Location = new System.Drawing.Point(78, 42);
            this.lblDN.Name = "lblDN";
            this.lblDN.Size = new System.Drawing.Size(235, 43);
            this.lblDN.TabIndex = 0;
            this.lblDN.Text = "ĐĂNG NHẬP";
            // 
            // lblTenNguoiChoi
            // 
            this.lblTenNguoiChoi.AutoSize = true;
            this.lblTenNguoiChoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTenNguoiChoi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNguoiChoi.ForeColor = System.Drawing.Color.Black;
            this.lblTenNguoiChoi.Location = new System.Drawing.Point(45, 116);
            this.lblTenNguoiChoi.Name = "lblTenNguoiChoi";
            this.lblTenNguoiChoi.Size = new System.Drawing.Size(186, 27);
            this.lblTenNguoiChoi.TabIndex = 1;
            this.lblTenNguoiChoi.Text = "Tên người chơi:";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerName.Location = new System.Drawing.Point(50, 158);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(297, 35);
            this.txtPlayerName.TabIndex = 2;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(50, 216);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(114, 47);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnGuest
            // 
            this.btnGuest.BackColor = System.Drawing.Color.Red;
            this.btnGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuest.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuest.Location = new System.Drawing.Point(233, 216);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Size = new System.Drawing.Size(114, 47);
            this.btnGuest.TabIndex = 4;
            this.btnGuest.Text = "GUEST";
            this.btnGuest.UseVisualStyleBackColor = false;
            this.btnGuest.Click += new System.EventHandler(this.btnGuest_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Silver;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(143, 285);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(114, 47);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "EXIT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
<<<<<<< HEAD
            // lblDN
            // 
            this.lblDN.AutoSize = true;
            this.lblDN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDN.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDN.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDN.Location = new System.Drawing.Point(78, 42);
            this.lblDN.Name = "lblDN";
            this.lblDN.Size = new System.Drawing.Size(235, 43);
            this.lblDN.TabIndex = 0;
            this.lblDN.Text = "ĐĂNG NHẬP";
            // 
=======
>>>>>>> a07c08d9ec81ad3eb97b684a38a3be611d9bcbc8
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(978, 694);
            this.Controls.Add(this.grpDangNhap);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.Name = "frmDangNhap";
<<<<<<< HEAD
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Card - Đăng Nhập";
            this.Load += new System.EventHandler(this.DangNhapForm_Load);
=======
            this.Text = "DangNhapForm";
>>>>>>> a07c08d9ec81ad3eb97b684a38a3be611d9bcbc8
            this.grpDangNhap.ResumeLayout(false);
            this.grpDangNhap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpDangNhap;
        private System.Windows.Forms.Label lblDN;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label lblTenNguoiChoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnGuest;
        private System.Windows.Forms.Button btnPlay;
    }
}