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
        FormBUS fd = new FormBUS();

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormTKMuaHang(),panelThongKe);
        }

        private void btnTKMuaHang_Click(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormTKMuaHang(), panelThongKe);
        }

        private void btnTKBanHang_Click(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormTKBanHang(), panelThongKe);
        }

        private void btnTKTaiKhoan_Click(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormTKTaiKhoan(), panelThongKe);
        }
    }
}
