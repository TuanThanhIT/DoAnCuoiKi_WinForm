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
    public partial class FormMatHang : Form
    {
        public FormMatHang()
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
            panelMatHang.Controls.Add(childForm);
            panelMatHang.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void FormMatHang_Load(object sender, EventArgs e)
        {
            OpenChildForm(new FormTatCaMatHang());
        }


        private void btnTatCa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTatCaMatHang());
        }

        private void btnDienThoai_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDienThoai());
        }

        private void btnNoiThat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNoiThat());
        }

        private void btnThoiTrang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThoiTrang());
        }

        private void btnDoDienTu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDoDienTu());
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSach());
        }

        private void btnDogiadung_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDoGiaDung());
        }

        private void btnGiay_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormGiay());
        }

        private void btnIT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThietBiIT());
        }

        private void btnXeco_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormXeCo());
        }

        private void btnDoembe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDoEmBe());
        }

        private void btnKhac_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormKhac());
        }
    }
}
