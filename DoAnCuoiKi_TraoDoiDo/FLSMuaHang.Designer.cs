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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLSMuaHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnXoaLS = new Guna.UI2.WinForms.Guna2Button();
            this.btnLSXuatBaocao = new Guna.UI2.WinForms.Guna2Button();
            this.gvLSMuaHang = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLSMuaHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lịch Sử Mua Hàng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(186, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnXoaLS
            // 
            this.btnXoaLS.BorderColor = System.Drawing.Color.Red;
            this.btnXoaLS.BorderRadius = 5;
            this.btnXoaLS.BorderThickness = 2;
            this.btnXoaLS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaLS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaLS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaLS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaLS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(232)))));
            this.btnXoaLS.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLS.ForeColor = System.Drawing.Color.Black;
            this.btnXoaLS.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaLS.Image")));
            this.btnXoaLS.Location = new System.Drawing.Point(922, 524);
            this.btnXoaLS.Name = "btnXoaLS";
            this.btnXoaLS.Size = new System.Drawing.Size(132, 41);
            this.btnXoaLS.TabIndex = 3;
            this.btnXoaLS.Text = "Xóa lịch sử";
            this.btnXoaLS.Click += new System.EventHandler(this.btnXoaLS_Click);
            // 
            // btnLSXuatBaocao
            // 
            this.btnLSXuatBaocao.BorderColor = System.Drawing.Color.Red;
            this.btnLSXuatBaocao.BorderRadius = 5;
            this.btnLSXuatBaocao.BorderThickness = 2;
            this.btnLSXuatBaocao.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLSXuatBaocao.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLSXuatBaocao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLSXuatBaocao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLSXuatBaocao.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(232)))));
            this.btnLSXuatBaocao.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLSXuatBaocao.ForeColor = System.Drawing.Color.Black;
            this.btnLSXuatBaocao.Image = global::DoAnCuoiKi_TraoDoiDo.Properties.Resources.icons8_report_96;
            this.btnLSXuatBaocao.Location = new System.Drawing.Point(774, 524);
            this.btnLSXuatBaocao.Name = "btnLSXuatBaocao";
            this.btnLSXuatBaocao.Size = new System.Drawing.Size(132, 41);
            this.btnLSXuatBaocao.TabIndex = 2;
            this.btnLSXuatBaocao.Text = "Xuất báo cáo";
            this.btnLSXuatBaocao.Click += new System.EventHandler(this.btnLSXuatBaocao_Click);
            // 
            // gvLSMuaHang
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.gvLSMuaHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gvLSMuaHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvLSMuaHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gvLSMuaHang.ColumnHeadersHeight = 35;
            this.gvLSMuaHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvLSMuaHang.DefaultCellStyle = dataGridViewCellStyle9;
            this.gvLSMuaHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.gvLSMuaHang.Location = new System.Drawing.Point(4, 68);
            this.gvLSMuaHang.Name = "gvLSMuaHang";
            this.gvLSMuaHang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvLSMuaHang.RowHeadersVisible = false;
            this.gvLSMuaHang.RowHeadersWidth = 51;
            this.gvLSMuaHang.RowTemplate.Height = 24;
            this.gvLSMuaHang.Size = new System.Drawing.Size(1051, 438);
            this.gvLSMuaHang.TabIndex = 10;
            this.gvLSMuaHang.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.gvLSMuaHang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.gvLSMuaHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gvLSMuaHang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gvLSMuaHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gvLSMuaHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gvLSMuaHang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gvLSMuaHang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.gvLSMuaHang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.gvLSMuaHang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvLSMuaHang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvLSMuaHang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.gvLSMuaHang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gvLSMuaHang.ThemeStyle.HeaderStyle.Height = 35;
            this.gvLSMuaHang.ThemeStyle.ReadOnly = false;
            this.gvLSMuaHang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.gvLSMuaHang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvLSMuaHang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvLSMuaHang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gvLSMuaHang.ThemeStyle.RowsStyle.Height = 24;
            this.gvLSMuaHang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.gvLSMuaHang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // FormLSMuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1057, 567);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnXoaLS);
            this.Controls.Add(this.btnLSXuatBaocao);
            this.Controls.Add(this.gvLSMuaHang);
            this.Controls.Add(this.label1);
            this.Name = "FormLSMuaHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch Sử Mua Hàng";
            this.Load += new System.EventHandler(this.FormLSMuaHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLSMuaHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnLSXuatBaocao;
        private Guna.UI2.WinForms.Guna2Button btnXoaLS;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView gvLSMuaHang;
    }
}