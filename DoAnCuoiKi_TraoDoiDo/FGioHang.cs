using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using DoAnCuoiKi_TraoDoiDo.BUS;

namespace DoAnCuoiKi_TraoDoiDo
{
    public partial class FormGioHang : Form
    {
        GioHangBUS ghs = new GioHangBUS();
        FormBUS fd = new FormBUS();
        public FormGioHang()
        {
            InitializeComponent();
        }


        private void FormGioHang_Load(object sender, EventArgs e)
        {
            ghs.LoadDanhSach(flowLPGioHang, txtTimKiemGH);
        }



        private void btnGHQuayLai_Click_1(object sender, EventArgs e)
        {
            if (DangKiDAO.Chuc_vu == "Quan tri vien")
            {
                fd.OpenChildForm(new FormMatHang(), FormTrangChu.panelTrangChu);
                FormTrangChu.lblChude.Text = "Mặt Hàng";
            }
            else
            {
                fd.OpenChildForm(new FormMatHang(), FormTrangChuThanhVien.panelTVTrangChu);
                FormTrangChuThanhVien.lblTVChude.Text = "Mặt Hàng";
            }
        }

        private void btnGioHangMua_Click_1(object sender, EventArgs e)
        {
            if (DangKiDAO.Chuc_vu == "Quan tri vien")
            {
                fd.OpenChildForm(new FormThanhToan(), FormTrangChu.panelTrangChu);
                FormTrangChu.lblChude.Text = "Thanh Toán";
            }
            else
            {
                fd.OpenChildForm(new FormThanhToan(), FormTrangChuThanhVien.panelTVTrangChu);
                FormTrangChuThanhVien.lblTVChude.Text = "Thanh Toán";
            }
        }

        private void txtTimKiemGH_TextChanged(object sender, EventArgs e)
        {
            FormGioHang_Load(sender, e);
        }
    }
}

