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
    public partial class FormLSBanHang : Form
    {
        FormBUS fd = new FormBUS();
        BanDoBUS bdb = new BanDoBUS();
        public FormLSBanHang()
        {
            InitializeComponent();
        }


       

        private void FormLSBanHang_Load_1(object sender, EventArgs e)
        {
            DataTable a = bdb.LoadLSBanDo();
            gvLSBanHang.DataSource = a; 

        }

        private void btnXoaLSBanHang_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa hết toàn bộ lịch sử bán hàng của bạn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                if (bdb.XoaLSBanHang())
                {
                    MessageBox.Show("Toàn bộ lịch sử bán hàng của bạn đã được xóa");
                    FormLSBanHang_Load_1(sender, e);
                }
                else
                {
                    MessageBox.Show("Không thể xóa vui lòng thử lại");
                }
            }
        }

        private void btnLSXuatBaocao_Click(object sender, EventArgs e)
        {
            if (DangKiDAO.Chuc_vu == "Quan tri vien")
            {
                fd.OpenChildForm(new FormRLSBanHang(), FormTrangChu.panelTrangChu);
                FormTrangChu.lblChude.Text = "Báo Cáo";
            }
            else
            {
                fd.OpenChildForm(new FormRLSBanHang(), FormTrangChuThanhVien.panelTVTrangChu);
                FormTrangChuThanhVien.lblTVChude.Text = "Báo Cáo";
            }
        }
    }
}
