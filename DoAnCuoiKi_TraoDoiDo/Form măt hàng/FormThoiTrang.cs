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
    public partial class FormThoiTrang : Form
    {
        BanDoBUS bdb = new BanDoBUS();
        public FormThoiTrang()
        {
            InitializeComponent();
        }
        string loaimathang = "Thoi trang";
        private void FormThoiTrang_Load(object sender, EventArgs e)
        {
            bdb.LoadDanhSach(loaimathang, flowLPThoitrang, txtTimKiem);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            bdb.LoadDSSapXep(loaimathang, flowLPThoitrang, comBoSapxep);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            FormThoiTrang_Load(sender, e);  
        }
    }
}

