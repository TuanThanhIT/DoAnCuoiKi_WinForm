namespace DoAnCuoiKi_TraoDoiDo
{
    partial class UCThanhToan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UCTTpicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.UCTTTen = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.UCTTLoai = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.UCTTGiaBan = new System.Windows.Forms.Label();
            this.UCTTSoluong = new System.Windows.Forms.Label();
            this.UCTTThanhTien = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.UCTTtxtMaVou = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UCTTbtnApMa = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.UCTTpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(503, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(612, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thành tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(380, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn giá";
            // 
            // UCTTpicture
            // 
            this.UCTTpicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UCTTpicture.ImageRotate = 0F;
            this.UCTTpicture.Location = new System.Drawing.Point(7, 62);
            this.UCTTpicture.Name = "UCTTpicture";
            this.UCTTpicture.Size = new System.Drawing.Size(81, 73);
            this.UCTTpicture.TabIndex = 4;
            this.UCTTpicture.TabStop = false;
            // 
            // UCTTTen
            // 
            this.UCTTTen.BackColor = System.Drawing.Color.Transparent;
            this.UCTTTen.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCTTTen.Location = new System.Drawing.Point(104, 69);
            this.UCTTTen.Name = "UCTTTen";
            this.UCTTTen.Size = new System.Drawing.Size(137, 28);
            this.UCTTTen.TabIndex = 5;
            this.UCTTTen.Text = "Xe máy Sirius 150";
            this.UCTTTen.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UCTTLoai
            // 
            this.UCTTLoai.BackColor = System.Drawing.Color.Transparent;
            this.UCTTLoai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCTTLoai.Location = new System.Drawing.Point(235, 116);
            this.UCTTLoai.Name = "UCTTLoai";
            this.UCTTLoai.Size = new System.Drawing.Size(98, 21);
            this.UCTTLoai.TabIndex = 6;
            this.UCTTLoai.Text = "Loại mặt hàng";
            this.UCTTLoai.Click += new System.EventHandler(this.guna2HtmlLabel2_Click);
            // 
            // UCTTGiaBan
            // 
            this.UCTTGiaBan.AutoSize = true;
            this.UCTTGiaBan.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCTTGiaBan.Location = new System.Drawing.Point(381, 80);
            this.UCTTGiaBan.Name = "UCTTGiaBan";
            this.UCTTGiaBan.Size = new System.Drawing.Size(64, 17);
            this.UCTTGiaBan.TabIndex = 7;
            this.UCTTGiaBan.Text = "10000000";
            // 
            // UCTTSoluong
            // 
            this.UCTTSoluong.AutoSize = true;
            this.UCTTSoluong.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCTTSoluong.Location = new System.Drawing.Point(531, 80);
            this.UCTTSoluong.Name = "UCTTSoluong";
            this.UCTTSoluong.Size = new System.Drawing.Size(15, 17);
            this.UCTTSoluong.TabIndex = 8;
            this.UCTTSoluong.Text = "2";
            // 
            // UCTTThanhTien
            // 
            this.UCTTThanhTien.AutoSize = true;
            this.UCTTThanhTien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCTTThanhTien.Location = new System.Drawing.Point(628, 80);
            this.UCTTThanhTien.Name = "UCTTThanhTien";
            this.UCTTThanhTien.Size = new System.Drawing.Size(64, 17);
            this.UCTTThanhTien.TabIndex = 9;
            this.UCTTThanhTien.Text = "20000000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(410, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Mã Voucher: ";
            // 
            // UCTTtxtMaVou
            // 
            this.UCTTtxtMaVou.Location = new System.Drawing.Point(473, 140);
            this.UCTTtxtMaVou.Name = "UCTTtxtMaVou";
            this.UCTTtxtMaVou.Size = new System.Drawing.Size(121, 22);
            this.UCTTtxtMaVou.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // UCTTbtnApMa
            // 
            this.UCTTbtnApMa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.UCTTbtnApMa.BorderRadius = 5;
            this.UCTTbtnApMa.BorderThickness = 1;
            this.UCTTbtnApMa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UCTTbtnApMa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UCTTbtnApMa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UCTTbtnApMa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UCTTbtnApMa.FillColor = System.Drawing.Color.White;
            this.UCTTbtnApMa.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCTTbtnApMa.ForeColor = System.Drawing.Color.Black;
            this.UCTTbtnApMa.Location = new System.Drawing.Point(616, 140);
            this.UCTTbtnApMa.Name = "UCTTbtnApMa";
            this.UCTTbtnApMa.Size = new System.Drawing.Size(73, 22);
            this.UCTTbtnApMa.TabIndex = 13;
            this.UCTTbtnApMa.Text = "Áp mã";
            // 
            // UCThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.UCTTbtnApMa);
            this.Controls.Add(this.UCTTtxtMaVou);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.UCTTThanhTien);
            this.Controls.Add(this.UCTTSoluong);
            this.Controls.Add(this.UCTTGiaBan);
            this.Controls.Add(this.UCTTLoai);
            this.Controls.Add(this.UCTTTen);
            this.Controls.Add(this.UCTTpicture);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCThanhToan";
            this.Size = new System.Drawing.Size(724, 170);
            ((System.ComponentModel.ISupportInitialize)(this.UCTTpicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2PictureBox UCTTpicture;
        private Guna.UI2.WinForms.Guna2HtmlLabel UCTTTen;
        private Guna.UI2.WinForms.Guna2HtmlLabel UCTTLoai;
        private System.Windows.Forms.Label UCTTGiaBan;
        private System.Windows.Forms.Label UCTTSoluong;
        private System.Windows.Forms.Label UCTTThanhTien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox UCTTtxtMaVou;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Guna.UI2.WinForms.Guna2Button UCTTbtnApMa;
    }
}
