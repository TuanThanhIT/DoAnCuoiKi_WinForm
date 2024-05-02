using DoAnCuoiKi_TraoDoiDo.BUS;
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
    public partial class FormTKTaiKhoan : Form
    {
        DangKiBUS dkb = new DangKiBUS();
        FormDAO fd = new FormDAO();
        public FormTKTaiKhoan()
        {
            InitializeComponent();
        }

        private void FormTKTaiKhoan_Load(object sender, EventArgs e)
        {
            DataTable dt = dkb.DSTaiKhoan();
            gvAllTaiKhoan.DataSource = dt;  
        }

        private void btnAllTaiKhoan_Click(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormRTKTaiKhoan(), ref FormDAO.activeForm, FormTrangChu.panelTrangChu);
            FormTrangChu.lblChude.Text = "Thống kê tài khoản";
        }
    }
}
