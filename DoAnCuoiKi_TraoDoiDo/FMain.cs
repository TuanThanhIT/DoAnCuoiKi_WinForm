using DoAnCuoiKi_TraoDoiDo.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi_TraoDoiDo
{
    public partial class FormMain : Form
    {
        SuKienBUS skb = new SuKienBUS();
        BanDoBUS bds = new BanDoBUS();
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            skb.LoadSukien(flowLPMainSukien, txtSuKien);
            bds.LoadDSVou(flowLPMainVoucher, txtVoucher);
        }

        private void txtSuKien_TextChanged(object sender, EventArgs e)
        {
            skb.LoadSukien(flowLPMainSukien, txtSuKien);
        }

        private void txtVoucher_TextChanged(object sender, EventArgs e)
        {
            bds.LoadDSVou(flowLPMainVoucher, txtVoucher);
        }
    }
}

