namespace DoAnCuoiKi_TraoDoiDo
{
    partial class UCHienThi
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
            this.UCbtnChiTiet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UCHTlblGia = new System.Windows.Forms.Label();
            this.UCHTPictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UCHTlblTen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UCHTPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UCbtnChiTiet
            // 
            this.UCbtnChiTiet.Location = new System.Drawing.Point(55, 206);
            this.UCbtnChiTiet.Name = "UCbtnChiTiet";
            this.UCbtnChiTiet.Size = new System.Drawing.Size(69, 28);
            this.UCbtnChiTiet.TabIndex = 0;
            this.UCbtnChiTiet.Text = "Chi Tiết";
            this.UCbtnChiTiet.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Giá tiền";
            // 
            // UCHTlblGia
            // 
            this.UCHTlblGia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UCHTlblGia.ForeColor = System.Drawing.Color.White;
            this.UCHTlblGia.Location = new System.Drawing.Point(95, 175);
            this.UCHTlblGia.Name = "UCHTlblGia";
            this.UCHTlblGia.Size = new System.Drawing.Size(94, 16);
            this.UCHTlblGia.TabIndex = 4;
            // 
            // UCHTPictureBox
            // 
            this.UCHTPictureBox.BackColor = System.Drawing.Color.White;
            this.UCHTPictureBox.Location = new System.Drawing.Point(3, 3);
            this.UCHTPictureBox.Name = "UCHTPictureBox";
            this.UCHTPictureBox.Size = new System.Drawing.Size(189, 120);
            this.UCHTPictureBox.TabIndex = 1;
            this.UCHTPictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên mặt hàng";
            // 
            // UCHTlblTen
            // 
            this.UCHTlblTen.BackColor = System.Drawing.Color.White;
            this.UCHTlblTen.Location = new System.Drawing.Point(95, 146);
            this.UCHTlblTen.Name = "UCHTlblTen";
            this.UCHTlblTen.Size = new System.Drawing.Size(94, 16);
            this.UCHTlblTen.TabIndex = 6;
            // 
            // UCHienThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.UCHTlblTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UCHTlblGia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UCHTPictureBox);
            this.Controls.Add(this.UCbtnChiTiet);
            this.Name = "UCHienThi";
            this.Size = new System.Drawing.Size(195, 234);
            this.Load += new System.EventHandler(this.UCHienThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UCHTPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button UCbtnChiTiet;
        public System.Windows.Forms.PictureBox UCHTPictureBox;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label UCHTlblGia;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label UCHTlblTen;
    }
}
