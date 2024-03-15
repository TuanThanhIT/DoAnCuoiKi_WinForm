namespace DoAnCuoiKi_TraoDoiDo
{
    partial class FormTatCaMatHang
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
            this.ucHienThi1 = new DoAnCuoiKi_TraoDoiDo.UCHienThi();
            this.ucHienThi2 = new DoAnCuoiKi_TraoDoiDo.UCHienThi();
            this.ucHienThi3 = new DoAnCuoiKi_TraoDoiDo.UCHienThi();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "TẤT CẢ";
            // 
            // ucHienThi1
            // 
            this.ucHienThi1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ucHienThi1.Location = new System.Drawing.Point(12, 50);
            this.ucHienThi1.Name = "ucHienThi1";
            this.ucHienThi1.Size = new System.Drawing.Size(129, 176);
            this.ucHienThi1.TabIndex = 1;
            this.ucHienThi1.Load += new System.EventHandler(this.ucHienThi1_Load);
            // 
            // ucHienThi2
            // 
            this.ucHienThi2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ucHienThi2.Location = new System.Drawing.Point(171, 50);
            this.ucHienThi2.Name = "ucHienThi2";
            this.ucHienThi2.Size = new System.Drawing.Size(129, 176);
            this.ucHienThi2.TabIndex = 2;
            // 
            // ucHienThi3
            // 
            this.ucHienThi3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ucHienThi3.Location = new System.Drawing.Point(324, 50);
            this.ucHienThi3.Name = "ucHienThi3";
            this.ucHienThi3.Size = new System.Drawing.Size(129, 176);
            this.ucHienThi3.TabIndex = 3;
            // 
            // FormTatCaMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1038, 487);
            this.Controls.Add(this.ucHienThi3);
            this.Controls.Add(this.ucHienThi2);
            this.Controls.Add(this.ucHienThi1);
            this.Controls.Add(this.label1);
            this.Name = "FormTatCaMatHang";
            this.Text = "Tất cả mặt hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private UCHienThi ucHienThi1;
        private UCHienThi ucHienThi2;
        private UCHienThi ucHienThi3;
    }
}