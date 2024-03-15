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
    public partial class FormTatCaMatHang : Form
    {
        public FormTatCaMatHang()
        {
            InitializeComponent();
        }

        private void btnChiTiet(object sender, EventArgs e)
        {
            FormChiTiet f = new FormChiTiet();
            f.Show();
        }
        private void ucHienThi1_Load(object sender, EventArgs e)
        {
            ucHienThi1.UCbtnChiTiet.Click += btnChiTiet;
        }
    }
}
