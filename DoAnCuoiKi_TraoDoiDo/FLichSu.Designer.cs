namespace DoAnCuoiKi_TraoDoiDo
{
    partial class FormLichSu
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
            this.btnLSMuaHang = new Guna.UI2.WinForms.Guna2Button();
            this.btnLSBanHang = new Guna.UI2.WinForms.Guna2Button();
            this.panelLichSu = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnLSMuaHang
            // 
            this.btnLSMuaHang.BorderThickness = 2;
            this.btnLSMuaHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLSMuaHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLSMuaHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLSMuaHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLSMuaHang.FillColor = System.Drawing.Color.White;
            this.btnLSMuaHang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLSMuaHang.ForeColor = System.Drawing.Color.Black;
            this.btnLSMuaHang.Location = new System.Drawing.Point(2, 12);
            this.btnLSMuaHang.Name = "btnLSMuaHang";
            this.btnLSMuaHang.Size = new System.Drawing.Size(152, 40);
            this.btnLSMuaHang.TabIndex = 1;
            this.btnLSMuaHang.Text = "Mua Hàng";
            this.btnLSMuaHang.Click += new System.EventHandler(this.btnLSMuaHang_Click);
            // 
            // btnLSBanHang
            // 
            this.btnLSBanHang.BorderThickness = 2;
            this.btnLSBanHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLSBanHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLSBanHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLSBanHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLSBanHang.FillColor = System.Drawing.Color.White;
            this.btnLSBanHang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLSBanHang.ForeColor = System.Drawing.Color.Black;
            this.btnLSBanHang.Location = new System.Drawing.Point(160, 12);
            this.btnLSBanHang.Name = "btnLSBanHang";
            this.btnLSBanHang.Size = new System.Drawing.Size(152, 40);
            this.btnLSBanHang.TabIndex = 2;
            this.btnLSBanHang.Text = "Bán Hàng";
            this.btnLSBanHang.Click += new System.EventHandler(this.btnLSBanHang_Click);
            // 
            // panelLichSu
            // 
            this.panelLichSu.Location = new System.Drawing.Point(2, 58);
            this.panelLichSu.Name = "panelLichSu";
            this.panelLichSu.Size = new System.Drawing.Size(1057, 566);
            this.panelLichSu.TabIndex = 6;
            // 
            // FormLichSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 626);
            this.Controls.Add(this.panelLichSu);
            this.Controls.Add(this.btnLSBanHang);
            this.Controls.Add(this.btnLSMuaHang);
            this.Name = "FormLichSu";
            this.Text = "Lịch sử";
            this.Load += new System.EventHandler(this.FormLichSu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnLSMuaHang;
        private Guna.UI2.WinForms.Guna2Button btnLSBanHang;
        private System.Windows.Forms.Panel panelLichSu;
    }
}