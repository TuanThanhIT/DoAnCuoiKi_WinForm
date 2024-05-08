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
        FormBUS fd = new FormBUS();


        private void FormMatHang_Load(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormTatCaMatHang(), panelMatHang);
        }


        private void btnTatCa_Click(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormTatCaMatHang(), panelMatHang);
        }

        private void btnDienThoai_Click(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormDienThoai(), panelMatHang);
        }

        private void btnNoiThat_Click(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormNoiThat(), panelMatHang);
        }

        private void btnThoiTrang_Click(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormThoiTrang(), panelMatHang);
        }

        private void btnDoDienTu_Click(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormDoDienTu(), panelMatHang);
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormSach(), panelMatHang);
        }

        private void btnDogiadung_Click(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormDoGiaDung(), panelMatHang);
        }

        private void btnGiay_Click(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormGiay(), panelMatHang);
        }

        private void btnIT_Click(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormThietBiIT(), panelMatHang);
        }

        private void btnXeco_Click(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormXeCo(), panelMatHang);
        }

        private void btnDoembe_Click(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormDoEmBe(), panelMatHang);
        }

        private void btnKhac_Click(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormKhac(), panelMatHang);
        }

        
    }
}
