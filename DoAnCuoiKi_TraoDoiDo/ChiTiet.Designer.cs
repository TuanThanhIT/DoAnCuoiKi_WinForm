namespace DoAnCuoiKi_TraoDoiDo
{
    partial class FormChiTiet
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
            this.ucChiTiet1 = new DoAnCuoiKi_TraoDoiDo.UCChiTiet();
            this.SuspendLayout();
            // 
            // ucChiTiet1
            // 
            this.ucChiTiet1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ucChiTiet1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucChiTiet1.Location = new System.Drawing.Point(0, 0);
            this.ucChiTiet1.Name = "ucChiTiet1";
            this.ucChiTiet1.Size = new System.Drawing.Size(422, 626);
            this.ucChiTiet1.TabIndex = 0;
            this.ucChiTiet1.Load += new System.EventHandler(this.ucChiTiet1_Load);
            // 
            // FormChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 626);
            this.Controls.Add(this.ucChiTiet1);
            this.Name = "FormChiTiet";
            this.Text = "Chi Tiết";
            this.ResumeLayout(false);

        }

        #endregion

        private UCChiTiet ucChiTiet1;
    }
}