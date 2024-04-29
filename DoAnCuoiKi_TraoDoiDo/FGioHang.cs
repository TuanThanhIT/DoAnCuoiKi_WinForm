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
        FormDAO fd = new FormDAO();
        public FormGioHang()
        {
            InitializeComponent();
        }


        private void FormGioHang_Load(object sender, EventArgs e)
        {
            ghs.LoadDanhSach(flowLPGioHang);
        }



        private void btnGHQuayLai_Click_1(object sender, EventArgs e)
        {
            if (DangKiDAO.Chuc_vu == "Quan tri vien")
            {
                fd.OpenChildForm(new FormMatHang(), ref FormDAO.activeForm, FormTrangChu.panelTrangChu);
                FormTrangChu.lblChude.Text = "Mặt Hàng";
            }
            else
            {
                fd.OpenChildForm(new FormMatHang(), ref FormDAO.activeForm, FormTrangChuThanhVien.panelTVTrangChu);
                FormTrangChuThanhVien.lblTVChude.Text = "Mặt Hàng";
            }
        }

        private void btnGioHangMua_Click_1(object sender, EventArgs e)
        {
            if (DangKiDAO.Chuc_vu == "Quan tri vien")
            {
                fd.OpenChildForm(new FormThanhToan(), ref FormDAO.activeForm, FormTrangChu.panelTrangChu);
                FormTrangChu.lblChude.Text = "Thanh Toán";
            }
            else
            {
                fd.OpenChildForm(new FormThanhToan(), ref FormDAO.activeForm, FormTrangChuThanhVien.panelTVTrangChu);
                FormTrangChuThanhVien.lblTVChude.Text = "Thanh Toán";
            }
        }
    }
}

