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
    public partial class FormTaiKhoan : Form
    {
        DangKi dk;
        public FormTaiKhoan(DangKi dk)
        {
            InitializeComponent();
            this.dk = dk;   
            txtTen.Text = dk.Họ_tên;
            txtGioitinh.Text = dk.Giới_tính;
            txtDiaChi.Text = dk.Địa_chỉ;
            txtEmail.Text = dk.Địa_chỉ_Email;
            txtSodt.Text = dk.Số_điện_thoại;
            txtNgaySinh.Text = dk.Ngày_tháng_năm_sinh;
            txtTenDangNhap.Text = dk.Tên_đăng_nhập;
            txtMatkhau.Text = dk.Mật_khẩu;
        }

        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FormCapNhatThongTin f = new FormCapNhatThongTin(dk);
            f.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FormDoiMatKhau f = new FormDoiMatKhau(dk);
            f.Show();
        }

        private void HidePass_Click(object sender, EventArgs e)
        {
            if (txtMatkhau.PasswordChar == '\0')
            {
                ShowPass.BringToFront();
                txtMatkhau.PasswordChar = '*';
            }
        }

        private void ShowPass_Click(object sender, EventArgs e)
        {
            if (txtMatkhau.PasswordChar == '*')
            {
                HidePass.BringToFront();
                txtMatkhau.PasswordChar = '\0';
            }
        }
    }
}
