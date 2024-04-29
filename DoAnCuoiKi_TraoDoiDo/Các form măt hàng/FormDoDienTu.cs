using DoAnCuoiKi_TraoDoiDo.BUS;
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
        BanDoBUS bds = new BanDoBUS();
        public FormDoDienTu()
        {
            InitializeComponent();
        }
        string loaimathang = "Do dien tu";
        private void FormDoDienTu_Load(object sender, EventArgs e)
        {
            bds.LoadDanhSach(loaimathang, flowLPDodientu);
        }
    }
}

