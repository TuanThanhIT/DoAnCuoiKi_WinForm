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
    public partial class FormDoiMatKhau : Form
    {
        DangKi dk;
        DangKiBUS dkb = new DangKiBUS();
        FormBUS fd = new FormBUS();

        public FormDoiMatKhau(DangKi dk)
        {
            InitializeComponent();
            this.dk = dk;
            txtDKMatKhau.Text = dk.Mật_khẩu;
        }

        private void FormDoiMatKhau_Load(object sender, EventArgs e)
        {

        }
        DangKi dkk;
        private void txtLuu_Click(object sender, EventArgs e)
        {
            if (txtXacNhan.Text == txtMatKhauMoi.Text)
            {
                dkk = new DangKi(dk.ID, dk.Họ_tên, dk.Ngày_tháng_năm_sinh, dk.Giới_tính, dk.Địa_chỉ_Email, dk.Số_điện_thoại, dk.Địa_chỉ, dk.Ngày_đăng_kí, dk.Tên_đăng_nhập, txtMatKhauMoi.Text, dk.Chức_vụ);
                if (dkb.Sua(dkk) == true)
                {
                    MessageBox.Show("Mật khẩu của bạn đã được thay đổi");
                }
                else
                {
                    MessageBox.Show("Lỗi. Không thay đổi được");
                }
            }
            else
            {
                MessageBox.Show("Xác nhận mật khẩu mới không đúng");
            }
        }

        private void txtThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            if (DangKiDAO.Chuc_vu == "Quan tri vien")
            {
                fd.OpenChildForm(new FormTaiKhoan(dkk), FormTrangChu.panelTrangChu);
                FormTrangChu.lblChude.Text = "Thông tin tài khoản";
            }
            else
            {
                fd.OpenChildForm(new FormTaiKhoan(dkk), FormTrangChuThanhVien.panelTVTrangChu);
                FormTrangChuThanhVien.lblTVChude.Text = "Thông tin tài khoản";
            }
        }

        private void showPass_Click(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.PasswordChar == '*')
            {
                hidePass.BringToFront();
                txtMatKhauMoi.PasswordChar = '\0';
            }
        }

        private void hidePass_Click(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.PasswordChar == '\0')
            {
                showPass.BringToFront();
                txtMatKhauMoi.PasswordChar = '*';
            }
        }
    }
}
