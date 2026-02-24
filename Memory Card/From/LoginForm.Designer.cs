namespace Memory_Card.From
{
    partial class LoginForm
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
            this.grpLogin = new System.Windows.Forms.GroupBox();
<<<<<<< HEAD
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGuest = new System.Windows.Forms.Button();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.lblĐăngNhập = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpLogin.SuspendLayout();
            this.SuspendLayout();
            // 
=======
            this.btnGuest = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblĐăngNhập = new System.Windows.Forms.Label();
            this.grpLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitle.Location = new System.Drawing.Point(228, 113);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(547, 56);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "MEMORY CARD GAME";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
>>>>>>> 7b60e597e8f3fa49e8aca31ba558e521606512df
            // grpLogin
            // 
            this.grpLogin.BackColor = System.Drawing.Color.White;
            this.grpLogin.Controls.Add(this.lblPlayerName);
            this.grpLogin.Controls.Add(this.btnPlay);
            this.grpLogin.Controls.Add(this.btnExit);
            this.grpLogin.Controls.Add(this.btnGuest);
            this.grpLogin.Controls.Add(this.txtPlayerName);
            this.grpLogin.Controls.Add(this.lblĐăngNhập);
            this.grpLogin.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(182)))));
<<<<<<< HEAD
            this.grpLogin.Location = new System.Drawing.Point(278, 199);
=======
            this.grpLogin.Location = new System.Drawing.Point(288, 187);
>>>>>>> 7b60e597e8f3fa49e8aca31ba558e521606512df
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(417, 358);
            this.grpLogin.TabIndex = 1;
            this.grpLogin.TabStop = false;
            this.grpLogin.Enter += new System.EventHandler(this.grpLogin_Enter);
            // 
<<<<<<< HEAD
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Silver;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(142, 285);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(135, 55);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGuest
            // 
            this.btnGuest.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGuest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuest.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuest.ForeColor = System.Drawing.Color.White;
            this.btnGuest.Location = new System.Drawing.Point(242, 215);
=======
            // btnGuest
            // 
            this.btnGuest.BackColor = System.Drawing.Color.Silver;
            this.btnGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuest.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuest.ForeColor = System.Drawing.Color.White;
            this.btnGuest.Location = new System.Drawing.Point(242, 237);
>>>>>>> 7b60e597e8f3fa49e8aca31ba558e521606512df
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Size = new System.Drawing.Size(135, 55);
            this.btnGuest.TabIndex = 3;
            this.btnGuest.Text = "GUEST";
            this.btnGuest.UseVisualStyleBackColor = false;
            this.btnGuest.Click += new System.EventHandler(this.btnGuest_Click);
<<<<<<< HEAD
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerName.Location = new System.Drawing.Point(44, 151);
            this.txtPlayerName.MaxLength = 20;
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(333, 40);
            this.txtPlayerName.TabIndex = 2;
            // 
            // lblĐăngNhập
            // 
            this.lblĐăngNhập.AutoSize = true;
            this.lblĐăngNhập.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblĐăngNhập.Location = new System.Drawing.Point(99, 36);
            this.lblĐăngNhập.Name = "lblĐăngNhập";
            this.lblĐăngNhập.Size = new System.Drawing.Size(235, 43);
            this.lblĐăngNhập.TabIndex = 0;
            this.lblĐăngNhập.Text = "ĐĂNG NHẬP";
            this.lblĐăngNhập.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblĐăngNhập.Click += new System.EventHandler(this.lblĐăngNhập_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Firebrick;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(44, 215);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(135, 55);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.Color.Black;
            this.lblPlayerName.Location = new System.Drawing.Point(39, 110);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(165, 25);
            this.lblPlayerName.TabIndex = 6;
            this.lblPlayerName.Text = "Tên người chơi:";
            this.lblPlayerName.Click += new System.EventHandler(this.lblPlayerName_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.lblTitle.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitle.Location = new System.Drawing.Point(208, 108);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(547, 56);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "MEMORY CARD GAME";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
=======
>>>>>>> 7b60e597e8f3fa49e8aca31ba558e521606512df
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Firebrick;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(44, 237);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(135, 55);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "CHƠI";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerName.Location = new System.Drawing.Point(44, 151);
            this.txtPlayerName.MaxLength = 20;
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(333, 40);
            this.txtPlayerName.TabIndex = 2;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.Color.Black;
            this.lblPlayerName.Location = new System.Drawing.Point(39, 114);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(165, 25);
            this.lblPlayerName.TabIndex = 1;
            this.lblPlayerName.Text = "Tên người chơi:";
            this.lblPlayerName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblĐăngNhập
            // 
            this.lblĐăngNhập.AutoSize = true;
            this.lblĐăngNhập.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblĐăngNhập.Location = new System.Drawing.Point(99, 36);
            this.lblĐăngNhập.Name = "lblĐăngNhập";
            this.lblĐăngNhập.Size = new System.Drawing.Size(235, 43);
            this.lblĐăngNhập.TabIndex = 0;
            this.lblĐăngNhập.Text = "ĐĂNG NHẬP";
            this.lblĐăngNhập.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblĐăngNhập.Click += new System.EventHandler(this.lblĐăngNhập_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(978, 694);
<<<<<<< HEAD
=======
            this.Controls.Add(this.grpLogin);
>>>>>>> 7b60e597e8f3fa49e8aca31ba558e521606512df
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpLogin);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Card - Đăng Nhập";
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Label lblĐăngNhập;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Button btnGuest;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblTitle;
    }
}