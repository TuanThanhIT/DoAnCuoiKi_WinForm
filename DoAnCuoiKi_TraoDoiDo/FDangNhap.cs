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
using DoAnCuoiKi_TraoDoiDo.DTO;
using System.Security.Cryptography;

namespace DoAnCuoiKi_TraoDoiDo
{
    public partial class FormDangNhap : Form
    {
        List<DangKi> dangKis = new List<DangKi>();
        DangKi dk = new DangKi();
        DangKiBUS dkb = new DangKiBUS();
        string checkcv;
        public FormDangNhap()
        {
            InitializeComponent();
        }
        private string chucvu()
        {
            string cv;
            if (radQuantrivien.Checked == true)
                cv = radQuantrivien.Text;
            else if (radThanhvien.Checked == true)
                cv = radThanhvien.Text;
            else
                cv = "khong co";

            return cv;
        }
        private bool checkDangnhap()
        {
            checkcv = chucvu();
            foreach (DangKi j in dangKis)
            {
                if (j.Tên_đăng_nhập == txtDNTen.Text && j.Mật_khẩu == txtDNPass.Text && checkcv == j.Chức_vụ)
                {
                    dk = j;
                    return true;

                }
            }
            return false;

        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            dangKis = dkb.LoadDSTaiKhoan();
        }

        private void btnDNDangKi_Click_1(object sender, EventArgs e)
        {

            FormDangKi f = new FormDangKi();
            f.Show();
            this.Hide();
        }

        private void btnDNDangnhap_Click_1(object sender, EventArgs e)
        {
            if (checkDangnhap() == true)
            {
                DialogResult result = MessageBox.Show("Chúc mừng bạn đã đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    if(checkcv == "Quan tri vien")
                    {
                        FormTrangChu f = new FormTrangChu(dk);
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                         FormTrangChuThanhVien f = new FormTrangChuThanhVien(dk);
                         f.Show();
                        this.Hide();
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại, vui lòng đăng nhập lại");
            }
        }

        private void hidePass_Click(object sender, EventArgs e)
        {
            if (txtDNPass.PasswordChar == '\0')
            {
                showPass.BringToFront();
                txtDNPass.PasswordChar = '*';
            }
        }

        private void showPass_Click(object sender, EventArgs e)
        {
            if (txtDNPass.PasswordChar == '*')
            {
                hidePass.BringToFront();
                txtDNPass.PasswordChar = '\0';
            }
        }
    }
}
