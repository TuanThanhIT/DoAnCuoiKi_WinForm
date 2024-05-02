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
    public partial class FormDoGiaDung : Form
    {
        BanDoBUS bdb = new BanDoBUS();
        public FormDoGiaDung()
        {
            InitializeComponent();
        }
        string loaimathang = "Do gia dung";
        private void FormDoGiaDung_Load(object sender, EventArgs e)
        {
            bdb.LoadDanhSach(loaimathang, flowLPDogiadung, txtTimKiem);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            bdb.LoadDSSapXep(loaimathang, flowLPDogiadung, comBoSapxep);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            FormDoGiaDung_Load(sender, e);
        }
    }
}

