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
    public partial class FormThietBiIT : Form
    {
        BanDoBUS bdb = new BanDoBUS();
        public FormThietBiIT()
        {
            InitializeComponent();
        }
        string loaimathang = "Thiet bi IT";
        private void FormThietBiIT_Load(object sender, EventArgs e)
        {
            bdb.LoadDanhSach(loaimathang, flowLPTbIT, txtTimKiem);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            bdb.LoadDSSapXep(loaimathang, flowLPTbIT, comBoSapxep);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            FormThietBiIT_Load(sender, e);
        }

        private void flowLPTbIT_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
