using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnCuoiKi_TraoDoiDo.DTO;



namespace DoAnCuoiKi_TraoDoiDo
{
    public partial class UCHienThi : UserControl
    {
        BanDo bando;
        FormDAO fd = new FormDAO();
        public UCHienThi()
        {
            InitializeComponent();
        }


        public UCHienThi(BanDo bando)
        {
            InitializeComponent();
            this.bando = bando;

            UCHTlblTen.Text = bando.Tên_mặt_hàng;
            UCHTlblGiaban.Text = bando.Giá_bán;
            string path = bando.Hình_ảnh_1;
            UCHTpicImage.Image = Image.FromFile(path);
            UCHTlblGiagoc.Text = bando.Giá_gốc;
            UCHTlblNgay.Text = bando.Ngày_đăng_bán;
        }

        private void UCHienThi_Load(object sender, EventArgs e)
        {
            UCHTlblGiagoc.Font = new Font(UCHTlblGiagoc.Font, FontStyle.Strikeout);
        }



        private void UCHTbtnChitiet_Click(object sender, EventArgs e)
        {
            if (DangKiDAO.Chuc_vu == "Quan tri vien")
            {
                fd.OpenChildForm(new FormChiTiet(bando), ref FormDAO.activeForm, FormTrangChu.panelTrangChu);
                FormTrangChu.lblChude.Text = "Chi Tiết Sản Phẩm";
            }
            else
            {
                fd.OpenChildForm(new FormChiTiet(bando), ref FormDAO.activeForm, FormTrangChuThanhVien.panelTVTrangChu);
                FormTrangChuThanhVien.lblTVChude.Text = "Chi Tiết sản phẩm";
            }
        }
    }
}
