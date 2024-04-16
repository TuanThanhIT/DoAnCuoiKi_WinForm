namespace DoAnCuoiKi_TraoDoiDo
{
    partial class FormDangBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangBan));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gvDangban = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDbChinhsua = new Guna.UI2.WinForms.Guna2Button();
            this.btnDangbanXuatReport = new Guna.UI2.WinForms.Guna2Button();
            this.btnDbXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnDbQuaylai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvDangban)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDangban
            // 
            this.gvDangban.BackgroundColor = System.Drawing.Color.White;
            this.gvDangban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDangban.Location = new System.Drawing.Point(2, 59);
            this.gvDangban.Name = "gvDangban";
            this.gvDangban.RowHeadersWidth = 51;
            this.gvDangban.RowTemplate.Height = 24;
            this.gvDangban.Size = new System.Drawing.Size(1077, 523);
            this.gvDangban.TabIndex = 5;
            this.gvDangban.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDangban_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Đang bán";
            // 
            // btnDbChinhsua
            // 
            this.btnDbChinhsua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDbChinhsua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDbChinhsua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDbChinhsua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDbChinhsua.FillColor = System.Drawing.Color.OrangeRed;
            this.btnDbChinhsua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDbChinhsua.ForeColor = System.Drawing.Color.White;
            this.btnDbChinhsua.Image = ((System.Drawing.Image)(resources.GetObject("btnDbChinhsua.Image")));
            this.btnDbChinhsua.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDbChinhsua.Location = new System.Drawing.Point(821, 588);
            this.btnDbChinhsua.Name = "btnDbChinhsua";
            this.btnDbChinhsua.Size = new System.Drawing.Size(118, 45);
            this.btnDbChinhsua.TabIndex = 9;
            this.btnDbChinhsua.Text = "Chỉnh sửa";
            this.btnDbChinhsua.Click += new System.EventHandler(this.btnDbChinhsua_Click_1);
            // 
            // btnDangbanXuatReport
            // 
            this.btnDangbanXuatReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangbanXuatReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangbanXuatReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangbanXuatReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangbanXuatReport.FillColor = System.Drawing.Color.OrangeRed;
            this.btnDangbanXuatReport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDangbanXuatReport.ForeColor = System.Drawing.Color.White;
            this.btnDangbanXuatReport.Image = ((System.Drawing.Image)(resources.GetObject("btnDangbanXuatReport.Image")));
            this.btnDangbanXuatReport.ImageSize = new System.Drawing.Size(35, 35);
            this.btnDangbanXuatReport.Location = new System.Drawing.Point(650, 588);
            this.btnDangbanXuatReport.Name = "btnDangbanXuatReport";
            this.btnDangbanXuatReport.Size = new System.Drawing.Size(146, 45);
            this.btnDangbanXuatReport.TabIndex = 8;
            this.btnDangbanXuatReport.Text = "Xuất báo cáo";
            // 
            // btnDbXoa
            // 
            this.btnDbXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDbXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDbXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDbXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDbXoa.FillColor = System.Drawing.Color.OrangeRed;
            this.btnDbXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDbXoa.ForeColor = System.Drawing.Color.White;
            this.btnDbXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnDbXoa.Image")));
            this.btnDbXoa.ImageSize = new System.Drawing.Size(40, 40);
            this.btnDbXoa.Location = new System.Drawing.Point(961, 588);
            this.btnDbXoa.Name = "btnDbXoa";
            this.btnDbXoa.Size = new System.Drawing.Size(118, 45);
            this.btnDbXoa.TabIndex = 7;
            this.btnDbXoa.Text = "Xóa";
            this.btnDbXoa.Click += new System.EventHandler(this.btnDbXoa_Click_1);
            // 
            // btnDbQuaylai
            // 
            this.btnDbQuaylai.BackColor = System.Drawing.Color.White;
            this.btnDbQuaylai.Image = global::DoAnCuoiKi_TraoDoiDo.Properties.Resources.quaylai2;
            this.btnDbQuaylai.Location = new System.Drawing.Point(992, 4);
            this.btnDbQuaylai.Name = "btnDbQuaylai";
            this.btnDbQuaylai.Size = new System.Drawing.Size(83, 49);
            this.btnDbQuaylai.TabIndex = 4;
            this.btnDbQuaylai.UseVisualStyleBackColor = false;
            this.btnDbQuaylai.Click += new System.EventHandler(this.btnDbQuaylai_Click);
            // 
            // FormDangBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(1087, 636);
            this.Controls.Add(this.btnDbChinhsua);
            this.Controls.Add(this.btnDangbanXuatReport);
            this.Controls.Add(this.btnDbXoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvDangban);
            this.Controls.Add(this.btnDbQuaylai);
            this.Name = "FormDangBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đang bán";
            this.Load += new System.EventHandler(this.FormDangBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDangban)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnDbQuaylai;
        public System.Windows.Forms.DataGridView gvDangban;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnDbXoa;
        private Guna.UI2.WinForms.Guna2Button btnDangbanXuatReport;
        private Guna.UI2.WinForms.Guna2Button btnDbChinhsua;
    }
}