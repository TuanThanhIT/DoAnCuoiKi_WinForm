using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi_TraoDoiDo
{
    public partial class UCSuKien : UserControl
    {
        public UCSuKien()
        {
            InitializeComponent();
        }
        public UCSuKien(SuKien sk)
        {
            InitializeComponent();
            UCSKtxtSkTen.Text = sk.TenSuKien;
            UCSKtxtGiamgia.Text = sk.GiamGia;
            UCSKlblBegin.Text = sk.BatDau;
            UCSKlblEnd.Text = sk.KetThuc;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UCSKtxtGiamgia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
