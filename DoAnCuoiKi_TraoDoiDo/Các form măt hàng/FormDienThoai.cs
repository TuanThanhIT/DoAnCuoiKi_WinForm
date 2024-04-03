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
    public partial class FormDienThoai : Form
    {
        XuLyHienThi xlht = new XuLyHienThi();
        public FormDienThoai()
        {
            InitializeComponent();
        }
        string loaimathang = "Dien thoai";
        private void FormDienThoai_Load(object sender, EventArgs e)
        {
            xlht.LoadDanhSach(loaimathang, flowLPDienthoai);
        }
    }
}
