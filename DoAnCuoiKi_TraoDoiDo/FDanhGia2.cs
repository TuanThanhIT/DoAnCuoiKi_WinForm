using DoAnCuoiKi_TraoDoiDo.BUS;
using DoAnCuoiKi_TraoDoiDo.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace DoAnCuoiKi_TraoDoiDo
{
    public partial class FormDanhGia : Form
    {
        DanhGiaBUS dgb = new DanhGiaBUS();
        string imagePath;
        FormBUS fd = new FormBUS();
        public FormDanhGia()
        {
            InitializeComponent();

        }
        public FormDanhGia(BanDo bd)
        {
            InitializeComponent();
            txtDGTenNguoiDung.Text = DangKiDAO.Ten_nguoi_dung;
            txtDGID.Text = DangKiDAO.ID;
            lblDanhGiaTen.Text = bd.Tên_mặt_hàng;
            lblDGMaSP.Text = bd.Mã_sản_phẩm;
            imagePath = bd.Hình_ảnh_1;
            picDGImage.Image = Image.FromFile(imagePath);
        }

        private void FormDanhGia2_Load(object sender, EventArgs e)
        {
            txtDGDanhGia.Focus();
        }

        private void btnDGDanglen_Click(object sender, EventArgs e)
        {
            DanhGia dg = new DanhGia(DangKiDAO.ID, DangKiDAO.Ten_nguoi_dung, lblDanhGiaTen.Text, lblDGMaSP.Text, imagePath, txtDGDanhGia.Text, DGRateStar.Value.ToString());
            if(dgb.ThemDanhGia(dg))
            {
                MessageBox.Show("Cảm ơn bạn đã đánh giá sản phẩm");
            }
            else
            {
                MessageBox.Show("Đánh giá thất bại");
            }
        }

        private void btnDGThoat_Click(object sender, EventArgs e)
        {
            if (DangKiDAO.Chuc_vu == "Quan tri vien")
            {
                fd.OpenChildForm(new FormMatHang(), FormTrangChu.panelTrangChu);
                FormTrangChu.lblChude.Text = "Mặt Hàng";
                this.Hide();
            }
            else
            {
                fd.OpenChildForm(new FormMatHang(), FormTrangChuThanhVien.panelTVTrangChu);
                FormTrangChuThanhVien.lblTVChude.Text = "Mặt Hàng";
                this.Hide();
            }
        }
    }
}
