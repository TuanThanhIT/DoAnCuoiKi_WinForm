namespace DoAnCuoiKi_TraoDoiDo
{
    partial class FormRLSBanHang
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
            this.rptBanHang = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptBanHang
            // 
            this.rptBanHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptBanHang.Location = new System.Drawing.Point(0, 0);
            this.rptBanHang.Name = "rptBanHang";
            this.rptBanHang.ServerReport.BearerToken = null;
            this.rptBanHang.Size = new System.Drawing.Size(871, 524);
            this.rptBanHang.TabIndex = 0;
            // 
            // FormRLSBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 524);
            this.Controls.Add(this.rptBanHang);
            this.Name = "FormRLSBanHang";
            this.Text = "Báo cáo bán hàng";
            this.Load += new System.EventHandler(this.FormRLSBanHang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptBanHang;
    }
}