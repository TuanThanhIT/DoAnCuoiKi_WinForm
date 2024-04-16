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
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
        }
        FormDao fd = new FormDao();
        public FormTrangChu(DangKi dk)
        {
            InitializeComponent();
            lblTrangchuTen.Text = dk.Tendangnhap;
            lblTrangChuChucvu.Text = dk.Chucvu;
            lblTrangChuID.Text = dk.ID;
        }
       

        private void FormTrangChu_Load_1(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormMain(), ref FormDao.activeForm, panelTrangChu);
            lblChude.Text = "Trang Chủ";
            XuLyHienThi.Ten_Nguoi_Dung = lblTrangchuTen.Text;
            XuLyHienThi.ID = lblTrangChuID.Text;
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormMain(), ref FormDao.activeForm, panelTrangChu);
            lblChude.Text = "Trang Chủ";
        }

        private void btnBanDo_Click(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormBanDo(), ref FormDao.activeForm, panelTrangChu);
            lblChude.Text = "Bán Hàng";
        }

        private void btnMatHang_Click_1(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormMatHang(), ref FormDao.activeForm, panelTrangChu);
            lblChude.Text = "Mặt Hàng";
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormThongKe(), ref FormDao.activeForm, panelTrangChu);
            lblChude.Text = "Thống Kê";
        }

        private void btnLichsu_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn xem: Chọn Yes để xem lịch sử bán, No để xem lịch sử mua, hoặc Cancel để thoát", "Thông Báo",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                fd.OpenChildForm(new FormLsBanHang(), ref FormDao.activeForm, panelTrangChu); ;
                lblChude.Text = "Lịch Sử";
            }
            else if (result == DialogResult.No)
            {
                fd.OpenChildForm(new FormLSMuaHang(), ref FormDao.activeForm, panelTrangChu);
                lblChude.Text = "Lịch Sử";
            }
        }

        private void btnMylichsu_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnGioHang_Click_1(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormGioHang(), ref FormDao.activeForm, panelTrangChu);
            lblChude.Text = "Giỏ hàng";
        }

        private void dateTimePickerTrangchu_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerTrangchu.Value = DateTime.Now;
        }

       

        

        private void button1_Click(object sender, EventArgs e)
        {
            FormDangNhap f = new FormDangNhap();
            f.Show();
            this.Hide();
        }

        private void btnTrangChuSuKien_Click(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormGioHang(), ref FormDao.activeForm, panelTrangChu);
            lblChude.Text = "Sự kiện";
        }

        
    }
}
