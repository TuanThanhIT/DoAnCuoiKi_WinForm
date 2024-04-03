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
    public partial class FormDoEmBe : Form
    {
        XuLyHienThi xlht = new XuLyHienThi();
        public FormDoEmBe()
        {
            InitializeComponent();
        }
        string loaimathang = "Do em be";
        private void FormDoEmBe_Load(object sender, EventArgs e)
        {
            xlht.LoadDanhSach(loaimathang, flowLPDobaby);
        }
    }
}
