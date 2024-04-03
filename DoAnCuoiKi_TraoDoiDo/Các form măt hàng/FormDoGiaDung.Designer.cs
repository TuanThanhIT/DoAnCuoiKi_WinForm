namespace DoAnCuoiKi_TraoDoiDo
{
    partial class FormDoGiaDung
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
            this.flowLPDogiadung = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐỒ GIA DỤNG";
            // 
            // flowLPDogiadung
            // 
            this.flowLPDogiadung.AutoScroll = true;
            this.flowLPDogiadung.Location = new System.Drawing.Point(3, 46);
            this.flowLPDogiadung.Name = "flowLPDogiadung";
            this.flowLPDogiadung.Size = new System.Drawing.Size(1071, 436);
            this.flowLPDogiadung.TabIndex = 2;
            // 
            // FormDoGiaDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(1072, 484);
            this.Controls.Add(this.flowLPDogiadung);
            this.Controls.Add(this.label1);
            this.Name = "FormDoGiaDung";
            this.Text = "Đồ Gia Dụng";
            this.Load += new System.EventHandler(this.FormDoGiaDung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLPDogiadung;
    }
}