namespace Memory_Card.Form
{
    partial class frmTongKet
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
            this.grpTongKet = new System.Windows.Forms.GroupBox();
            this.btnRank = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnReplay = new System.Windows.Forms.Button();
            this.grpKetQua = new System.Windows.Forms.GroupBox();
            this.lblHint = new System.Windows.Forms.Label();
            this.lblSoLuotThu = new System.Windows.Forms.Label();
            this.lblTimes = new System.Windows.Forms.Label();
            this.lblOutDiemSo = new System.Windows.Forms.Label();
            this.lblOutSoLuotThu = new System.Windows.Forms.Label();
            this.lblOutThoiGian = new System.Windows.Forms.Label();
            this.lblDiemSo = new System.Windows.Forms.Label();
            this.lblSoLuot = new System.Windows.Forms.Label();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.lblChucMung = new System.Windows.Forms.Label();
            this.grpTongKet.SuspendLayout();
            this.grpKetQua.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTongKet
            // 
            this.grpTongKet.BackColor = System.Drawing.Color.White;
            this.grpTongKet.Controls.Add(this.btnRank);
            this.grpTongKet.Controls.Add(this.btnMenu);
            this.grpTongKet.Controls.Add(this.btnReplay);
            this.grpTongKet.Controls.Add(this.grpKetQua);
            this.grpTongKet.Controls.Add(this.lblKetQua);
            this.grpTongKet.Controls.Add(this.lblChucMung);
            this.grpTongKet.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpTongKet.Location = new System.Drawing.Point(100, 107);
            this.grpTongKet.Name = "grpTongKet";
            this.grpTongKet.Size = new System.Drawing.Size(786, 480);
            this.grpTongKet.TabIndex = 0;
            this.grpTongKet.TabStop = false;
            this.grpTongKet.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnRank
            // 
            this.btnRank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnRank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRank.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRank.ForeColor = System.Drawing.Color.White;
            this.btnRank.Location = new System.Drawing.Point(503, 408);
            this.btnRank.Name = "btnRank";
            this.btnRank.Size = new System.Drawing.Size(142, 50);
            this.btnRank.TabIndex = 5;
            this.btnRank.Text = "Xếp hạng";
            this.btnRank.UseVisualStyleBackColor = false;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(141)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(333, 408);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(142, 50);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            // 
            // btnReplay
            // 
            this.btnReplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnReplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReplay.ForeColor = System.Drawing.Color.White;
            this.btnReplay.Location = new System.Drawing.Point(165, 408);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(142, 50);
            this.btnReplay.TabIndex = 3;
            this.btnReplay.Text = "Chơi lại";
            this.btnReplay.UseVisualStyleBackColor = false;
            // 
            // grpKetQua
            // 
            this.grpKetQua.BackColor = System.Drawing.Color.PowderBlue;
            this.grpKetQua.Controls.Add(this.lblHint);
            this.grpKetQua.Controls.Add(this.lblSoLuotThu);
            this.grpKetQua.Controls.Add(this.lblTimes);
            this.grpKetQua.Controls.Add(this.lblOutDiemSo);
            this.grpKetQua.Controls.Add(this.lblOutSoLuotThu);
            this.grpKetQua.Controls.Add(this.lblOutThoiGian);
            this.grpKetQua.Controls.Add(this.lblDiemSo);
            this.grpKetQua.Controls.Add(this.lblSoLuot);
            this.grpKetQua.Controls.Add(this.lblThoiGian);
            this.grpKetQua.Location = new System.Drawing.Point(199, 169);
            this.grpKetQua.Name = "grpKetQua";
            this.grpKetQua.Size = new System.Drawing.Size(415, 210);
            this.grpKetQua.TabIndex = 2;
            this.grpKetQua.TabStop = false;
            this.grpKetQua.Enter += new System.EventHandler(this.grpKetQua_Enter);
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHint.ForeColor = System.Drawing.Color.Yellow;
            this.lblHint.Location = new System.Drawing.Point(267, 120);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(26, 29);
            this.lblHint.TabIndex = 8;
            this.lblHint.Text = "0";
            // 
            // lblSoLuotThu
            // 
            this.lblSoLuotThu.AutoSize = true;
            this.lblSoLuotThu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoLuotThu.Location = new System.Drawing.Point(267, 77);
            this.lblSoLuotThu.Name = "lblSoLuotThu";
            this.lblSoLuotThu.Size = new System.Drawing.Size(26, 29);
            this.lblSoLuotThu.TabIndex = 7;
            this.lblSoLuotThu.Text = "0";
            // 
            // lblTimes
            // 
            this.lblTimes.AutoSize = true;
            this.lblTimes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTimes.Location = new System.Drawing.Point(267, 30);
            this.lblTimes.Name = "lblTimes";
            this.lblTimes.Size = new System.Drawing.Size(72, 29);
            this.lblTimes.TabIndex = 6;
            this.lblTimes.Text = "00:00";
            // 
            // lblOutDiemSo
            // 
            this.lblOutDiemSo.AutoSize = true;
            this.lblOutDiemSo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblOutDiemSo.Location = new System.Drawing.Point(296, 161);
            this.lblOutDiemSo.Name = "lblOutDiemSo";
            this.lblOutDiemSo.Size = new System.Drawing.Size(0, 27);
            this.lblOutDiemSo.TabIndex = 5;
            // 
            // lblOutSoLuotThu
            // 
            this.lblOutSoLuotThu.AutoSize = true;
            this.lblOutSoLuotThu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblOutSoLuotThu.Location = new System.Drawing.Point(299, 102);
            this.lblOutSoLuotThu.Name = "lblOutSoLuotThu";
            this.lblOutSoLuotThu.Size = new System.Drawing.Size(0, 27);
            this.lblOutSoLuotThu.TabIndex = 4;
            // 
            // lblOutThoiGian
            // 
            this.lblOutThoiGian.AutoSize = true;
            this.lblOutThoiGian.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblOutThoiGian.Location = new System.Drawing.Point(291, 37);
            this.lblOutThoiGian.Name = "lblOutThoiGian";
            this.lblOutThoiGian.Size = new System.Drawing.Size(0, 27);
            this.lblOutThoiGian.TabIndex = 3;
            // 
            // lblDiemSo
            // 
            this.lblDiemSo.AutoSize = true;
            this.lblDiemSo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDiemSo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiemSo.Location = new System.Drawing.Point(33, 122);
            this.lblDiemSo.Name = "lblDiemSo";
            this.lblDiemSo.Size = new System.Drawing.Size(129, 27);
            this.lblDiemSo.TabIndex = 2;
            this.lblDiemSo.Text = "⭐ Điểm số:";
            this.lblDiemSo.Click += new System.EventHandler(this.lblDiemSo_Click);
            // 
            // lblSoLuot
            // 
            this.lblSoLuot.AutoSize = true;
            this.lblSoLuot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSoLuot.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoLuot.Location = new System.Drawing.Point(22, 79);
            this.lblSoLuot.Name = "lblSoLuot";
            this.lblSoLuot.Size = new System.Drawing.Size(177, 27);
            this.lblSoLuot.TabIndex = 1;
            this.lblSoLuot.Text = "🔁 Số lượt thử:";
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblThoiGian.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThoiGian.Location = new System.Drawing.Point(22, 32);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(154, 27);
            this.lblThoiGian.TabIndex = 0;
            this.lblThoiGian.Text = "⏱ Thời gian:";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblKetQua.Location = new System.Drawing.Point(278, 114);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(269, 33);
            this.lblKetQua.TabIndex = 1;
            this.lblKetQua.Text = "Kết quả cuối cùng:";
            // 
            // lblChucMung
            // 
            this.lblChucMung.AutoSize = true;
            this.lblChucMung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblChucMung.Location = new System.Drawing.Point(262, 49);
            this.lblChucMung.Name = "lblChucMung";
            this.lblChucMung.Size = new System.Drawing.Size(285, 46);
            this.lblChucMung.TabIndex = 0;
            this.lblChucMung.Text = "CHÚC MỪNG!";
            // 
            // frmTongKet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(978, 694);
            this.Controls.Add(this.grpTongKet);
            this.MaximizeBox = false;
            this.Name = "frmTongKet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Card - Tổng Kết";
            this.grpTongKet.ResumeLayout(false);
            this.grpTongKet.PerformLayout();
            this.grpKetQua.ResumeLayout(false);
            this.grpKetQua.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTongKet;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label lblChucMung;
        private System.Windows.Forms.GroupBox grpKetQua;
        private System.Windows.Forms.Label lblOutDiemSo;
        private System.Windows.Forms.Label lblOutSoLuotThu;
        private System.Windows.Forms.Label lblOutThoiGian;
        private System.Windows.Forms.Label lblDiemSo;
        private System.Windows.Forms.Label lblSoLuot;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Button btnRank;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnReplay;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Label lblSoLuotThu;
        private System.Windows.Forms.Label lblTimes;
    }
}