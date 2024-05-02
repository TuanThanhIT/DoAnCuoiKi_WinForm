namespace DoAnCuoiKi_TraoDoiDo
{
    partial class FormRTKBanHang
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
            this.rpvBanHang = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvBanHang
            // 
            this.rpvBanHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvBanHang.Location = new System.Drawing.Point(0, 0);
            this.rpvBanHang.Name = "rpvBanHang";
            this.rpvBanHang.ServerReport.BearerToken = null;
            this.rpvBanHang.Size = new System.Drawing.Size(892, 538);
            this.rpvBanHang.TabIndex = 0;
            // 
            // FormRTKBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 538);
            this.Controls.Add(this.rpvBanHang);
            this.Name = "FormRTKBanHang";
            this.Text = "Thống Kê Bán Hàng";
            this.Load += new System.EventHandler(this.FRTKBanHang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvBanHang;
    }
}