﻿namespace DoAnCuoiKi_TraoDoiDo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGioHang));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiemGH = new System.Windows.Forms.TextBox();
            this.flowLPGioHang = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGioHangMua = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGHQuayLai = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-1, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giỏ Hàng Của Tôi";
            // 
            // txtTimKiemGH
            // 
            this.txtTimKiemGH.Location = new System.Drawing.Point(652, 17);
            this.txtTimKiemGH.Name = "txtTimKiemGH";
            this.txtTimKiemGH.Size = new System.Drawing.Size(260, 22);
            this.txtTimKiemGH.TabIndex = 4;
            this.txtTimKiemGH.TextChanged += new System.EventHandler(this.txtTimKiemGH_TextChanged);
            // 
            // flowLPGioHang
            // 
            this.flowLPGioHang.AutoScroll = true;
            this.flowLPGioHang.BackColor = System.Drawing.Color.White;
            this.flowLPGioHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLPGioHang.Location = new System.Drawing.Point(12, 57);
            this.flowLPGioHang.Name = "flowLPGioHang";
            this.flowLPGioHang.Size = new System.Drawing.Size(1013, 496);
            this.flowLPGioHang.TabIndex = 9;
            // 
            // btnGioHangMua
            // 
            this.btnGioHangMua.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(69)))), ((int)(((byte)(40)))));
            this.btnGioHangMua.BorderRadius = 5;
            this.btnGioHangMua.BorderThickness = 10;
            this.btnGioHangMua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGioHangMua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGioHangMua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGioHangMua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGioHangMua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(69)))), ((int)(((byte)(40)))));
            this.btnGioHangMua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGioHangMua.ForeColor = System.Drawing.Color.White;
            this.btnGioHangMua.Location = new System.Drawing.Point(850, 559);
            this.btnGioHangMua.Name = "btnGioHangMua";
            this.btnGioHangMua.Size = new System.Drawing.Size(173, 42);
            this.btnGioHangMua.TabIndex = 15;
            this.btnGioHangMua.Text = "Mua Hàng";
            this.btnGioHangMua.Click += new System.EventHandler(this.btnGioHangMua_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(199, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnGHQuayLai
            // 
            this.btnGHQuayLai.BackColor = System.Drawing.Color.White;
            this.btnGHQuayLai.Image = ((System.Drawing.Image)(resources.GetObject("btnGHQuayLai.Image")));
            this.btnGHQuayLai.Location = new System.Drawing.Point(972, 8);
            this.btnGHQuayLai.Name = "btnGHQuayLai";
            this.btnGHQuayLai.Size = new System.Drawing.Size(51, 48);
            this.btnGHQuayLai.TabIndex = 5;
            this.btnGHQuayLai.UseVisualStyleBackColor = false;
            this.btnGHQuayLai.Click += new System.EventHandler(this.btnGHQuayLai_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(917, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // FormGioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1035, 608);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGioHangMua);
            this.Controls.Add(this.flowLPGioHang);
            this.Controls.Add(this.btnGHQuayLai);
            this.Controls.Add(this.txtTimKiemGH);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormGioHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giỏ Hàng";
            this.Load += new System.EventHandler(this.FormGioHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiemGH;
        private System.Windows.Forms.Button btnGHQuayLai;
        private System.Windows.Forms.FlowLayoutPanel flowLPGioHang;
        private Guna.UI2.WinForms.Guna2Button btnGioHangMua;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}