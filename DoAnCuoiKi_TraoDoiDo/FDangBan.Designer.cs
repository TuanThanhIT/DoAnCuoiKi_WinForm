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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnDangbanXuat = new System.Windows.Forms.Button();
            this.btnDbChinhsua = new System.Windows.Forms.Button();
            this.btnDbXoa = new System.Windows.Forms.Button();
            this.gvDangban = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDbQuaylai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvDangban)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDangbanXuat
            // 
            this.btnDangbanXuat.Location = new System.Drawing.Point(779, 588);
            this.btnDangbanXuat.Name = "btnDangbanXuat";
            this.btnDangbanXuat.Size = new System.Drawing.Size(96, 36);
            this.btnDangbanXuat.TabIndex = 1;
            this.btnDangbanXuat.Text = "Xuất báo cáo";
            this.btnDangbanXuat.UseVisualStyleBackColor = true;
            // 
            // btnDbChinhsua
            // 
            this.btnDbChinhsua.Location = new System.Drawing.Point(881, 588);
            this.btnDbChinhsua.Name = "btnDbChinhsua";
            this.btnDbChinhsua.Size = new System.Drawing.Size(96, 36);
            this.btnDbChinhsua.TabIndex = 2;
            this.btnDbChinhsua.Text = "Chỉnh sửa";
            this.btnDbChinhsua.UseVisualStyleBackColor = true;
            this.btnDbChinhsua.Click += new System.EventHandler(this.btnDbChinhsua_Click);
            // 
            // btnDbXoa
            // 
            this.btnDbXoa.Location = new System.Drawing.Point(983, 588);
            this.btnDbXoa.Name = "btnDbXoa";
            this.btnDbXoa.Size = new System.Drawing.Size(96, 36);
            this.btnDbXoa.TabIndex = 3;
            this.btnDbXoa.Text = "Xóa";
            this.btnDbXoa.UseVisualStyleBackColor = true;
            this.btnDbXoa.Click += new System.EventHandler(this.btnDbXoa_Click);
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
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Đang bán";
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1087, 636);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvDangban);
            this.Controls.Add(this.btnDbQuaylai);
            this.Controls.Add(this.btnDbXoa);
            this.Controls.Add(this.btnDangbanXuat);
            this.Controls.Add(this.btnDbChinhsua);
            this.Name = "FormDangBan";
            this.Text = "Đang bán";
            this.Load += new System.EventHandler(this.FormDangBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDangban)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnDangbanXuat;
        private System.Windows.Forms.Button btnDbChinhsua;
        private System.Windows.Forms.Button btnDbXoa;
        private System.Windows.Forms.Button btnDbQuaylai;
        public System.Windows.Forms.DataGridView gvDangban;
        private System.Windows.Forms.Label label1;
    }
}