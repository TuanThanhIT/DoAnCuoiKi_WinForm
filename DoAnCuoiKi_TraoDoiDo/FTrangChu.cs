using DoAnCuoiKi_TraoDoiDo.BUS;
using DoAnCuoiKi_TraoDoiDo.DTO;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAnCuoiKi_TraoDoiDo
{
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
        }
        FormDAO fd = new FormDAO();
        public FormTrangChu(DangKi dk)
        {
            InitializeComponent();
            lblTrangchuTen.Text = dk.Tendangnhap;
            lblTrangChuChucvu.Text = dk.Chucvu;
            lblTrangChuID.Text = dk.ID;
            DangKiDAO.ID = lblTrangChuID.Text;
            DangKiDAO.Ten_nguoi_dung = lblTrangchuTen.Text;
            DangKiDAO.Chuc_vu = lblTrangChuChucvu.Text;
            DangKiDAO.Ho_ten = dk.Hoten;
            DangKiDAO.Dia_chi = dk.Diachi;
            DangKiDAO.So_dt = dk.Sodt;
        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormMain(), ref FormDAO.activeForm, panelTrangChu);
            lblChude.Text = "Trang Chủ";
        }

        private void dateTimePickerTrangchu_ValueChanged_1(object sender, EventArgs e)
        {
            dateTimePickerTrangchu.Value = DateTime.Now;
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormMain(), ref FormDAO.activeForm, panelTrangChu);
            lblChude.Text = "Trang Chủ";
        }

        private void btnBanDo_Click(object sender, EventArgs e)
        {
            BanDoBUS.checkButton = true;
            fd.OpenChildForm(new FormBanDo(), ref FormDAO.activeForm, panelTrangChu);
            lblChude.Text = "Bán Hàng";
        }

        private void btnMatHang_Click_1(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormMatHang(), ref FormDAO.activeForm, panelTrangChu);
            lblChude.Text = "Mặt Hàng";
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormThongKe(), ref FormDAO.activeForm, panelTrangChu);
            lblChude.Text = "Thống Kê";
        }

        private void btnLichSu_Click_1(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormLichSu(), ref FormDAO.activeForm, panelTrangChu);
            lblChude.Text = "Lịch sử";
        }

        private void btnGioHang_Click_1(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormGioHang(), ref FormDAO.activeForm, panelTrangChu);
            lblChude.Text = "Giỏ hàng";
        }

        private void btnSuKien_Click_1(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormSuKien(), ref FormDAO.activeForm, panelTrangChu);
            lblChude.Text = "Sự kiện";
        }

        private void btnOut_Click_1(object sender, EventArgs e)
        {
            FormDangNhap f = new FormDangNhap();
            f.Show();
            this.Hide();
        }

       

        
    }
}
