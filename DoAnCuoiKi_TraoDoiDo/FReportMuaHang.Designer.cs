namespace DoAnCuoiKi_TraoDoiDo
{
    partial class FormReportMuaHang
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
            this.rptMuaHang = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptMuaHang
            // 
            this.rptMuaHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptMuaHang.LocalReport.ReportEmbeddedResource = "DoAnCuoiKi_TraoDoiDo.ReportMuaHang.rdlc";
            this.rptMuaHang.Location = new System.Drawing.Point(0, 0);
            this.rptMuaHang.Name = "rptMuaHang";
            this.rptMuaHang.ServerReport.BearerToken = null;
            this.rptMuaHang.Size = new System.Drawing.Size(892, 538);
            this.rptMuaHang.TabIndex = 0;
            // 
            // FormReportMuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 538);
            this.Controls.Add(this.rptMuaHang);
            this.Name = "FormReportMuaHang";
            this.Text = "Báo cáo mua hàng";
            this.Load += new System.EventHandler(this.FReportMuaHang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptMuaHang;
    }
}