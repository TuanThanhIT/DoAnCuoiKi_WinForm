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
        DBConnection db = new DBConnection();
        SuKienBUS skb = new SuKienBUS();
        BanDoBUS bds = new BanDoBUS();
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            skb.LoadSukien(flowLPMainSukien);
            bds.LoadDSVou(flowLPMainVoucher);
        }

    }
}

