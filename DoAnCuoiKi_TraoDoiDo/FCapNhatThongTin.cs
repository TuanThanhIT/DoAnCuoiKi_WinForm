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
    public partial class FormCapNhatThongTin : Form
    {
        DangKi dk;
        BanDoBUS bdb = new BanDoBUS();
        DangKiBUS dkb = new DangKiBUS();
        string ngay;
        FormBUS fd = new FormBUS();

        public FormCapNhatThongTin(DangKi dk)
        {
            InitializeComponent();
            this.dk = dk;
            txtID.Text = dk.ID;
            txtDkHoten.Text = dk.Họ_tên;
            txtDkDiachi.Text = dk.Địa_chỉ;
            txtDkSoDt.Text = dk.Số_điện_thoại;
            txtDkDichiE.Text = dk.Địa_chỉ_Email;
            cmBoxGioitinh.Text = dk.Giới_tính;
            ngay = dk.Ngày_tháng_năm_sinh;
        }

        private void FormCapNhatThongTin_Load(object sender, EventArgs e)
        {
            bdb.ngayDangBan(dateTPNamSinh, ngay);
        }
        DangKi dkk;
        private void txtLuu_Click(object sender, EventArgs e)
        {
            dkk = new DangKi(txtID.Text,txtDkHoten.Text, dateTPNamSinh.Value.ToShortDateString(), cmBoxGioitinh.Text, txtDkDichiE.Text, txtDkSoDt.Text, txtDkDiachi.Text, dk.Ngày_đăng_kí, dk.Tên_đăng_nhập, dk.Mật_khẩu, dk.Chức_vụ);
            if(dkb.Sua(dkk) == true)
            {
                MessageBox.Show("Thông tin cá nhân đc thay đổi thành công");
            }
            else
            {
                MessageBox.Show("Lỗi. Không sửa được");
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
    }
}
