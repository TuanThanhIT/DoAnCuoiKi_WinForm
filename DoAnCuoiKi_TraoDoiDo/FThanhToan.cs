using DoAnCuoiKi_TraoDoiDo.BUS;
using DoAnCuoiKi_TraoDoiDo.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi_TraoDoiDo
{
    public partial class FormThanhToan : Form
    {
        ThanhToanBUS ttb = new ThanhToanBUS();
        FormDAO fd = new FormDAO();
        MuaHangBUS mhb = new MuaHangBUS();
        public FormThanhToan()
        {
            InitializeComponent();
            lblThanhToanTen.Text = DangKiDAO.Ho_ten;
            lblThanhtoanDiachi.Text = DangKiDAO.Dia_chi;
            lblThanhtoanSdt.Text = DangKiDAO.So_dt;
        }



        private void FormThanhToan_Load(object sender, EventArgs e)
        {
            ttb.LoadDS(flowLPThanhToan);
            ttb.HienThiSuKien(dateTimeThanhToanNgay, lblTtGgSukien);
        }

    


        private void lblThanhToanOut_Click_1(object sender, EventArgs e)
        {
            ttb.XoaThanhToan();
            if (DangKiDAO.Chuc_vu == "Quan tri vien")
            {
                fd.OpenChildForm(new FormGioHang(), ref FormDAO.activeForm, FormTrangChu.panelTrangChu);
                FormTrangChu.lblChude.Text = "Giỏ Hàng";
            }
            else
            {
                fd.OpenChildForm(new FormGioHang(), ref FormDAO.activeForm, FormTrangChuThanhVien.panelTVTrangChu);
                FormTrangChuThanhVien.lblTVChude.Text = "Giỏ Hàng";
            }
        }

        private void txtTTThanhToan_Click_1(object sender, EventArgs e)
        {
            lblTtTongtienhang.Text = ttb.TinhTienHang();
            if(lblTtGgSukien.Text == "Không có")
            {
                lblThanhtoanTongThanhToan.Text = lblTtTongtienhang.Text;
            }
            else
            {
                lblThanhtoanTongThanhToan.Text = (Convert.ToDouble(lblTtTongtienhang.Text) - (Convert.ToDouble(lblTtTongtienhang.Text) * (Convert.ToDouble(lblTtGgSukien.Text) * 0.01))).ToString();
            }
            
        }

        private void btnThanhtoanDatHang_Click_1(object sender, EventArgs e)
        {
            MuaHang tt = new MuaHang(lblThanhToanTen.Text, lblThanhtoanSdt.Text, lblThanhtoanDiachi.Text, dateTimeThanhToanNgay.Value.ToShortDateString(), DangKiDAO.ID, lblThanhtoanTongThanhToan.Text, mhb.RanDomMaGiaoDich());
            if (mhb.ThemMuaHang(tt))
            {
                DialogResult result = MessageBox.Show("Chúc mừng bạn đã đặt hàng thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    ttb.XoaThanhToan();
                    if (DangKiDAO.Chuc_vu == "Quan tri vien")
                    {
                        fd.OpenChildForm(new FormMain(), ref FormDAO.activeForm, FormTrangChu.panelTrangChu);
                        FormTrangChu.lblChude.Text = "Trang Chủ";
                    }
                    else
                    {
                        fd.OpenChildForm(new FormMatHang(), ref FormDAO.activeForm, FormTrangChuThanhVien.panelTVTrangChu);
                        FormTrangChuThanhVien.lblTVChude.Text = "Trang Chủ";
                    }
                }
            }
            else
            {
                MessageBox.Show("Đặt hàng thất bại. Vui lòng thử lại sau");
            }
        }
    }
}

