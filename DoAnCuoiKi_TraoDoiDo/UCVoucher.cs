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
    public partial class UCVoucher : UserControl
    {
        public UCVoucher()
        {
            InitializeComponent();
        }
        public UCVoucher(BanDo bd)
        {
            InitializeComponent();
            UCVoucherMaMH.Text = bd.Ma_San_Pham;
            UCVucherTen.Text = bd.Ten_Mat_Hang;
            UCVoucherMaVou.Text = bd.Ma_Voucher;
            UCVoucherGiamgia.Text = bd.Giam_Gia;
            UCVoucherSl.Text = bd.So_Luong_Voucher;
        }

        private void UCVoucher_Load(object sender, EventArgs e)
        {

        }
    }
}
