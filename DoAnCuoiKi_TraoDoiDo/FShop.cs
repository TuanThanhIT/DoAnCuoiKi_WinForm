using DoAnCuoiKi_TraoDoiDo.BUS;
using DoAnCuoiKi_TraoDoiDo.DTO;
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
    public partial class FormShop : Form
    {
        DangKiBUS dkb = new DangKiBUS();
        BanDoBUS bds = new BanDoBUS();
        string iD;
        public FormShop()
        {
            InitializeComponent();

        }
        public FormShop(BanDo bd)
        {
            InitializeComponent();
            iD = bd.ID;
            lblID.Text = iD;
            DangKi dk = dkb.LoadThongTin(iD);
            lblTen.Text = dk.Họ_tên;
            lblDiaChi.Text = dk.Địa_chỉ;
            lblSodt.Text = dk.Số_điện_thoại;
            lblEmail.Text = dk.Địa_chỉ_Email;

        }

       

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            FormShop_Load(sender, e);
        }

        private void FormShop_Load(object sender, EventArgs e)
        {
            bds.LoadDSSanPhamShop(iD, flowLPSanPham, txtTimKiem);
        }
    }
}
