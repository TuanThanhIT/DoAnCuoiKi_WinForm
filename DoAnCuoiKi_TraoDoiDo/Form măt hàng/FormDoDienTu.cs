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
           bds.LoadDanhSach(loaimathang, flowLPDodientu, txtTimKiem);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            bds.LoadDSSapXep(loaimathang, flowLPDodientu, comBoSapxep);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            FormDoDienTu_Load(sender, e);   
        }
    }
}

