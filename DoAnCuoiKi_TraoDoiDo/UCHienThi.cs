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
    public partial class UCHienThi : UserControl
    {
        BanDo bando;
        public UCHienThi()
        {
            InitializeComponent();
        }


        public UCHienThi(BanDo bando)
        {
            InitializeComponent();
            this.bando = bando;

            UCHTlblTen.Text = bando.Ten_Mat_Hang;
            UCHTlblGiaban.Text = bando.Gia_Ban;
            string path = bando.Hinh_Anh_1;
            UCHTpicImage.Image = Image.FromFile(path);
            UCHTlblGiagoc.Text = bando.Gia_Goc;
            UCHTlblNgay.Text = bando.Ngay_Dang_Ban;
        }

        private void UCHienThi_Load(object sender, EventArgs e)
        {
            UCHTlblGiagoc.Font = new Font(UCHTlblGiagoc.Font, FontStyle.Strikeout);
        }

        

        private void UCHTbtnChitiet_Click(object sender, EventArgs e)
        {
            FormDao fd = new FormDao();
            fd.OpenChildForm(new FormChiTiet(bando), ref FormDao.activeForm, FormTrangChu.panelTrangChu);
            FormTrangChu.lblChude.Text = "Chi tiết sản phẩm";
        }
    }
}
