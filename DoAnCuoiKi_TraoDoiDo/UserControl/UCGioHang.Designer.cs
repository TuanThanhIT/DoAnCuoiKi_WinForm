namespace DoAnCuoiKi_TraoDoiDo
{
    partial class UCGioHang
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
            this.components = new System.ComponentModel.Container();
            this.UCGHUpDown = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.UCGHImagePicBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ColorTransition1 = new Guna.UI2.WinForms.Guna2ColorTransition(this.components);
            this.UCGHlblLoai = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.UCGHlblGiacu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.UCGHlblGiamoi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.UCGHbtnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.UCGHlblThanhtoan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.UCGHlblSoluong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.UCGHlblNgay = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.UCGHlblTenMH = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.UCGHCheck = new System.Windows.Forms.CheckBox();
            this.UCGHlblMa = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.UCGHbtnLuu = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.UCGHUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UCGHImagePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UCGHUpDown
            // 
            this.UCGHUpDown.BackColor = System.Drawing.Color.Transparent;
            this.UCGHUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UCGHUpDown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UCGHUpDown.Location = new System.Drawing.Point(682, 55);
            this.UCGHUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UCGHUpDown.Name = "UCGHUpDown";
            this.UCGHUpDown.Size = new System.Drawing.Size(137, 40);
            this.UCGHUpDown.TabIndex = 3;
            this.UCGHUpDown.ValueChanged += new System.EventHandler(this.UCGHUpDown_ValueChanged);
            // 
            // UCGHImagePicBox
            // 
            this.UCGHImagePicBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UCGHImagePicBox.ImageRotate = 0F;
            this.UCGHImagePicBox.Location = new System.Drawing.Point(34, 3);
            this.UCGHImagePicBox.Name = "UCGHImagePicBox";
            this.UCGHImagePicBox.Size = new System.Drawing.Size(158, 156);
            this.UCGHImagePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UCGHImagePicBox.TabIndex = 4;
            this.UCGHImagePicBox.TabStop = false;
            // 
            // guna2ColorTransition1
            // 
            this.guna2ColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Orange};
            // 
            // UCGHlblLoai
            // 
            this.UCGHlblLoai.BackColor = System.Drawing.Color.White;
            this.UCGHlblLoai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCGHlblLoai.Location = new System.Drawing.Point(230, 90);
            this.UCGHlblLoai.Name = "UCGHlblLoai";
            this.UCGHlblLoai.Size = new System.Drawing.Size(98, 21);
            this.UCGHlblLoai.TabIndex = 9;
            this.UCGHlblLoai.Text = "Loại mặt hàng";
            this.UCGHlblLoai.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCGHlblGiacu
            // 
            this.UCGHlblGiacu.BackColor = System.Drawing.Color.Transparent;
            this.UCGHlblGiacu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCGHlblGiacu.ForeColor = System.Drawing.Color.Fuchsia;
            this.UCGHlblGiacu.Location = new System.Drawing.Point(431, 69);
            this.UCGHlblGiacu.Name = "UCGHlblGiacu";
            this.UCGHlblGiacu.Size = new System.Drawing.Size(55, 24);
            this.UCGHlblGiacu.TabIndex = 10;
            this.UCGHlblGiacu.Text = "Giá cũ";
            // 
            // UCGHlblGiamoi
            // 
            this.UCGHlblGiamoi.BackColor = System.Drawing.Color.Transparent;
            this.UCGHlblGiamoi.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCGHlblGiamoi.ForeColor = System.Drawing.Color.Red;
            this.UCGHlblGiamoi.Location = new System.Drawing.Point(527, 55);
            this.UCGHlblGiamoi.Name = "UCGHlblGiamoi";
            this.UCGHlblGiamoi.Size = new System.Drawing.Size(115, 39);
            this.UCGHlblGiamoi.TabIndex = 11;
            this.UCGHlblGiamoi.Text = "Giá mới";
            // 
            // UCGHbtnXoa
            // 
            this.UCGHbtnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UCGHbtnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UCGHbtnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UCGHbtnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UCGHbtnXoa.FillColor = System.Drawing.Color.White;
            this.UCGHbtnXoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCGHbtnXoa.ForeColor = System.Drawing.Color.Black;
            this.UCGHbtnXoa.Location = new System.Drawing.Point(970, 38);
            this.UCGHbtnXoa.Name = "UCGHbtnXoa";
            this.UCGHbtnXoa.Size = new System.Drawing.Size(77, 38);
            this.UCGHbtnXoa.TabIndex = 12;
            this.UCGHbtnXoa.Text = "Xóa";
            this.UCGHbtnXoa.Click += new System.EventHandler(this.UCGHbtnXoa_Click);
            // 
            // UCGHlblThanhtoan
            // 
            this.UCGHlblThanhtoan.AutoSize = false;
            this.UCGHlblThanhtoan.BackColor = System.Drawing.Color.Transparent;
            this.UCGHlblThanhtoan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCGHlblThanhtoan.ForeColor = System.Drawing.Color.Red;
            this.UCGHlblThanhtoan.Location = new System.Drawing.Point(855, 65);
            this.UCGHlblThanhtoan.Name = "UCGHlblThanhtoan";
            this.UCGHlblThanhtoan.Size = new System.Drawing.Size(109, 30);
            this.UCGHlblThanhtoan.TabIndex = 13;
            this.UCGHlblThanhtoan.Text = "Thanh toán";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(230, 126);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(75, 21);
            this.guna2HtmlLabel1.TabIndex = 14;
            this.guna2HtmlLabel1.Text = "Số lượng";
            // 
            // UCGHlblSoluong
            // 
            this.UCGHlblSoluong.BackColor = System.Drawing.Color.White;
            this.UCGHlblSoluong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCGHlblSoluong.Location = new System.Drawing.Point(336, 126);
            this.UCGHlblSoluong.Name = "UCGHlblSoluong";
            this.UCGHlblSoluong.Size = new System.Drawing.Size(21, 21);
            this.UCGHlblSoluong.TabIndex = 15;
            this.UCGHlblSoluong.Text = "15";
            // 
            // UCGHlblNgay
            // 
            this.UCGHlblNgay.AutoSize = false;
            this.UCGHlblNgay.BackColor = System.Drawing.Color.White;
            this.UCGHlblNgay.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCGHlblNgay.Location = new System.Drawing.Point(576, 120);
            this.UCGHlblNgay.Name = "UCGHlblNgay";
            this.UCGHlblNgay.Size = new System.Drawing.Size(243, 27);
            this.UCGHlblNgay.TabIndex = 16;
            this.UCGHlblNgay.Text = "Ngày đăng bán";
            // 
            // UCGHlblTenMH
            // 
            this.UCGHlblTenMH.BackColor = System.Drawing.Color.White;
            this.UCGHlblTenMH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCGHlblTenMH.ForeColor = System.Drawing.Color.Red;
            this.UCGHlblTenMH.Location = new System.Drawing.Point(230, 3);
            this.UCGHlblTenMH.Name = "UCGHlblTenMH";
            this.UCGHlblTenMH.Size = new System.Drawing.Size(130, 28);
            this.UCGHlblTenMH.TabIndex = 17;
            this.UCGHlblTenMH.Text = "Tên mặt hàng";
            // 
            // UCGHCheck
            // 
            this.UCGHCheck.AutoSize = true;
            this.UCGHCheck.Location = new System.Drawing.Point(10, 76);
            this.UCGHCheck.Name = "UCGHCheck";
            this.UCGHCheck.Size = new System.Drawing.Size(18, 17);
            this.UCGHCheck.TabIndex = 18;
            this.UCGHCheck.UseVisualStyleBackColor = true;
            this.UCGHCheck.CheckedChanged += new System.EventHandler(this.UCGHCheck_CheckedChanged);
            // 
            // UCGHlblMa
            // 
            this.UCGHlblMa.BackColor = System.Drawing.Color.White;
            this.UCGHlblMa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCGHlblMa.Location = new System.Drawing.Point(230, 55);
            this.UCGHlblMa.Name = "UCGHlblMa";
            this.UCGHlblMa.Size = new System.Drawing.Size(89, 21);
            this.UCGHlblMa.TabIndex = 19;
            this.UCGHlblMa.Text = "Mã mặt hàng";
            // 
            // UCGHbtnLuu
            // 
            this.UCGHbtnLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UCGHbtnLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UCGHbtnLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UCGHbtnLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UCGHbtnLuu.FillColor = System.Drawing.Color.White;
            this.UCGHbtnLuu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCGHbtnLuu.ForeColor = System.Drawing.Color.Black;
            this.UCGHbtnLuu.Location = new System.Drawing.Point(970, 99);
            this.UCGHbtnLuu.Name = "UCGHbtnLuu";
            this.UCGHbtnLuu.Size = new System.Drawing.Size(77, 38);
            this.UCGHbtnLuu.TabIndex = 20;
            this.UCGHbtnLuu.Text = "Lưu";
            this.UCGHbtnLuu.Click += new System.EventHandler(this.UCGHbtnLuu_Click_1);
            // 
            // UCGioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.UCGHbtnLuu);
            this.Controls.Add(this.UCGHlblMa);
            this.Controls.Add(this.UCGHCheck);
            this.Controls.Add(this.UCGHlblTenMH);
            this.Controls.Add(this.UCGHlblNgay);
            this.Controls.Add(this.UCGHlblSoluong);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.UCGHlblThanhtoan);
            this.Controls.Add(this.UCGHbtnXoa);
            this.Controls.Add(this.UCGHlblGiamoi);
            this.Controls.Add(this.UCGHlblGiacu);
            this.Controls.Add(this.UCGHlblLoai);
            this.Controls.Add(this.UCGHImagePicBox);
            this.Controls.Add(this.UCGHUpDown);
            this.Name = "UCGioHang";
            this.Size = new System.Drawing.Size(1055, 166);
            this.Load += new System.EventHandler(this.UCGioHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UCGHUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UCGHImagePicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2NumericUpDown UCGHUpDown;
        private Guna.UI2.WinForms.Guna2PictureBox UCGHImagePicBox;
        private Guna.UI2.WinForms.Guna2ColorTransition guna2ColorTransition1;
        private Guna.UI2.WinForms.Guna2HtmlLabel UCGHlblLoai;
        private Guna.UI2.WinForms.Guna2HtmlLabel UCGHlblGiacu;
        private Guna.UI2.WinForms.Guna2HtmlLabel UCGHlblGiamoi;
        private Guna.UI2.WinForms.Guna2Button UCGHbtnXoa;
        private Guna.UI2.WinForms.Guna2HtmlLabel UCGHlblThanhtoan;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel UCGHlblSoluong;
        private Guna.UI2.WinForms.Guna2HtmlLabel UCGHlblNgay;
        private Guna.UI2.WinForms.Guna2HtmlLabel UCGHlblTenMH;
        public System.Windows.Forms.CheckBox UCGHCheck;
        private Guna.UI2.WinForms.Guna2HtmlLabel UCGHlblMa;
        private Guna.UI2.WinForms.Guna2Button UCGHbtnLuu;
    }
}
