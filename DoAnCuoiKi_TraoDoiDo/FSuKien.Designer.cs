namespace DoAnCuoiKi_TraoDoiDo
{
    partial class FormSuKien
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
            this.gvSKsukien = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimeSKKetthuc = new System.Windows.Forms.DateTimePicker();
            this.dateTimeSKbatdau = new System.Windows.Forms.DateTimePicker();
            this.txtSKGiamgia = new System.Windows.Forms.TextBox();
            this.txtSKTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSKSua = new System.Windows.Forms.Button();
            this.btnSKXoa = new System.Windows.Forms.Button();
            this.btnSKThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvSKsukien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh  sách sự kiện";
            // 
            // gvSKsukien
            // 
            this.gvSKsukien.BackgroundColor = System.Drawing.Color.White;
            this.gvSKsukien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSKsukien.Location = new System.Drawing.Point(17, 45);
            this.gvSKsukien.Margin = new System.Windows.Forms.Padding(4);
            this.gvSKsukien.Name = "gvSKsukien";
            this.gvSKsukien.RowHeadersWidth = 51;
            this.gvSKsukien.RowTemplate.Height = 24;
            this.gvSKsukien.Size = new System.Drawing.Size(454, 445);
            this.gvSKsukien.TabIndex = 1;
            this.gvSKsukien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSKsukien_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimeSKKetthuc);
            this.groupBox1.Controls.Add(this.dateTimeSKbatdau);
            this.groupBox1.Controls.Add(this.txtSKGiamgia);
            this.groupBox1.Controls.Add(this.txtSKTen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(479, 89);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(322, 315);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sự kiện";
            // 
            // dateTimeSKKetthuc
            // 
            this.dateTimeSKKetthuc.Location = new System.Drawing.Point(119, 262);
            this.dateTimeSKKetthuc.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeSKKetthuc.Name = "dateTimeSKKetthuc";
            this.dateTimeSKKetthuc.Size = new System.Drawing.Size(183, 25);
            this.dateTimeSKKetthuc.TabIndex = 8;
            // 
            // dateTimeSKbatdau
            // 
            this.dateTimeSKbatdau.Location = new System.Drawing.Point(119, 186);
            this.dateTimeSKbatdau.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeSKbatdau.Name = "dateTimeSKbatdau";
            this.dateTimeSKbatdau.Size = new System.Drawing.Size(183, 25);
            this.dateTimeSKbatdau.TabIndex = 7;
            // 
            // txtSKGiamgia
            // 
            this.txtSKGiamgia.Location = new System.Drawing.Point(119, 111);
            this.txtSKGiamgia.Margin = new System.Windows.Forms.Padding(4);
            this.txtSKGiamgia.Name = "txtSKGiamgia";
            this.txtSKGiamgia.Size = new System.Drawing.Size(183, 25);
            this.txtSKGiamgia.TabIndex = 6;
            // 
            // txtSKTen
            // 
            this.txtSKTen.Location = new System.Drawing.Point(119, 46);
            this.txtSKTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtSKTen.Name = "txtSKTen";
            this.txtSKTen.Size = new System.Drawing.Size(183, 25);
            this.txtSKTen.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 268);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kết thúc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bắt đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giảm giá (%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sự kiện";
            // 
            // btnSKSua
            // 
            this.btnSKSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSKSua.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSKSua.ForeColor = System.Drawing.Color.Black;
            this.btnSKSua.Image = global::DoAnCuoiKi_TraoDoiDo.Properties.Resources.xoa3;
            this.btnSKSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSKSua.Location = new System.Drawing.Point(708, 449);
            this.btnSKSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSKSua.Name = "btnSKSua";
            this.btnSKSua.Size = new System.Drawing.Size(93, 40);
            this.btnSKSua.TabIndex = 5;
            this.btnSKSua.Text = "Sửa SK";
            this.btnSKSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSKSua.UseVisualStyleBackColor = false;
            this.btnSKSua.Click += new System.EventHandler(this.btnSKSua_Click);
            // 
            // btnSKXoa
            // 
            this.btnSKXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSKXoa.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSKXoa.ForeColor = System.Drawing.Color.Black;
            this.btnSKXoa.Image = global::DoAnCuoiKi_TraoDoiDo.Properties.Resources.edit2;
            this.btnSKXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSKXoa.Location = new System.Drawing.Point(598, 449);
            this.btnSKXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnSKXoa.Name = "btnSKXoa";
            this.btnSKXoa.Size = new System.Drawing.Size(93, 40);
            this.btnSKXoa.TabIndex = 4;
            this.btnSKXoa.Text = "Xóa SK";
            this.btnSKXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSKXoa.UseVisualStyleBackColor = false;
            this.btnSKXoa.Click += new System.EventHandler(this.btnSKXoa_Click);
            // 
            // btnSKThem
            // 
            this.btnSKThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSKThem.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSKThem.ForeColor = System.Drawing.Color.Black;
            this.btnSKThem.Image = global::DoAnCuoiKi_TraoDoiDo.Properties.Resources.icons8_add_48;
            this.btnSKThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSKThem.Location = new System.Drawing.Point(479, 450);
            this.btnSKThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnSKThem.Name = "btnSKThem";
            this.btnSKThem.Size = new System.Drawing.Size(93, 40);
            this.btnSKThem.TabIndex = 3;
            this.btnSKThem.Text = "Thêm SK";
            this.btnSKThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSKThem.UseVisualStyleBackColor = false;
            this.btnSKThem.Click += new System.EventHandler(this.btnSKThem_Click);
            // 
            // FormSuKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(805, 503);
            this.Controls.Add(this.btnSKSua);
            this.Controls.Add(this.btnSKXoa);
            this.Controls.Add(this.btnSKThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gvSKsukien);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSuKien";
            this.Text = "Sự Kiện";
            this.Load += new System.EventHandler(this.FormSuKien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvSKsukien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvSKsukien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimeSKKetthuc;
        private System.Windows.Forms.DateTimePicker dateTimeSKbatdau;
        private System.Windows.Forms.TextBox txtSKGiamgia;
        private System.Windows.Forms.TextBox txtSKTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSKThem;
        private System.Windows.Forms.Button btnSKXoa;
        private System.Windows.Forms.Button btnSKSua;
    }
}