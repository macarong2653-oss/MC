namespace Memory_Card.From
{
    partial class frmLuuTrangThai
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
            this.grpLuuTrangThai = new System.Windows.Forms.GroupBox();
            this.lblChamHoi = new System.Windows.Forms.Label();
            this.btnKhong = new System.Windows.Forms.Button();
            this.btnCo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLuuTrangThai = new System.Windows.Forms.Label();
            this.grpLuuTrangThai.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLuuTrangThai
            // 
            this.grpLuuTrangThai.BackColor = System.Drawing.Color.White;
            this.grpLuuTrangThai.Controls.Add(this.lblChamHoi);
            this.grpLuuTrangThai.Controls.Add(this.btnKhong);
            this.grpLuuTrangThai.Controls.Add(this.btnCo);
            this.grpLuuTrangThai.Controls.Add(this.label1);
            this.grpLuuTrangThai.Controls.Add(this.lblLuuTrangThai);
            this.grpLuuTrangThai.Location = new System.Drawing.Point(2, 1);
            this.grpLuuTrangThai.Name = "grpLuuTrangThai";
            this.grpLuuTrangThai.Size = new System.Drawing.Size(514, 323);
            this.grpLuuTrangThai.TabIndex = 0;
            this.grpLuuTrangThai.TabStop = false;
            this.grpLuuTrangThai.Enter += new System.EventHandler(this.grpLuuTrangThai_Enter);
            // 
            // lblChamHoi
            // 
            this.lblChamHoi.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChamHoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblChamHoi.Location = new System.Drawing.Point(212, 22);
            this.lblChamHoi.Name = "lblChamHoi";
            this.lblChamHoi.Size = new System.Drawing.Size(107, 102);
            this.lblChamHoi.TabIndex = 4;
            this.lblChamHoi.Text = "?";
            this.lblChamHoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // btnKhong
            // 
            this.btnKhong.BackColor = System.Drawing.Color.Red;
            this.btnKhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhong.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKhong.ForeColor = System.Drawing.Color.White;
            this.btnKhong.Location = new System.Drawing.Point(296, 239);
            this.btnKhong.Name = "btnKhong";
            this.btnKhong.Size = new System.Drawing.Size(109, 57);
            this.btnKhong.TabIndex = 3;
            this.btnKhong.Text = "✖Không";
            this.btnKhong.UseVisualStyleBackColor = false;
            // 
            // btnCo
            // 
            this.btnCo.BackColor = System.Drawing.Color.Green;
            this.btnCo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCo.ForeColor = System.Drawing.Color.White;
            this.btnCo.Location = new System.Drawing.Point(119, 239);
            this.btnCo.Name = "btnCo";
            this.btnCo.Size = new System.Drawing.Size(109, 57);
            this.btnCo.TabIndex = 2;
            this.btnCo.Text = "✓ Có";
            this.btnCo.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bạn có muốn lưu tiến trình hiện tại không";
            // 
            // lblLuuTrangThai
            // 
            this.lblLuuTrangThai.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLuuTrangThai.Location = new System.Drawing.Point(53, 141);
            this.lblLuuTrangThai.Name = "lblLuuTrangThai";
            this.lblLuuTrangThai.Size = new System.Drawing.Size(420, 53);
            this.lblLuuTrangThai.TabIndex = 0;
            this.lblLuuTrangThai.Text = "LƯU TRẠNG THÁI GAME?";
            // 
            // frmLuuTrangThai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(519, 322);
            this.Controls.Add(this.grpLuuTrangThai);
            this.MaximizeBox = false;
            this.Name = "frmLuuTrangThai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Card - Lưu Trạng Thái";
            this.grpLuuTrangThai.ResumeLayout(false);
            this.grpLuuTrangThai.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLuuTrangThai;
        private System.Windows.Forms.Label lblLuuTrangThai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKhong;
        private System.Windows.Forms.Button btnCo;
        private System.Windows.Forms.Label lblChamHoi;
    }
}