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
    public partial class UCVoucher : UserControl
    {
        public UCVoucher()
        {
            InitializeComponent();
        }
        public UCVoucher(BanDo bd)
        {
            InitializeComponent();
            UCVClblTen.Text = bd.Ten_Mat_Hang;
            UCVClblGiamgia.Text = bd.Giam_Gia;
            UCVClblMa.Text = bd.Ma_San_Pham;
            UCVClblMaVou.Text = bd.Ma_Voucher;
            UCVClblSoluong.Text = bd.So_Luong_Voucher;
        }

        private void UCVoucher_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

