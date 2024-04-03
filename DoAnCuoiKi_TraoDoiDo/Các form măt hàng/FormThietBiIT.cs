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
    public partial class FormThietBiIT : Form
    {
        XuLyHienThi xlht = new XuLyHienThi();
        public FormThietBiIT()
        {
            InitializeComponent();
        }
        string loaimathang = "Thiet bi IT";
        private void FormThietBiIT_Load(object sender, EventArgs e)
        {
            xlht.LoadDanhSach(loaimathang, flowLPTbIT);
        }
    }
}
