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
    public partial class FormDangBan : Form
    {
        public FormDangBan()
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

        private void btnDangbanThem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBanDo());
        }

        private void btnDbQuaylai_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBanDo());
        }

        private void btnDbChinhsua_Click(object sender, EventArgs e)
        {

        }
    }
}
