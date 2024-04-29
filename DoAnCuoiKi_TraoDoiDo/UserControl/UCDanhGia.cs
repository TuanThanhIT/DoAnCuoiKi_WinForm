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

namespace DoAnCuoiKi_TraoDoiDo
{
    public partial class UCDanhGia : UserControl
    {
        public UCDanhGia()
        {
            InitializeComponent();

        }
        public UCDanhGia(DanhGia dg)
        {
            float saoDanhGia;
            InitializeComponent();
            UCDGlblTen.Text = dg.Tendangnhap;
            if (float.TryParse(dg.SaoDanhGia, out saoDanhGia))
            {
                UCDGRateStar.Value = saoDanhGia;
            }
            UCDGlblDanhgia.Text = dg.VietDanhGia;
        }
        private void UCDanhGia_Load(object sender, EventArgs e)
        {

        }
    }
}
