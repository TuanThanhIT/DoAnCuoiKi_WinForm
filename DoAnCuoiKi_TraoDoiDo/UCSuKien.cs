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
            lblSKTen.Text = sk.TenSuKien;
            lblSkGiamgia.Text = sk.GiamGia;
            lblSKBatDau.Text = sk.BatDau;
            lblSKKetthuc.Text = sk.KetThuc;
        }

        private void UCSuKien_Load(object sender, EventArgs e)
        { 

        }
    }
}
