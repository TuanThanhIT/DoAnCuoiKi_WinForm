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
            this.txtSuKien = new System.Windows.Forms.TextBox();
            this.btnGHQuayLai = new System.Windows.Forms.Button();
            this.btnTcTimkiemSukien = new System.Windows.Forms.Button();
            this.flowLPGioHang = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
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
            // txtSuKien
            // 
            this.txtSuKien.Location = new System.Drawing.Point(475, 16);
            this.txtSuKien.Name = "txtSuKien";
            this.txtSuKien.Size = new System.Drawing.Size(241, 22);
            this.txtSuKien.TabIndex = 4;
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
            // flowLPGioHang
            // 
            this.flowLPGioHang.AutoScroll = true;
            this.flowLPGioHang.BackColor = System.Drawing.Color.White;
            this.flowLPGioHang.Location = new System.Drawing.Point(4, 57);
            this.flowLPGioHang.Name = "flowLPGioHang";
            this.flowLPGioHang.Size = new System.Drawing.Size(806, 408);
            this.flowLPGioHang.TabIndex = 9;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(69)))), ((int)(((byte)(40)))));
            this.guna2Button2.BorderRadius = 5;
            this.guna2Button2.BorderThickness = 10;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(69)))), ((int)(((byte)(40)))));
            this.guna2Button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(646, 471);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(164, 35);
            this.guna2Button2.TabIndex = 15;
            this.guna2Button2.Text = "Mua Hàng";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // FormGioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(819, 518);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.flowLPGioHang);
            this.Controls.Add(this.btnGHQuayLai);
            this.Controls.Add(this.txtSuKien);
            this.Controls.Add(this.btnTcTimkiemSukien);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormGioHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giỏ Hàng";
            this.Load += new System.EventHandler(this.FormGioHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSuKien;
        private System.Windows.Forms.Button btnTcTimkiemSukien;
        private System.Windows.Forms.Button btnGHQuayLai;
        private System.Windows.Forms.FlowLayoutPanel flowLPGioHang;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}