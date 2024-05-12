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
    public partial class FormNoiThat : Form
    {
        BanDoBUS bdb = new BanDoBUS();
        public FormNoiThat()
        {
            InitializeComponent();
        }
        string loaimathang = "Noi that";
        private void FormNoiThat_Load(object sender, EventArgs e)
        {
            bdb.LoadDanhSach(loaimathang, flowLPNoithat, txtTimKiem);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            FormNoiThat_Load(sender, e);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            bdb.LoadDSSapXep(loaimathang, flowLPNoithat, comBoSapxep);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
