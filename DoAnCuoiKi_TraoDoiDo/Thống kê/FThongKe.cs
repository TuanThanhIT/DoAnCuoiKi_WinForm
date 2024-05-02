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
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
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

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            OpenChildForm(new FormTKMuaHang());
        }

        private void btnTKMuaHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTKMuaHang());
        }

        private void btnTKBanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTKBanHang());
        }

        private void btnTKTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTKTaiKhoan());
        }
    }
}
