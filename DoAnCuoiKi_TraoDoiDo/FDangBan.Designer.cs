using System.Drawing;
using System.Windows.Forms;

namespace DoAnCuoiKi_TraoDoiDo
{
    partial class FormDangBan
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAnh3 = new System.Windows.Forms.Label();
            this.lblMaVoucher = new System.Windows.Forms.Label();
            this.lblAnh4 = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblSoluong = new System.Windows.Forms.Label();
            this.lblSlVou = new System.Windows.Forms.Label();
            this.lblGiamgia = new System.Windows.Forms.Label();
            this.lblAnh1 = new System.Windows.Forms.Label();
            this.lblMota = new System.Windows.Forms.Label();
            this.lblGiaban = new System.Windows.Forms.Label();
            this.lblLoai = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblTinhtrang = new System.Windows.Forms.Label();
            this.lblPtGiaohang = new System.Windows.Forms.Label();
            this.lblDiadiem = new System.Windows.Forms.Label();
            this.lblAnh2 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.lblGiagoc = new System.Windows.Forms.Label();
            this.gvDangban = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnDbChinhsua = new Guna.UI2.WinForms.Guna2Button();
            this.btnDangbanThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnDbXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnDbQuaylai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvDangban)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Đang bán";
            // 
            // lblAnh3
            // 
            this.lblAnh3.AutoSize = true;
            this.lblAnh3.ForeColor = System.Drawing.Color.White;
            this.lblAnh3.Location = new System.Drawing.Point(179, 22);
            this.lblAnh3.Name = "lblAnh3";
            this.lblAnh3.Size = new System.Drawing.Size(44, 16);
            this.lblAnh3.TabIndex = 10;
            this.lblAnh3.Text = "label2";
            // 
            // lblMaVoucher
            // 
            this.lblMaVoucher.AutoSize = true;
            this.lblMaVoucher.ForeColor = System.Drawing.Color.White;
            this.lblMaVoucher.Location = new System.Drawing.Point(174, 595);
            this.lblMaVoucher.Name = "lblMaVoucher";
            this.lblMaVoucher.Size = new System.Drawing.Size(44, 16);
            this.lblMaVoucher.TabIndex = 11;
            this.lblMaVoucher.Text = "label3";
            // 
            // lblAnh4
            // 
            this.lblAnh4.AutoSize = true;
            this.lblAnh4.ForeColor = System.Drawing.Color.White;
            this.lblAnh4.Location = new System.Drawing.Point(339, 29);
            this.lblAnh4.Name = "lblAnh4";
            this.lblAnh4.Size = new System.Drawing.Size(44, 16);
            this.lblAnh4.TabIndex = 12;
            this.lblAnh4.Text = "label4";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.ForeColor = System.Drawing.Color.White;
            this.lblTen.Location = new System.Drawing.Point(12, 611);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(44, 16);
            this.lblTen.TabIndex = 13;
            this.lblTen.Text = "label5";
            // 
            // lblSoluong
            // 
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.ForeColor = System.Drawing.Color.White;
            this.lblSoluong.Location = new System.Drawing.Point(459, 595);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(44, 16);
            this.lblSoluong.TabIndex = 14;
            this.lblSoluong.Text = "label6";
            // 
            // lblSlVou
            // 
            this.lblSlVou.AutoSize = true;
            this.lblSlVou.ForeColor = System.Drawing.Color.White;
            this.lblSlVou.Location = new System.Drawing.Point(389, 595);
            this.lblSlVou.Name = "lblSlVou";
            this.lblSlVou.Size = new System.Drawing.Size(44, 16);
            this.lblSlVou.TabIndex = 15;
            this.lblSlVou.Text = "label7";
            // 
            // lblGiamgia
            // 
            this.lblGiamgia.AutoSize = true;
            this.lblGiamgia.ForeColor = System.Drawing.Color.White;
            this.lblGiamgia.Location = new System.Drawing.Point(275, 595);
            this.lblGiamgia.Name = "lblGiamgia";
            this.lblGiamgia.Size = new System.Drawing.Size(44, 16);
            this.lblGiamgia.TabIndex = 16;
            this.lblGiamgia.Text = "label8";
            // 
            // lblAnh1
            // 
            this.lblAnh1.AutoSize = true;
            this.lblAnh1.ForeColor = System.Drawing.Color.White;
            this.lblAnh1.Location = new System.Drawing.Point(282, 10);
            this.lblAnh1.Name = "lblAnh1";
            this.lblAnh1.Size = new System.Drawing.Size(44, 16);
            this.lblAnh1.TabIndex = 17;
            this.lblAnh1.Text = "label9";
            // 
            // lblMota
            // 
            this.lblMota.AutoSize = true;
            this.lblMota.ForeColor = System.Drawing.Color.White;
            this.lblMota.Location = new System.Drawing.Point(275, 611);
            this.lblMota.Name = "lblMota";
            this.lblMota.Size = new System.Drawing.Size(51, 16);
            this.lblMota.TabIndex = 18;
            this.lblMota.Text = "label10";
            // 
            // lblGiaban
            // 
            this.lblGiaban.AutoSize = true;
            this.lblGiaban.ForeColor = System.Drawing.Color.White;
            this.lblGiaban.Location = new System.Drawing.Point(167, 611);
            this.lblGiaban.Name = "lblGiaban";
            this.lblGiaban.Size = new System.Drawing.Size(51, 16);
            this.lblGiaban.TabIndex = 19;
            this.lblGiaban.Text = "label11";
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.ForeColor = System.Drawing.Color.White;
            this.lblLoai.Location = new System.Drawing.Point(89, 611);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(51, 16);
            this.lblLoai.TabIndex = 20;
            this.lblLoai.Text = "label12";
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.ForeColor = System.Drawing.Color.White;
            this.lblMaSP.Location = new System.Drawing.Point(273, 579);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(51, 16);
            this.lblMaSP.TabIndex = 21;
            this.lblMaSP.Text = "label13";
            // 
            // lblTinhtrang
            // 
            this.lblTinhtrang.AutoSize = true;
            this.lblTinhtrang.ForeColor = System.Drawing.Color.White;
            this.lblTinhtrang.Location = new System.Drawing.Point(172, 579);
            this.lblTinhtrang.Name = "lblTinhtrang";
            this.lblTinhtrang.Size = new System.Drawing.Size(51, 16);
            this.lblTinhtrang.TabIndex = 22;
            this.lblTinhtrang.Text = "label14";
            // 
            // lblPtGiaohang
            // 
            this.lblPtGiaohang.AutoSize = true;
            this.lblPtGiaohang.ForeColor = System.Drawing.Color.White;
            this.lblPtGiaohang.Location = new System.Drawing.Point(87, 579);
            this.lblPtGiaohang.Name = "lblPtGiaohang";
            this.lblPtGiaohang.Size = new System.Drawing.Size(51, 16);
            this.lblPtGiaohang.TabIndex = 23;
            this.lblPtGiaohang.Text = "label15";
            // 
            // lblDiadiem
            // 
            this.lblDiadiem.AutoSize = true;
            this.lblDiadiem.ForeColor = System.Drawing.Color.White;
            this.lblDiadiem.Location = new System.Drawing.Point(12, 579);
            this.lblDiadiem.Name = "lblDiadiem";
            this.lblDiadiem.Size = new System.Drawing.Size(51, 16);
            this.lblDiadiem.TabIndex = 24;
            this.lblDiadiem.Text = "label16";
            // 
            // lblAnh2
            // 
            this.lblAnh2.AutoSize = true;
            this.lblAnh2.ForeColor = System.Drawing.Color.White;
            this.lblAnh2.Location = new System.Drawing.Point(282, 43);
            this.lblAnh2.Name = "lblAnh2";
            this.lblAnh2.Size = new System.Drawing.Size(51, 16);
            this.lblAnh2.TabIndex = 25;
            this.lblAnh2.Text = "label17";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(459, 579);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(51, 16);
            this.lblID.TabIndex = 27;
            this.lblID.Text = "label19";
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.ForeColor = System.Drawing.Color.White;
            this.lblNgay.Location = new System.Drawing.Point(380, 579);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(51, 16);
            this.lblNgay.TabIndex = 28;
            this.lblNgay.Text = "label20";
            // 
            // lblGiagoc
            // 
            this.lblGiagoc.AutoSize = true;
            this.lblGiagoc.ForeColor = System.Drawing.Color.White;
            this.lblGiagoc.Location = new System.Drawing.Point(389, 611);
            this.lblGiagoc.Name = "lblGiagoc";
            this.lblGiagoc.Size = new System.Drawing.Size(51, 16);
            this.lblGiagoc.TabIndex = 29;
            this.lblGiagoc.Text = "label19";
            // 
            // gvDangban
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.gvDangban.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvDangban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.gvDangban.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDangban.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvDangban.ColumnHeadersHeight = 35;
            this.gvDangban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvDangban.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvDangban.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.gvDangban.Location = new System.Drawing.Point(1, 65);
            this.gvDangban.Name = "gvDangban";
            this.gvDangban.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvDangban.RowHeadersVisible = false;
            this.gvDangban.RowHeadersWidth = 51;
            this.gvDangban.RowTemplate.Height = 24;
            this.gvDangban.Size = new System.Drawing.Size(1056, 508);
            this.gvDangban.TabIndex = 10;
            this.gvDangban.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.gvDangban.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.gvDangban.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gvDangban.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gvDangban.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gvDangban.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gvDangban.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gvDangban.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.gvDangban.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.gvDangban.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvDangban.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDangban.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.gvDangban.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gvDangban.ThemeStyle.HeaderStyle.Height = 35;
            this.gvDangban.ThemeStyle.ReadOnly = false;
            this.gvDangban.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.gvDangban.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvDangban.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDangban.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gvDangban.ThemeStyle.RowsStyle.Height = 24;
            this.gvDangban.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.gvDangban.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gvDangban.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDangban_CellClick_3);
            // 
            // btnDbChinhsua
            // 
            this.btnDbChinhsua.BorderColor = System.Drawing.Color.White;
            this.btnDbChinhsua.BorderRadius = 5;
            this.btnDbChinhsua.BorderThickness = 2;
            this.btnDbChinhsua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDbChinhsua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDbChinhsua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDbChinhsua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDbChinhsua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(235)))), ((int)(((byte)(222)))));
            this.btnDbChinhsua.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDbChinhsua.ForeColor = System.Drawing.Color.Black;
            this.btnDbChinhsua.Image = global::DoAnCuoiKi_TraoDoiDo.Properties.Resources.icons8_edit_961;
            this.btnDbChinhsua.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDbChinhsua.Location = new System.Drawing.Point(720, 579);
            this.btnDbChinhsua.Name = "btnDbChinhsua";
            this.btnDbChinhsua.Size = new System.Drawing.Size(158, 45);
            this.btnDbChinhsua.TabIndex = 9;
            this.btnDbChinhsua.Text = "Sửa mặt hàng";
            this.btnDbChinhsua.Click += new System.EventHandler(this.btnDbChinhsua_Click);
            // 
            // btnDangbanThem
            // 
            this.btnDangbanThem.BorderColor = System.Drawing.Color.White;
            this.btnDangbanThem.BorderRadius = 5;
            this.btnDangbanThem.BorderThickness = 2;
            this.btnDangbanThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangbanThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangbanThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangbanThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangbanThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(235)))), ((int)(((byte)(222)))));
            this.btnDangbanThem.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangbanThem.ForeColor = System.Drawing.Color.Black;
            this.btnDangbanThem.Image = global::DoAnCuoiKi_TraoDoiDo.Properties.Resources.icons8_add_482;
            this.btnDangbanThem.ImageSize = new System.Drawing.Size(35, 35);
            this.btnDangbanThem.Location = new System.Drawing.Point(556, 582);
            this.btnDangbanThem.Name = "btnDangbanThem";
            this.btnDangbanThem.Size = new System.Drawing.Size(158, 45);
            this.btnDangbanThem.TabIndex = 8;
            this.btnDangbanThem.Text = "Thêm mặt hàng";
            this.btnDangbanThem.Click += new System.EventHandler(this.btnDangbanThem_Click_1);
            // 
            // btnDbXoa
            // 
            this.btnDbXoa.BorderColor = System.Drawing.Color.White;
            this.btnDbXoa.BorderRadius = 5;
            this.btnDbXoa.BorderThickness = 2;
            this.btnDbXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDbXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDbXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDbXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDbXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(235)))), ((int)(((byte)(222)))));
            this.btnDbXoa.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDbXoa.ForeColor = System.Drawing.Color.Black;
            this.btnDbXoa.Image = global::DoAnCuoiKi_TraoDoiDo.Properties.Resources.icons8_delete_481;
            this.btnDbXoa.ImageSize = new System.Drawing.Size(40, 40);
            this.btnDbXoa.Location = new System.Drawing.Point(884, 579);
            this.btnDbXoa.Name = "btnDbXoa";
            this.btnDbXoa.Size = new System.Drawing.Size(158, 45);
            this.btnDbXoa.TabIndex = 7;
            this.btnDbXoa.Text = "Gỡ mặt hàng";
            this.btnDbXoa.Click += new System.EventHandler(this.btnDbXoa_Click);
            // 
            // btnDbQuaylai
            // 
            this.btnDbQuaylai.BackColor = System.Drawing.Color.White;
            this.btnDbQuaylai.Image = global::DoAnCuoiKi_TraoDoiDo.Properties.Resources.quaylai2;
            this.btnDbQuaylai.Location = new System.Drawing.Point(974, 10);
            this.btnDbQuaylai.Name = "btnDbQuaylai";
            this.btnDbQuaylai.Size = new System.Drawing.Size(83, 49);
            this.btnDbQuaylai.TabIndex = 4;
            this.btnDbQuaylai.UseVisualStyleBackColor = false;
            this.btnDbQuaylai.Click += new System.EventHandler(this.btnDbQuaylai_Click_1);
            // 
            // FormDangBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1059, 636);
            this.Controls.Add(this.gvDangban);
            this.Controls.Add(this.lblGiagoc);
            this.Controls.Add(this.lblNgay);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblAnh2);
            this.Controls.Add(this.lblDiadiem);
            this.Controls.Add(this.lblPtGiaohang);
            this.Controls.Add(this.lblTinhtrang);
            this.Controls.Add(this.lblMaSP);
            this.Controls.Add(this.lblLoai);
            this.Controls.Add(this.lblGiaban);
            this.Controls.Add(this.lblMota);
            this.Controls.Add(this.lblAnh1);
            this.Controls.Add(this.lblGiamgia);
            this.Controls.Add(this.lblSlVou);
            this.Controls.Add(this.lblSoluong);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblAnh4);
            this.Controls.Add(this.lblMaVoucher);
            this.Controls.Add(this.lblAnh3);
            this.Controls.Add(this.btnDbChinhsua);
            this.Controls.Add(this.btnDangbanThem);
            this.Controls.Add(this.btnDbXoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDbQuaylai);
            this.Name = "FormDangBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đang bán";
            this.Load += new System.EventHandler(this.FormDangBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDangban)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnDbQuaylai;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnDbXoa;
        private Guna.UI2.WinForms.Guna2Button btnDangbanThem;
        private Guna.UI2.WinForms.Guna2Button btnDbChinhsua;
        public System.Windows.Forms.Label lblTen;
        public System.Windows.Forms.Label lblLoai;
        public System.Windows.Forms.Label lblMota;
        public System.Windows.Forms.Label lblGiaban;
        public System.Windows.Forms.Label lblAnh1;
        public System.Windows.Forms.Label lblAnh2;
        public System.Windows.Forms.Label lblAnh3;
        public System.Windows.Forms.Label lblAnh4;
        public System.Windows.Forms.Label lblMaVoucher;
        public System.Windows.Forms.Label lblGiamgia;
        public System.Windows.Forms.Label lblSlVou;
        public System.Windows.Forms.Label lblSoluong;
        public System.Windows.Forms.Label lblDiadiem;
        public System.Windows.Forms.Label lblTinhtrang;
        public System.Windows.Forms.Label lblPtGiaohang;
        public System.Windows.Forms.Label lblMaSP;
        public System.Windows.Forms.Label lblNgay;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.Label lblGiagoc;
        private Guna.UI2.WinForms.Guna2DataGridView gvDangban;
    }
}