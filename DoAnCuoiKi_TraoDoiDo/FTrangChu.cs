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
        FormBUS fd = new FormBUS();
        DangKi dk;
        public FormTrangChu(DangKi dk)
        {
            InitializeComponent();
            this.dk = dk;
            lblTrangchuTen.Text = dk.Tên_đăng_nhập;
            lblTrangChuChucvu.Text = dk.Chức_vụ;
            lblTrangChuID.Text = dk.ID;
            DangKiDAO.ID = lblTrangChuID.Text;
            DangKiDAO.Ten_nguoi_dung = lblTrangchuTen.Text;
            DangKiDAO.Chuc_vu = lblTrangChuChucvu.Text;
        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormMain(), panelTrangChu);
            lblChude.Text = "Trang Chủ";
        }

        private void dateTimePickerTrangchu_ValueChanged_1(object sender, EventArgs e)
        {
            dateTimePickerTrangchu.Value = DateTime.Now;
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormMain(), panelTrangChu);
            lblChude.Text = "Trang Chủ";
        }

        private void btnBanDo_Click(object sender, EventArgs e)
        {
            BanDoBUS.checkButton = true;
            fd.OpenChildForm(new FormBanDo(), panelTrangChu);
            lblChude.Text = "Bán Hàng";
        }

        private void btnMatHang_Click_1(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormMatHang(), panelTrangChu);
            lblChude.Text = "Mặt Hàng";
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormThongKe(), panelTrangChu);
            lblChude.Text = "Thống Kê";
        }

        private void btnLichSu_Click_1(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormLichSu(), panelTrangChu);
            lblChude.Text = "Lịch sử";
        }

        private void btnGioHang_Click_1(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormGioHang(), panelTrangChu);
            lblChude.Text = "Giỏ hàng";
        }

        private void btnSuKien_Click_1(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormSuKien(), panelTrangChu);
            lblChude.Text = "Sự kiện";
        }

        private void btnOut_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                FormDangNhap f = new FormDangNhap();
                f.Show();
                this.Hide();
            }
            
        }


        private void btnThongTinCaNha_Click(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormTaiKhoan(dk), panelTrangChu);
            lblChude.Text = "Thông tin tài khoản";
        }
    }
}
