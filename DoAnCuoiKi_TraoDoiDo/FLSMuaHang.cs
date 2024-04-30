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
    public partial class FormLSMuaHang : Form
    {
        MuaHangBUS mhb = new MuaHangBUS(); 
        FormDAO fd = new FormDAO();
        public FormLSMuaHang()
        {
            InitializeComponent();
        }

        private void FormLSMuaHang_Load(object sender, EventArgs e)
        {
            DataTable a = mhb.DSMuaHang();
            gvLSMuaHang.DataSource = a; 
        }

        

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            if (DangKiDAO.Chuc_vu == "Quan tri vien")
            {
                fd.OpenChildForm(new FormMain(), ref FormDAO.activeForm, FormTrangChu.panelTrangChu);
                FormTrangChu.lblChude.Text = "Trang Chủ";
            }
            else
            {
                fd.OpenChildForm(new FormMain(), ref FormDAO.activeForm, FormTrangChuThanhVien.panelTVTrangChu);
                FormTrangChuThanhVien.lblTVChude.Text = "Trang Chủ";
            }
        }

        private void btnXoaLS_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa hết toàn bộ lịch sử mua hàng của bạn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK) {
                if(mhb.XoaLSMuaHang())
                {
                    MessageBox.Show("Toàn bộ lịch sử mua hàng của bạn đã được xóa");
                    FormLSMuaHang_Load(sender, e);
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
                fd.OpenChildForm(new FormReportMuaHang(), ref FormDAO.activeForm, FormTrangChu.panelTrangChu);
                FormTrangChu.lblChude.Text = "Báo Cáo";
            }
            else
            {
                fd.OpenChildForm(new FormReportMuaHang(), ref FormDAO.activeForm, FormTrangChuThanhVien.panelTVTrangChu);
                FormTrangChuThanhVien.lblTVChude.Text = "Báo Cáo";
            }
        }
    }
}
