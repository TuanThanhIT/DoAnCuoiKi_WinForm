using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi_TraoDoiDo
{
    public partial class FormLsBanHang : Form
    {
        private Label label1;
        private Button btnMuaLsBH;
        private Button btnThoatLsBH;
        private Button btnXuatReportLsBH;
        private Button btnXoaLsBH;
        private DataGridView dgvLSBanHang;

        public FormLsBanHang()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLSBanHang = new System.Windows.Forms.DataGridView();
            this.btnXoaLsBH = new System.Windows.Forms.Button();
            this.btnXuatReportLsBH = new System.Windows.Forms.Button();
            this.btnThoatLsBH = new System.Windows.Forms.Button();
            this.btnMuaLsBH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSBanHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lịch Sử Bán Hàng: ";
            // 
            // dgvLSBanHang
            // 
            this.dgvLSBanHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvLSBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLSBanHang.Location = new System.Drawing.Point(5, 48);
            this.dgvLSBanHang.Name = "dgvLSBanHang";
            this.dgvLSBanHang.RowHeadersWidth = 51;
            this.dgvLSBanHang.RowTemplate.Height = 24;
            this.dgvLSBanHang.Size = new System.Drawing.Size(807, 416);
            this.dgvLSBanHang.TabIndex = 1;
            // 
            // btnXoaLsBH
            // 
            this.btnXoaLsBH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnXoaLsBH.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLsBH.ForeColor = System.Drawing.Color.Black;
            this.btnXoaLsBH.Image = global::DoAnCuoiKi_TraoDoiDo.Properties.Resources.xoa3;
            this.btnXoaLsBH.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaLsBH.Location = new System.Drawing.Point(564, 470);
            this.btnXoaLsBH.Name = "btnXoaLsBH";
            this.btnXoaLsBH.Size = new System.Drawing.Size(121, 36);
            this.btnXoaLsBH.TabIndex = 5;
            this.btnXoaLsBH.Text = "Xóa Lịch Sử";
            this.btnXoaLsBH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaLsBH.UseVisualStyleBackColor = false;
            // 
            // btnXuatReportLsBH
            // 
            this.btnXuatReportLsBH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnXuatReportLsBH.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatReportLsBH.Image = global::DoAnCuoiKi_TraoDoiDo.Properties.Resources.Report3;
            this.btnXuatReportLsBH.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuatReportLsBH.Location = new System.Drawing.Point(437, 470);
            this.btnXuatReportLsBH.Name = "btnXuatReportLsBH";
            this.btnXuatReportLsBH.Size = new System.Drawing.Size(121, 36);
            this.btnXuatReportLsBH.TabIndex = 4;
            this.btnXuatReportLsBH.Text = "Xuất Báo Cáo";
            this.btnXuatReportLsBH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatReportLsBH.UseVisualStyleBackColor = false;
            // 
            // btnThoatLsBH
            // 
            this.btnThoatLsBH.BackColor = System.Drawing.Color.White;
            this.btnThoatLsBH.Image = global::DoAnCuoiKi_TraoDoiDo.Properties.Resources.quaylai2;
            this.btnThoatLsBH.Location = new System.Drawing.Point(762, 2);
            this.btnThoatLsBH.Name = "btnThoatLsBH";
            this.btnThoatLsBH.Size = new System.Drawing.Size(50, 44);
            this.btnThoatLsBH.TabIndex = 3;
            this.btnThoatLsBH.UseVisualStyleBackColor = false;
            this.btnThoatLsBH.Click += new System.EventHandler(this.btnThoatLsBH_Click);
            // 
            // btnMuaLsBH
            // 
            this.btnMuaLsBH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnMuaLsBH.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuaLsBH.Image = global::DoAnCuoiKi_TraoDoiDo.Properties.Resources.history2;
            this.btnMuaLsBH.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMuaLsBH.Location = new System.Drawing.Point(691, 470);
            this.btnMuaLsBH.Name = "btnMuaLsBH";
            this.btnMuaLsBH.Size = new System.Drawing.Size(121, 36);
            this.btnMuaLsBH.TabIndex = 2;
            this.btnMuaLsBH.Text = "Lịch Sử Mua Hàng";
            this.btnMuaLsBH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMuaLsBH.UseVisualStyleBackColor = false;
            this.btnMuaLsBH.Click += new System.EventHandler(this.btnMuaLsBH_Click);
            // 
            // FormLsBanHang
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(820, 510);
            this.Controls.Add(this.btnXoaLsBH);
            this.Controls.Add(this.btnXuatReportLsBH);
            this.Controls.Add(this.btnThoatLsBH);
            this.Controls.Add(this.btnMuaLsBH);
            this.Controls.Add(this.dgvLSBanHang);
            this.Controls.Add(this.label1);
            this.Name = "FormLsBanHang";
            this.Text = "Lịch Sử Bán Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSBanHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        FormTrangChu mainForm;
        private void btnThoatLsBH_Click(object sender, EventArgs e)
        {
            mainForm = this.ParentForm as FormTrangChu;
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                OpenChildForm(new FormMain());
                mainForm.lblChude.Text = "Trang Chủ";
                
            }
        }

        public void OpenChildForm(Form childForm)
        {
            mainForm = this.ParentForm as FormTrangChu;
            if (mainForm != null)
            {
                childForm.Dock = DockStyle.Fill;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                mainForm.panelTrangChu.Controls.Clear();
                mainForm.panelTrangChu.Controls.Add(childForm);
                childForm.Show();
            }
        }
        private void btnMuaLsBH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormLSMuaHang());
        }

       
    }
}
