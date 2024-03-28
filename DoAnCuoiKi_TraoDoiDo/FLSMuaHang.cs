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
    public partial class FormLSMuaHang : Form
    {
        public FormLSMuaHang()
        {
            InitializeComponent();
        }
        FormTrangChu mainForm;
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
        private void btnBanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormLsBanHang());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            mainForm = this.ParentForm as FormTrangChu;
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát","Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                OpenChildForm(new FormMain());
                mainForm.lblChude.Text = "Trang Chủ";
            }
        }

        
    }
}
