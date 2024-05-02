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
    public partial class FormDienThoai : Form
    {
        BanDoBUS bdb = new BanDoBUS();
        public FormDienThoai()
        {
            InitializeComponent();
        }
        string loaimathang = "Dien thoai";
        private void FormDienThoai_Load(object sender, EventArgs e)
        {
           bdb.LoadDanhSach(loaimathang, flowLPDienthoai, txtTimKiem);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            bdb.LoadDSSapXep(loaimathang, flowLPDienthoai, comBoSapxep);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            FormDienThoai_Load(sender, e);  
        }
    }
}

