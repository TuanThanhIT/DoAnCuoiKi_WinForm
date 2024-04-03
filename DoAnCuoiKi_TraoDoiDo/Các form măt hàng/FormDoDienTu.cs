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
    public partial class FormDoDienTu : Form
    {
        XuLyHienThi xlht = new XuLyHienThi();
        public FormDoDienTu()
        {
            InitializeComponent();
        }
        string loaimathang = "Do dien tu";
        private void FormDoDienTu_Load(object sender, EventArgs e)
        {
            xlht.LoadDanhSach(loaimathang, flowLPDodientu);
        }
    }
}
