using System.Windows.Forms;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSuKien));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimeSKKetthuc = new System.Windows.Forms.DateTimePicker();
            this.dateTimeSKbatdau = new System.Windows.Forms.DateTimePicker();
            this.txtSKGiamgia = new System.Windows.Forms.TextBox();
            this.txtSKTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gvSKsukien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSkSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnSkXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSkThem = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSKsukien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh  sách sự kiện";
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
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(479, 89);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(313, 315);
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
            // gvSKsukien
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.gvSKsukien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvSKsukien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSKsukien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvSKsukien.ColumnHeadersHeight = 35;
            this.gvSKsukien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvSKsukien.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvSKsukien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.gvSKsukien.Location = new System.Drawing.Point(1, 56);
            this.gvSKsukien.Name = "gvSKsukien";
            this.gvSKsukien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvSKsukien.RowHeadersVisible = false;
            this.gvSKsukien.RowHeadersWidth = 51;
            this.gvSKsukien.RowTemplate.Height = 24;
            this.gvSKsukien.Size = new System.Drawing.Size(471, 423);
            this.gvSKsukien.TabIndex = 10;
            this.gvSKsukien.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.gvSKsukien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.gvSKsukien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gvSKsukien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gvSKsukien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gvSKsukien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gvSKsukien.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gvSKsukien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.gvSKsukien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.gvSKsukien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvSKsukien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvSKsukien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.gvSKsukien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gvSKsukien.ThemeStyle.HeaderStyle.Height = 35;
            this.gvSKsukien.ThemeStyle.ReadOnly = false;
            this.gvSKsukien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.gvSKsukien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvSKsukien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvSKsukien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gvSKsukien.ThemeStyle.RowsStyle.Height = 24;
            this.gvSKsukien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.gvSKsukien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gvSKsukien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSKsukien_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(671, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnSkSua
            // 
            this.btnSkSua.BorderColor = System.Drawing.Color.Red;
            this.btnSkSua.BorderRadius = 5;
            this.btnSkSua.BorderThickness = 2;
            this.btnSkSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSkSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSkSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSkSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSkSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.btnSkSua.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkSua.ForeColor = System.Drawing.Color.Black;
            this.btnSkSua.Image = global::DoAnCuoiKi_TraoDoiDo.Properties.Resources.icons8_edit_96;
            this.btnSkSua.Location = new System.Drawing.Point(694, 442);
            this.btnSkSua.Name = "btnSkSua";
            this.btnSkSua.Size = new System.Drawing.Size(98, 37);
            this.btnSkSua.TabIndex = 8;
            this.btnSkSua.Text = "Sửa";
            this.btnSkSua.Click += new System.EventHandler(this.btnSkSua_Click);
            // 
            // btnSkXoa
            // 
            this.btnSkXoa.BorderColor = System.Drawing.Color.Red;
            this.btnSkXoa.BorderRadius = 5;
            this.btnSkXoa.BorderThickness = 2;
            this.btnSkXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSkXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSkXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSkXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSkXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.btnSkXoa.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkXoa.ForeColor = System.Drawing.Color.Black;
            this.btnSkXoa.Image = global::DoAnCuoiKi_TraoDoiDo.Properties.Resources.icons8_delete_48;
            this.btnSkXoa.Location = new System.Drawing.Point(583, 442);
            this.btnSkXoa.Name = "btnSkXoa";
            this.btnSkXoa.Size = new System.Drawing.Size(98, 37);
            this.btnSkXoa.TabIndex = 7;
            this.btnSkXoa.Text = "Xóa";
            this.btnSkXoa.Click += new System.EventHandler(this.btnSkXoa_Click);
            // 
            // btnSkThem
            // 
            this.btnSkThem.BorderColor = System.Drawing.Color.Red;
            this.btnSkThem.BorderRadius = 5;
            this.btnSkThem.BorderThickness = 2;
            this.btnSkThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSkThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSkThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSkThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSkThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.btnSkThem.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkThem.ForeColor = System.Drawing.Color.Black;
            this.btnSkThem.Image = global::DoAnCuoiKi_TraoDoiDo.Properties.Resources.icons8_add_48;
            this.btnSkThem.Location = new System.Drawing.Point(479, 442);
            this.btnSkThem.Name = "btnSkThem";
            this.btnSkThem.Size = new System.Drawing.Size(98, 37);
            this.btnSkThem.TabIndex = 6;
            this.btnSkThem.Text = "Thêm ";
            this.btnSkThem.Click += new System.EventHandler(this.btnSkThem_Click);
            // 
            // FormSuKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(793, 503);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gvSKsukien);
            this.Controls.Add(this.btnSkSua);
            this.Controls.Add(this.btnSkXoa);
            this.Controls.Add(this.btnSkThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSuKien";
            this.Text = "Sự Kiện";
            this.Load += new System.EventHandler(this.FormSuKien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSKsukien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimeSKKetthuc;
        private System.Windows.Forms.DateTimePicker dateTimeSKbatdau;
        private System.Windows.Forms.TextBox txtSKGiamgia;
        private System.Windows.Forms.TextBox txtSKTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnSkThem;
        private Guna.UI2.WinForms.Guna2Button btnSkXoa;
        private Guna.UI2.WinForms.Guna2Button btnSkSua;
        private Guna.UI2.WinForms.Guna2DataGridView gvSKsukien;
        private PictureBox pictureBox1;
    }
}