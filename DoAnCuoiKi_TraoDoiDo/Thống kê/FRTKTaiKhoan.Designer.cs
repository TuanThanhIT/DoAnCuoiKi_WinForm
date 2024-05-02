namespace DoAnCuoiKi_TraoDoiDo
{
    partial class FormRTKTaiKhoan
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
            this.rpvTKTaiKhoan = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvTKTaiKhoan
            // 
            this.rpvTKTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvTKTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.rpvTKTaiKhoan.Name = "rpvTKTaiKhoan";
            this.rpvTKTaiKhoan.ServerReport.BearerToken = null;
            this.rpvTKTaiKhoan.Size = new System.Drawing.Size(892, 538);
            this.rpvTKTaiKhoan.TabIndex = 0;
            // 
            // FormRTKTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 538);
            this.Controls.Add(this.rpvTKTaiKhoan);
            this.Name = "FormRTKTaiKhoan";
            this.Text = "Thống Kê Tài Khoản";
            this.Load += new System.EventHandler(this.FRTKTaiKhoan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvTKTaiKhoan;
    }
}