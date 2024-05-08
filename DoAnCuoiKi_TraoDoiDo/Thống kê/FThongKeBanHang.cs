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
    public partial class FormTKBanHang : Form
    {
        BanDoBUS bdb = new BanDoBUS();
        FormBUS fd = new FormBUS();
        public FormTKBanHang()
        {
            InitializeComponent();
        }

        private void FormTatCaBanHang_Load(object sender, EventArgs e)
        {
            DataTable a = bdb.LoadTKBanDo();
            gvAllBanHang.DataSource = a;
        }

        private void btnAllBanHang_Click(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormRTKBanHang(), FormTrangChu.panelTrangChu);
            FormTrangChu.lblChude.Text = "Thống kê bán hàng";
        }
    }
}
