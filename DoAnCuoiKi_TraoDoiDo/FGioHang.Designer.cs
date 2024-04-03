namespace DoAnCuoiKi_TraoDoiDo
{
    partial class FormGioHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.gvGioHang = new System.Windows.Forms.DataGridView();
            this.txtSuKien = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGHQuayLai = new System.Windows.Forms.Button();
            this.btnTcTimkiemSukien = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblGHtinhtrang = new System.Windows.Forms.Label();
            this.lblGhGiaohang = new System.Windows.Forms.Label();
            this.lblGHDiadiem = new System.Windows.Forms.Label();
            this.lblGHSlVou = new System.Windows.Forms.Label();
            this.lblGhSl = new System.Windows.Forms.Label();
            this.lblGhMota = new System.Windows.Forms.Label();
            this.lblGHGiaban = new System.Windows.Forms.Label();
            this.lblGhLoai = new System.Windows.Forms.Label();
            this.lblGhTen = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picImageGH = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblGHMa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvGioHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageGH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giỏ Hàng Của Tôi";
            // 
            // gvGioHang
            // 
            this.gvGioHang.BackgroundColor = System.Drawing.Color.White;
            this.gvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGioHang.Location = new System.Drawing.Point(8, 52);
            this.gvGioHang.Name = "gvGioHang";
            this.gvGioHang.RowHeadersWidth = 51;
            this.gvGioHang.RowTemplate.Height = 24;
            this.gvGioHang.Size = new System.Drawing.Size(532, 451);
            this.gvGioHang.TabIndex = 1;
            this.gvGioHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvGioHang_CellClick);
            // 
            // txtSuKien
            // 
            this.txtSuKien.Location = new System.Drawing.Point(475, 16);
            this.txtSuKien.Name = "txtSuKien";
            this.txtSuKien.Size = new System.Drawing.Size(241, 22);
            this.txtSuKien.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::DoAnCuoiKi_TraoDoiDo.Properties.Resources.xoa3;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(546, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Xóa khỏi giỏ hàng";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::DoAnCuoiKi_TraoDoiDo.Properties.Resources.mua3;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(687, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "Mua ngay";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnGHQuayLai
            // 
            this.btnGHQuayLai.BackColor = System.Drawing.Color.White;
            this.btnGHQuayLai.Image = global::DoAnCuoiKi_TraoDoiDo.Properties.Resources.quaylai2;
            this.btnGHQuayLai.Location = new System.Drawing.Point(756, 4);
            this.btnGHQuayLai.Name = "btnGHQuayLai";
            this.btnGHQuayLai.Size = new System.Drawing.Size(54, 47);
            this.btnGHQuayLai.TabIndex = 5;
            this.btnGHQuayLai.UseVisualStyleBackColor = false;
            this.btnGHQuayLai.Click += new System.EventHandler(this.btnGHQuayLai_Click);
            // 
            // btnTcTimkiemSukien
            // 
            this.btnTcTimkiemSukien.BackColor = System.Drawing.Color.White;
            this.btnTcTimkiemSukien.Image = global::DoAnCuoiKi_TraoDoiDo.Properties.Resources._22;
            this.btnTcTimkiemSukien.Location = new System.Drawing.Point(722, 12);
            this.btnTcTimkiemSukien.Name = "btnTcTimkiemSukien";
            this.btnTcTimkiemSukien.Size = new System.Drawing.Size(28, 30);
            this.btnTcTimkiemSukien.TabIndex = 3;
            this.btnTcTimkiemSukien.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(170)))));
            this.groupBox1.Controls.Add(this.lblGHMa);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblGHtinhtrang);
            this.groupBox1.Controls.Add(this.lblGhGiaohang);
            this.groupBox1.Controls.Add(this.lblGHDiadiem);
            this.groupBox1.Controls.Add(this.lblGHSlVou);
            this.groupBox1.Controls.Add(this.lblGhSl);
            this.groupBox1.Controls.Add(this.lblGhMota);
            this.groupBox1.Controls.Add(this.lblGHGiaban);
            this.groupBox1.Controls.Add(this.lblGhLoai);
            this.groupBox1.Controls.Add(this.lblGhTen);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.picImageGH);
            this.groupBox1.Location = new System.Drawing.Point(547, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 426);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblGHtinhtrang
            // 
            this.lblGHtinhtrang.AutoSize = true;
            this.lblGHtinhtrang.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGHtinhtrang.ForeColor = System.Drawing.Color.White;
            this.lblGHtinhtrang.Location = new System.Drawing.Point(159, 408);
            this.lblGHtinhtrang.Name = "lblGHtinhtrang";
            this.lblGHtinhtrang.Size = new System.Drawing.Size(0, 15);
            this.lblGHtinhtrang.TabIndex = 18;
            // 
            // lblGhGiaohang
            // 
            this.lblGhGiaohang.AutoSize = true;
            this.lblGhGiaohang.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhGiaohang.ForeColor = System.Drawing.Color.White;
            this.lblGhGiaohang.Location = new System.Drawing.Point(159, 385);
            this.lblGhGiaohang.Name = "lblGhGiaohang";
            this.lblGhGiaohang.Size = new System.Drawing.Size(0, 15);
            this.lblGhGiaohang.TabIndex = 17;
            // 
            // lblGHDiadiem
            // 
            this.lblGHDiadiem.AutoSize = true;
            this.lblGHDiadiem.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGHDiadiem.ForeColor = System.Drawing.Color.White;
            this.lblGHDiadiem.Location = new System.Drawing.Point(159, 361);
            this.lblGHDiadiem.Name = "lblGHDiadiem";
            this.lblGHDiadiem.Size = new System.Drawing.Size(0, 15);
            this.lblGHDiadiem.TabIndex = 16;
            // 
            // lblGHSlVou
            // 
            this.lblGHSlVou.AutoSize = true;
            this.lblGHSlVou.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGHSlVou.ForeColor = System.Drawing.Color.White;
            this.lblGHSlVou.Location = new System.Drawing.Point(159, 336);
            this.lblGHSlVou.Name = "lblGHSlVou";
            this.lblGHSlVou.Size = new System.Drawing.Size(0, 15);
            this.lblGHSlVou.TabIndex = 15;
            // 
            // lblGhSl
            // 
            this.lblGhSl.AutoSize = true;
            this.lblGhSl.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhSl.ForeColor = System.Drawing.Color.White;
            this.lblGhSl.Location = new System.Drawing.Point(159, 312);
            this.lblGhSl.Name = "lblGhSl";
            this.lblGhSl.Size = new System.Drawing.Size(0, 15);
            this.lblGhSl.TabIndex = 14;
            // 
            // lblGhMota
            // 
            this.lblGhMota.AutoSize = true;
            this.lblGhMota.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhMota.ForeColor = System.Drawing.Color.White;
            this.lblGhMota.Location = new System.Drawing.Point(159, 286);
            this.lblGhMota.Name = "lblGhMota";
            this.lblGhMota.Size = new System.Drawing.Size(0, 15);
            this.lblGhMota.TabIndex = 13;
            // 
            // lblGHGiaban
            // 
            this.lblGHGiaban.AutoSize = true;
            this.lblGHGiaban.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGHGiaban.ForeColor = System.Drawing.Color.White;
            this.lblGHGiaban.Location = new System.Drawing.Point(159, 259);
            this.lblGHGiaban.Name = "lblGHGiaban";
            this.lblGHGiaban.Size = new System.Drawing.Size(0, 15);
            this.lblGHGiaban.TabIndex = 12;
            // 
            // lblGhLoai
            // 
            this.lblGhLoai.AutoSize = true;
            this.lblGhLoai.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhLoai.ForeColor = System.Drawing.Color.White;
            this.lblGhLoai.Location = new System.Drawing.Point(159, 234);
            this.lblGhLoai.Name = "lblGhLoai";
            this.lblGhLoai.Size = new System.Drawing.Size(0, 15);
            this.lblGhLoai.TabIndex = 11;
            // 
            // lblGhTen
            // 
            this.lblGhTen.AutoSize = true;
            this.lblGhTen.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhTen.ForeColor = System.Drawing.Color.White;
            this.lblGhTen.Location = new System.Drawing.Point(159, 210);
            this.lblGhTen.Name = "lblGhTen";
            this.lblGhTen.Size = new System.Drawing.Size(0, 15);
            this.lblGhTen.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(12, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Giá bán";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tình trạng mặt hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Phương thức giao hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Địa điểm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số lượng Voucher";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mô tả mặt hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại mặt hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên mặt hàng";
            // 
            // picImageGH
            // 
            this.picImageGH.BackColor = System.Drawing.Color.White;
            this.picImageGH.Location = new System.Drawing.Point(6, 13);
            this.picImageGH.Name = "picImageGH";
            this.picImageGH.Size = new System.Drawing.Size(251, 169);
            this.picImageGH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImageGH.TabIndex = 0;
            this.picImageGH.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(12, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Mã mặt hàng";
            // 
            // lblGHMa
            // 
            this.lblGHMa.AutoSize = true;
            this.lblGHMa.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGHMa.ForeColor = System.Drawing.Color.White;
            this.lblGHMa.Location = new System.Drawing.Point(160, 185);
            this.lblGHMa.Name = "lblGHMa";
            this.lblGHMa.Size = new System.Drawing.Size(0, 15);
            this.lblGHMa.TabIndex = 20;
            // 
            // FormGioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(819, 506);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGHQuayLai);
            this.Controls.Add(this.txtSuKien);
            this.Controls.Add(this.btnTcTimkiemSukien);
            this.Controls.Add(this.gvGioHang);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormGioHang";
            this.Text = "Giỏ Hàng";
            this.Load += new System.EventHandler(this.FormGioHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvGioHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageGH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvGioHang;
        private System.Windows.Forms.TextBox txtSuKien;
        private System.Windows.Forms.Button btnTcTimkiemSukien;
        private System.Windows.Forms.Button btnGHQuayLai;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picImageGH;
        private System.Windows.Forms.Label lblGHtinhtrang;
        private System.Windows.Forms.Label lblGhGiaohang;
        private System.Windows.Forms.Label lblGHDiadiem;
        private System.Windows.Forms.Label lblGHSlVou;
        private System.Windows.Forms.Label lblGhSl;
        private System.Windows.Forms.Label lblGhMota;
        private System.Windows.Forms.Label lblGHGiaban;
        private System.Windows.Forms.Label lblGhLoai;
        private System.Windows.Forms.Label lblGhTen;
        private System.Windows.Forms.Label lblGHMa;
        private System.Windows.Forms.Label label11;
    }
}