namespace DoAnCuoiKi_TraoDoiDo
{
    partial class FormLSMuaHang
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
            this.dgvLSMuaHang = new System.Windows.Forms.DataGridView();
            this.btnXuatReportLsMH = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnXoaLsMH = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSMuaHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lịch Sử Mua Hàng";
            // 
            // dgvLSMuaHang
            // 
            this.dgvLSMuaHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvLSMuaHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLSMuaHang.Location = new System.Drawing.Point(12, 48);
            this.dgvLSMuaHang.Name = "dgvLSMuaHang";
            this.dgvLSMuaHang.RowHeadersWidth = 51;
            this.dgvLSMuaHang.Size = new System.Drawing.Size(1061, 530);
            this.dgvLSMuaHang.TabIndex = 1;
            // 
            // btnXuatReportLsMH
            // 
            this.btnXuatReportLsMH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnXuatReportLsMH.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatReportLsMH.Image = global::DoAnCuoiKi_TraoDoiDo.Properties.Resources.Report3;
            this.btnXuatReportLsMH.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuatReportLsMH.Location = new System.Drawing.Point(698, 584);
            this.btnXuatReportLsMH.Name = "btnXuatReportLsMH";
            this.btnXuatReportLsMH.Size = new System.Drawing.Size(121, 36);
            this.btnXuatReportLsMH.TabIndex = 2;
            this.btnXuatReportLsMH.Text = "Xuất Báo Cáo";
            this.btnXuatReportLsMH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatReportLsMH.UseVisualStyleBackColor = false;
            // 
            // btnBanHang
            // 
            this.btnBanHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnBanHang.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanHang.Image = global::DoAnCuoiKi_TraoDoiDo.Properties.Resources.history2;
            this.btnBanHang.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBanHang.Location = new System.Drawing.Point(952, 584);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(121, 36);
            this.btnBanHang.TabIndex = 3;
            this.btnBanHang.Text = "Lịch Sử Bán Hàng";
            this.btnBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanHang.UseVisualStyleBackColor = false;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // btnXoaLsMH
            // 
            this.btnXoaLsMH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnXoaLsMH.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLsMH.Image = global::DoAnCuoiKi_TraoDoiDo.Properties.Resources.xoa3;
            this.btnXoaLsMH.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaLsMH.Location = new System.Drawing.Point(825, 584);
            this.btnXoaLsMH.Name = "btnXoaLsMH";
            this.btnXoaLsMH.Size = new System.Drawing.Size(121, 36);
            this.btnXoaLsMH.TabIndex = 5;
            this.btnXoaLsMH.Text = "Xóa Lịch Sử";
            this.btnXoaLsMH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaLsMH.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.Image = global::DoAnCuoiKi_TraoDoiDo.Properties.Resources.quaylai2;
            this.btnThoat.Location = new System.Drawing.Point(1014, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(59, 44);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FormLSMuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(1078, 626);
            this.Controls.Add(this.btnXoaLsMH);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnBanHang);
            this.Controls.Add(this.btnXuatReportLsMH);
            this.Controls.Add(this.dgvLSMuaHang);
            this.Controls.Add(this.label1);
            this.Name = "FormLSMuaHang";
            this.Text = "Lịch Sử Mua Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSMuaHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLSMuaHang;
        private System.Windows.Forms.Button btnXuatReportLsMH;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoaLsMH;
    }
}