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
            this.btnGHQuayLai = new System.Windows.Forms.Button();
            this.btnTcTimkiemSukien = new System.Windows.Forms.Button();
            this.ucGioHang1 = new DoAnCuoiKi_TraoDoiDo.UCGioHang();
            ((System.ComponentModel.ISupportInitialize)(this.gvGioHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giỏ Hàng Của Tôi";
            // 
            // gvGioHang
            // 
            this.gvGioHang.BackgroundColor = System.Drawing.Color.White;
            this.gvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGioHang.Location = new System.Drawing.Point(12, 95);
            this.gvGioHang.Name = "gvGioHang";
            this.gvGioHang.RowHeadersWidth = 51;
            this.gvGioHang.RowTemplate.Height = 24;
            this.gvGioHang.Size = new System.Drawing.Size(721, 510);
            this.gvGioHang.TabIndex = 1;
            // 
            // txtSuKien
            // 
            this.txtSuKien.Location = new System.Drawing.Point(418, 57);
            this.txtSuKien.Name = "txtSuKien";
            this.txtSuKien.Size = new System.Drawing.Size(275, 22);
            this.txtSuKien.TabIndex = 4;
            // 
            // btnGHQuayLai
            // 
            this.btnGHQuayLai.BackColor = System.Drawing.Color.White;
            this.btnGHQuayLai.Image = global::DoAnCuoiKi_TraoDoiDo.Properties.Resources.quaylai2;
            this.btnGHQuayLai.Location = new System.Drawing.Point(1023, 2);
            this.btnGHQuayLai.Name = "btnGHQuayLai";
            this.btnGHQuayLai.Size = new System.Drawing.Size(62, 50);
            this.btnGHQuayLai.TabIndex = 5;
            this.btnGHQuayLai.UseVisualStyleBackColor = false;
            this.btnGHQuayLai.Click += new System.EventHandler(this.btnGHQuayLai_Click);
            // 
            // btnTcTimkiemSukien
            // 
            this.btnTcTimkiemSukien.BackColor = System.Drawing.Color.White;
            this.btnTcTimkiemSukien.Image = global::DoAnCuoiKi_TraoDoiDo.Properties.Resources._22;
            this.btnTcTimkiemSukien.Location = new System.Drawing.Point(701, 52);
            this.btnTcTimkiemSukien.Name = "btnTcTimkiemSukien";
            this.btnTcTimkiemSukien.Size = new System.Drawing.Size(32, 32);
            this.btnTcTimkiemSukien.TabIndex = 3;
            this.btnTcTimkiemSukien.UseVisualStyleBackColor = false;
            // 
            // ucGioHang1
            // 
            this.ucGioHang1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ucGioHang1.Location = new System.Drawing.Point(739, 52);
            this.ucGioHang1.Name = "ucGioHang1";
            this.ucGioHang1.Size = new System.Drawing.Size(354, 433);
            this.ucGioHang1.TabIndex = 6;
            this.ucGioHang1.Load += new System.EventHandler(this.ucGioHang1_Load_1);
            // 
            // FormGioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1097, 617);
            this.Controls.Add(this.ucGioHang1);
            this.Controls.Add(this.btnGHQuayLai);
            this.Controls.Add(this.txtSuKien);
            this.Controls.Add(this.btnTcTimkiemSukien);
            this.Controls.Add(this.gvGioHang);
            this.Controls.Add(this.label1);
            this.Name = "FormGioHang";
            this.Text = "Giỏ Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.gvGioHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvGioHang;
        private System.Windows.Forms.TextBox txtSuKien;
        private System.Windows.Forms.Button btnTcTimkiemSukien;
        private System.Windows.Forms.Button btnGHQuayLai;
        private UCGioHang ucGioHang1;
    }
}