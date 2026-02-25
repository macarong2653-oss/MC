namespace Memory_Card.From
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
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblHints = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblMatched = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAttempts = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lalThongtin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBoard
            // 
            this.pnlBoard.Location = new System.Drawing.Point(59, 160);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(438, 397);
            this.pnlBoard.TabIndex = 0;
            // 
            // pnlInfo
            // 
            this.pnlInfo.AutoSize = true;
            this.pnlInfo.BackColor = System.Drawing.Color.White;
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.label3);
            this.pnlInfo.Controls.Add(this.lblHints);
            this.pnlInfo.Controls.Add(this.label8);
            this.pnlInfo.Controls.Add(this.lblScore);
            this.pnlInfo.Controls.Add(this.lblMatched);
            this.pnlInfo.Controls.Add(this.label4);
            this.pnlInfo.Controls.Add(this.lblAttempts);
            this.pnlInfo.Controls.Add(this.label2);
            this.pnlInfo.Controls.Add(this.lblTime);
            this.pnlInfo.Controls.Add(this.label1);
            this.pnlInfo.Controls.Add(this.lalThongtin);
            this.pnlInfo.Location = new System.Drawing.Point(565, 160);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(361, 397);
            this.pnlInfo.TabIndex = 1;
            // 
            // lblHints
            // 
            this.lblHints.AutoSize = true;
            this.lblHints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHints.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHints.ForeColor = System.Drawing.Color.Black;
            this.lblHints.Location = new System.Drawing.Point(240, 244);
            this.lblHints.Name = "lblHints";
            this.lblHints.Size = new System.Drawing.Size(26, 29);
            this.lblHints.TabIndex = 10;
            this.lblHints.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 27);
            this.label8.TabIndex = 9;
            this.label8.Text = "💡  Hint: ";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblScore.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Gold;
            this.lblScore.Location = new System.Drawing.Point(240, 203);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(26, 29);
            this.lblScore.TabIndex = 8;
            this.lblScore.Text = "0";
            // 
            // lblMatched
            // 
            this.lblMatched.AutoSize = true;
            this.lblMatched.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMatched.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatched.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblMatched.Location = new System.Drawing.Point(240, 161);
            this.lblMatched.Name = "lblMatched";
            this.lblMatched.Size = new System.Drawing.Size(60, 29);
            this.lblMatched.TabIndex = 6;
            this.lblMatched.Text = "0 / 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "✓  Đã ghép: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblAttempts
            // 
            this.lblAttempts.AutoSize = true;
            this.lblAttempts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAttempts.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttempts.Location = new System.Drawing.Point(240, 120);
            this.lblAttempts.Name = "lblAttempts";
            this.lblAttempts.Size = new System.Drawing.Size(26, 29);
            this.lblAttempts.TabIndex = 4;
            this.lblAttempts.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "🎯 Lượt thử: ";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Red;
            this.lblTime.Location = new System.Drawing.Point(240, 77);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(72, 29);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "⏱ Thời gian: ";
            // 
            // lalThongtin
            // 
            this.lalThongtin.AutoSize = true;
            this.lalThongtin.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalThongtin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lalThongtin.Location = new System.Drawing.Point(95, 24);
            this.lalThongtin.Name = "lalThongtin";
            this.lalThongtin.Size = new System.Drawing.Size(171, 33);
            this.lalThongtin.TabIndex = 0;
            this.lalThongtin.Text = "THÔNG TIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "⭐   Điểm: ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(978, 694);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlBoard);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Card - PlayGame";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lalThongtin;
        private System.Windows.Forms.Label lblHints;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblMatched;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAttempts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}