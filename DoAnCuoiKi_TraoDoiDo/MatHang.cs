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
        private void btnMhTatca_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormTatCaMatHang());  
        }

        private void btnMhDienthoai_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormDienThoai());
        }

        private void btnMhNoithat_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormNoiThat());
        }

        private void btnMhThoitrang_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormThoiTrang());
        }

        private void btnMhDodientu_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormDoDienTu());
        }

        private void btnMhDogiadung_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDoGiaDung());
        }

        private void btnMhSach_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormSach());
        }

        private void btnMhGiay_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormGiay());
        }

        private void btnMhThietbiIT_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormThietBiIT());
        }

        private void btnMhXeco_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormXeCo());
        }

        private void btnMhDoembe_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormDoEmBe());
        }

        private void btnMhKhac_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormKhac());
        }
    }
}
