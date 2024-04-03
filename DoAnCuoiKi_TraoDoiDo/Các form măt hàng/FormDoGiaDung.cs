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
    public partial class FormDoGiaDung : Form
    {
        XuLyHienThi xlht = new XuLyHienThi();
        public FormDoGiaDung()
        {
            InitializeComponent();
        }
        string loaimathang = "Do gia dung";
        private void FormDoGiaDung_Load(object sender, EventArgs e)
        {
            xlht.LoadDanhSach(loaimathang, flowLPDogiadung);
        }
    }
}
