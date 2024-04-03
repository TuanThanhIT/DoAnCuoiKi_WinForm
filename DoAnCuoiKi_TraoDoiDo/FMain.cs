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
    public partial class FormMain : Form
    {
        XuLyHienThi xlht =new XuLyHienThi();
        public FormMain()
        {
            InitializeComponent();
        }
        string htVoucher = "MaVoucher";
        private void FormMain_Load(object sender, EventArgs e)
        {
            xlht.LoadDanhSach(htVoucher, flowLPMainVoucher);
        }
    }
}
