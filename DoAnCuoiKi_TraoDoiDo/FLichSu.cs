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
    public partial class FormLichSu : Form
    {
        FormDAO fd = new FormDAO(); 
        public FormLichSu()
        {
            InitializeComponent();
        }

        private void FormLichSu_Load(object sender, EventArgs e)
        {
            OpenChildForm(new FormLSMuaHang());
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelLichSu.Controls.Add(childForm);
            panelLichSu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnLSMuaHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormLSMuaHang());
        }

        private void btnLSBanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormLSBanHang());
        }
    }
}
