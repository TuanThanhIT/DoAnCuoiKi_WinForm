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
    public partial class FormTKMuaHang : Form
    {
        MuaHangBUS mhb = new MuaHangBUS();
        FormBUS fd = new FormBUS();
        public FormTKMuaHang()
        {
            InitializeComponent();
        }

        private void FormTatCaMuaHang_Load(object sender, EventArgs e)
        {
            DataTable a = mhb.TKMuaHang();
            gvAllMuaHang.DataSource = a;
        }

        private void btnAllMuaHangReport_Click(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormRTKMuaHang(), FormTrangChu.panelTrangChu);
            FormTrangChu.lblChude.Text = "Thống kê mua hàng";
        }
    }
}
