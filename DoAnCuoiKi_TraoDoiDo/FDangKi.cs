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
    public partial class FormDangKi : Form
    {
        DangKiBUS dkb = new DangKiBUS();
        public FormDangKi()
        {
            InitializeComponent();
        }

        private void FormDangKi_Load(object sender, EventArgs e)
        {
            dateTPNgayDangki.Enabled = false;
        }


        private void btnDKDangKi_Click(object sender, EventArgs e)
        {
            if (txtDkXacnhanMK.Text == txtDKMatKhau.Text)
            {
                if (cbBoxChucvu.Text == "Quan tri vien")
                {
                    if (txtDkMaXacnhan.Text == dkb.maQuanTriVien)
                    {
                        DangKi dk = new DangKi(dkb.RandomMaID(), txtDkHoten.Text, dateTPNamSinh.Value.ToString(), cmBoxGioitinh.Text, txtDkDichiE.Text, txtDkSoDt.Text, txtDkDiachi.Text,
                                                dateTPNgayDangki.Value.ToString(), txtDkTenDangnhap.Text, txtDKMatKhau.Text, cbBoxChucvu.Text);
                        if (dkb.ThemThanhVien(dk) == true)
                        {
                            MessageBox.Show("Đăng kí tài khoản quản trị viên thành công");
                            FormDangNhap f = new FormDangNhap();
                            f.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Đăng kí không thành công");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã xác nhận quản trị viên không đúng, vui lòng nhập lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    DangKi dk = new DangKi(dkb.RandomMaID(), txtDkHoten.Text, dateTPNamSinh.Value.ToString(), cmBoxGioitinh.Text, txtDkDichiE.Text, txtDkSoDt.Text, txtDkDiachi.Text,
                                                dateTPNgayDangki.Value.ToString(), txtDkTenDangnhap.Text, txtDKMatKhau.Text, cbBoxChucvu.Text);
                    if (dkb.ThemThanhVien(dk) == true)
                    {
                        MessageBox.Show("Đăng kí tài khoản thành viên thành công");
                        FormDangNhap f = new FormDangNhap();
                        f.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Đăng kí không thành công");
                    }
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu nhập lại không đúng vui lòng kiểm tra lại");
            }
        }

        private void btnDkThoat_Click(object sender, EventArgs e)
        {
            FormDangNhap f = new FormDangNhap();
            f.Show();
            this.Hide();
        }
    }
}
