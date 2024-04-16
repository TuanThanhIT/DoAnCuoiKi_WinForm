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
            this.flowLPHienthiAll = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "TẤT CẢ";
            // 
            // flowLPHienthiAll
            // 
            this.flowLPHienthiAll.AutoScroll = true;
            this.flowLPHienthiAll.Location = new System.Drawing.Point(3, 35);
            this.flowLPHienthiAll.Name = "flowLPHienthiAll";
            this.flowLPHienthiAll.Size = new System.Drawing.Size(1056, 450);
            this.flowLPHienthiAll.TabIndex = 1;
            // 
            // FormTatCaMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(1064, 487);
            this.Controls.Add(this.flowLPHienthiAll);
            this.Controls.Add(this.label1);
            this.Name = "FormTatCaMatHang";
            this.Text = "Tất cả mặt hàng";
            this.Load += new System.EventHandler(this.FormTatCaMatHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLPHienthiAll;
    }
}