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
    public partial class FormGiay : Form
    {
        BanDoBUS bdb = new BanDoBUS();
        public FormGiay()
        {
            InitializeComponent();
        }
        string loaimathang = "Giay";
        private void FormGiay_Load(object sender, EventArgs e)
        {
            bdb.LoadDanhSach(loaimathang, flowLPGiay, txtTimKiem);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            bdb.LoadDSSapXep(loaimathang, flowLPGiay, comBoSapxep);
        }
    }
}
