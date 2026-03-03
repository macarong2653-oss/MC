namespace Memory_Card.From
{
    partial class frmXepHang
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
            this.lblBXH = new System.Windows.Forms.Label();
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.grpBXH = new System.Windows.Forms.GroupBox();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBXH
            // 
            this.lblBXH.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBXH.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBXH.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBXH.Location = new System.Drawing.Point(0, 0);
            this.lblBXH.Name = "lblBXH";
            this.lblBXH.Size = new System.Drawing.Size(978, 115);
            this.lblBXH.TabIndex = 0;
            this.lblBXH.Text = "BẢNG XẾP HẠNG";
            this.lblBXH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEasy
            // 
            this.btnEasy.BackColor = System.Drawing.Color.Silver;
            this.btnEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEasy.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEasy.ForeColor = System.Drawing.Color.Black;
            this.btnEasy.Location = new System.Drawing.Point(246, 134);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(143, 62);
            this.btnEasy.TabIndex = 1;
            this.btnEasy.Text = "Easy 4x4";
            this.btnEasy.UseVisualStyleBackColor = false;
            // 
            // btnMedium
            // 
            this.btnMedium.BackColor = System.Drawing.Color.Silver;
            this.btnMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedium.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMedium.ForeColor = System.Drawing.Color.Black;
            this.btnMedium.Location = new System.Drawing.Point(423, 134);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(143, 62);
            this.btnMedium.TabIndex = 2;
            this.btnMedium.Text = "Medium 6x6";
            this.btnMedium.UseVisualStyleBackColor = false;
            // 
            // btnHard
            // 
            this.btnHard.BackColor = System.Drawing.Color.Silver;
            this.btnHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHard.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHard.ForeColor = System.Drawing.Color.Black;
            this.btnHard.Location = new System.Drawing.Point(600, 134);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(143, 62);
            this.btnHard.TabIndex = 3;
            this.btnHard.Text = "Hard 8x8";
            this.btnHard.UseVisualStyleBackColor = false;
            // 
            // grpBXH
            // 
            this.grpBXH.Location = new System.Drawing.Point(246, 224);
            this.grpBXH.Name = "grpBXH";
            this.grpBXH.Size = new System.Drawing.Size(497, 351);
            this.grpBXH.TabIndex = 4;
            this.grpBXH.TabStop = false;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayLai.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQuayLai.Location = new System.Drawing.Point(423, 597);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(143, 62);
            this.btnQuayLai.TabIndex = 5;
            this.btnQuayLai.Text = "<- Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            // 
            // frmXepHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(978, 694);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.grpBXH);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnEasy);
            this.Controls.Add(this.lblBXH);
            this.MaximizeBox = false;
            this.Name = "frmXepHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Card - Xếp Hạng";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBXH;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.GroupBox grpBXH;
        private System.Windows.Forms.Button btnQuayLai;
    }
}