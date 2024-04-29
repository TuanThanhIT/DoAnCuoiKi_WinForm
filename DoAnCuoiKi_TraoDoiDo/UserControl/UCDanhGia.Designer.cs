namespace DoAnCuoiKi_TraoDoiDo
{
    partial class UCDanhGia
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UCDGRateStar = new Guna.UI2.WinForms.Guna2RatingStar();
            this.UCDGlblTen = new System.Windows.Forms.Label();
            this.UCDGlblDanhgia = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UCDGRateStar
            // 
            this.UCDGRateStar.Location = new System.Drawing.Point(6, 40);
            this.UCDGRateStar.Name = "UCDGRateStar";
            this.UCDGRateStar.RatingColor = System.Drawing.Color.Red;
            this.UCDGRateStar.Size = new System.Drawing.Size(77, 18);
            this.UCDGRateStar.TabIndex = 4;
            this.UCDGRateStar.Value = 2.5F;
            // 
            // UCDGlblTen
            // 
            this.UCDGlblTen.AutoSize = true;
            this.UCDGlblTen.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCDGlblTen.Location = new System.Drawing.Point(47, 15);
            this.UCDGlblTen.Name = "UCDGlblTen";
            this.UCDGlblTen.Size = new System.Drawing.Size(120, 19);
            this.UCDGlblTen.TabIndex = 5;
            this.UCDGlblTen.Text = "Ten nguoi dung";
            // 
            // UCDGlblDanhgia
            // 
            this.UCDGlblDanhgia.AutoSize = true;
            this.UCDGlblDanhgia.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCDGlblDanhgia.Location = new System.Drawing.Point(18, 61);
            this.UCDGlblDanhgia.Name = "UCDGlblDanhgia";
            this.UCDGlblDanhgia.Size = new System.Drawing.Size(55, 15);
            this.UCDGlblDanhgia.TabIndex = 6;
            this.UCDGlblDanhgia.Text = "Danh gia";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAnCuoiKi_TraoDoiDo.Properties.Resources.icons8_users_96;
            this.pictureBox1.Location = new System.Drawing.Point(3, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // UCDanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UCDGlblDanhgia);
            this.Controls.Add(this.UCDGlblTen);
            this.Controls.Add(this.UCDGRateStar);
            this.Name = "UCDanhGia";
            this.Size = new System.Drawing.Size(250, 89);
            this.Load += new System.EventHandler(this.UCDanhGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2RatingStar UCDGRateStar;
        private System.Windows.Forms.Label UCDGlblTen;
        private System.Windows.Forms.Label UCDGlblDanhgia;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
