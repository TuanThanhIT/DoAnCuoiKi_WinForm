namespace DoAnCuoiKi_TraoDoiDo
{
    partial class FormThongKe
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
            this.panelThongKe = new System.Windows.Forms.Panel();
            this.btnTKMuaHang = new Guna.UI2.WinForms.Guna2Button();
            this.btnTKBanHang = new Guna.UI2.WinForms.Guna2Button();
            this.btnTKTaiKhoan = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // panelThongKe
            // 
            this.panelThongKe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelThongKe.Location = new System.Drawing.Point(3, 58);
            this.panelThongKe.Name = "panelThongKe";
            this.panelThongKe.Size = new System.Drawing.Size(1374, 688);
            this.panelThongKe.TabIndex = 7;
            // 
            // btnTKMuaHang
            // 
            this.btnTKMuaHang.BorderThickness = 2;
            this.btnTKMuaHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTKMuaHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTKMuaHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTKMuaHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTKMuaHang.FillColor = System.Drawing.Color.White;
            this.btnTKMuaHang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKMuaHang.ForeColor = System.Drawing.Color.Black;
            this.btnTKMuaHang.Location = new System.Drawing.Point(3, 12);
            this.btnTKMuaHang.Name = "btnTKMuaHang";
            this.btnTKMuaHang.Size = new System.Drawing.Size(226, 40);
            this.btnTKMuaHang.TabIndex = 8;
            this.btnTKMuaHang.Text = "Giao dịch mua hàng";
            this.btnTKMuaHang.Click += new System.EventHandler(this.btnTKMuaHang_Click);
            // 
            // btnTKBanHang
            // 
            this.btnTKBanHang.BorderThickness = 2;
            this.btnTKBanHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTKBanHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTKBanHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTKBanHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTKBanHang.FillColor = System.Drawing.Color.White;
            this.btnTKBanHang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKBanHang.ForeColor = System.Drawing.Color.Black;
            this.btnTKBanHang.Location = new System.Drawing.Point(235, 12);
            this.btnTKBanHang.Name = "btnTKBanHang";
            this.btnTKBanHang.Size = new System.Drawing.Size(226, 40);
            this.btnTKBanHang.TabIndex = 9;
            this.btnTKBanHang.Text = "Giao dịch bán hàng";
            this.btnTKBanHang.Click += new System.EventHandler(this.btnTKBanHang_Click);
            // 
            // btnTKTaiKhoan
            // 
            this.btnTKTaiKhoan.BorderThickness = 2;
            this.btnTKTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTKTaiKhoan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTKTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTKTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTKTaiKhoan.FillColor = System.Drawing.Color.White;
            this.btnTKTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.btnTKTaiKhoan.Location = new System.Drawing.Point(467, 12);
            this.btnTKTaiKhoan.Name = "btnTKTaiKhoan";
            this.btnTKTaiKhoan.Size = new System.Drawing.Size(226, 40);
            this.btnTKTaiKhoan.TabIndex = 10;
            this.btnTKTaiKhoan.Text = "Tất cả tài khoản";
            this.btnTKTaiKhoan.Click += new System.EventHandler(this.btnTKTaiKhoan_Click);
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1379, 751);
            this.Controls.Add(this.btnTKTaiKhoan);
            this.Controls.Add(this.btnTKBanHang);
            this.Controls.Add(this.btnTKMuaHang);
            this.Controls.Add(this.panelThongKe);
            this.Name = "FormThongKe";
            this.Text = "Thống Kê";
            this.Load += new System.EventHandler(this.FormThongKe_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelThongKe;
        private Guna.UI2.WinForms.Guna2Button btnTKMuaHang;
        private Guna.UI2.WinForms.Guna2Button btnTKBanHang;
        private Guna.UI2.WinForms.Guna2Button btnTKTaiKhoan;
    }
}