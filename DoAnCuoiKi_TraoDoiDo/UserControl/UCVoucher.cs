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
            UCVClblTen.Text = bd.Tên_mặt_hàng;
            UCVClblGiamgia.Text = bd.Giảm_giá;
            UCVClblMa.Text = bd.Mã_sản_phẩm;
            UCVClblMaVou.Text = bd.Mã_Voucher;
            UCVClblSoluong.Text = bd.Số_lượng_Voucher;
        }

        private void UCVoucher_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

