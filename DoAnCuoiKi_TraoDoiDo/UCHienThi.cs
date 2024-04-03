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
            UCHTlblGia.Text = bando.Gia_Ban;
            string path = bando.Hinh_Anh_1;
            UCHTPictureBox.Image = Image.FromFile(path);
            UCCTlbMaSP.Text = bando.Ma_San_Pham;

        }

        private void UCHienThi_Load(object sender, EventArgs e)
        {

        }

        private void UCbtnChiTiet_Click(object sender, EventArgs e)
        {
            FormChiTiet f = new FormChiTiet(bando);
            f.Show();


        }

        private void UCHTlblTen_Click(object sender, EventArgs e)
        {

        }

        /* private void UCbtnChiTiet_Click(object sender, EventArgs e)
          {


          }*/
    }
}
