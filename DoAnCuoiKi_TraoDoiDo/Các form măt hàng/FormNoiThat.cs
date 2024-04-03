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
    public partial class FormNoiThat : Form
    {
        XuLyHienThi xlht = new XuLyHienThi();
        public FormNoiThat()
        {
            InitializeComponent();
        }
        string loaimathang = "Do noi that";
        private void FormNoiThat_Load(object sender, EventArgs e)
        {
            xlht.LoadDanhSach(loaimathang, flowLPNoithat);
        }
    }
}
