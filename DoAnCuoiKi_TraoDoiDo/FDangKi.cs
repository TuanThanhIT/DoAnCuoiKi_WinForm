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
        DangKiDao dkd = new DangKiDao();
        public FormDangKi()
        {
            InitializeComponent();
        }
        string maQuanTriVien = "TTKH";
        public string RandomMaID()
        {
            const int doDaiMaID = 7;
            const string kyTuDung = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            // Tạo một HashSet để lưu trữ các mã ID đã được sử dụng
            HashSet<string> maIDDaSuDung = new HashSet<string>();

            // Tạo một đối tượng Random
            Random random = new Random();

            // Tạo lặp cho đến khi tạo được mã ID mới
            while (true)
            {
                // Tạo một StringBuilder để xây dựng mã ID
                var stringBuilder = new System.Text.StringBuilder();

                // Tạo mã ID mới
                for (int i = 0; i < doDaiMaID; i++)
                {
                    char kyTuNgauNhien = kyTuDung[random.Next(kyTuDung.Length)];
                    stringBuilder.Append(kyTuNgauNhien);
                }

                string maIDMoi = stringBuilder.ToString();

                // Kiểm tra xem mã ID đã được sử dụng chưa
                if (!maIDDaSuDung.Contains(maIDMoi))
                {
                    maIDDaSuDung.Add(maIDMoi);
                    return maIDMoi;
                }
            }
        }
        
        private void btnDKDangki_Click(object sender, EventArgs e)
        {
            if(txtDkXacnhanMK.Text == txtDKMatKhau.Text )
            {
                if(cbBoxChucvu.Text == "Quan tri vien")
                {
                    if (txtDkMaXacnhan.Text == maQuanTriVien)
                    {
                        DangKi dk = new DangKi(RandomMaID(), txtDkHoten.Text, dateTPNamSinh.Value.ToString(), cmBoxGioitinh.Text, txtDkDichiE.Text, txtDkSoDt.Text, txtDkDiachi.Text,
                                                dateTPNgayDangki.Value.ToString(), txtDkTenDangnhap.Text, txtDKMatKhau.Text, cbBoxChucvu.Text);
                        dkd.ThemThanhVien(dk);
                    }
                    else
                    {
                        MessageBox.Show("Mã xác nhận quản trị viên không đúng, vui lòng nhập lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }    
                }
                else
                {
                    DangKi dk = new DangKi(RandomMaID(), txtDkHoten.Text, dateTPNamSinh.Value.ToString(), cmBoxGioitinh.Text, txtDkDichiE.Text, txtDkSoDt.Text, txtDkDiachi.Text,
                                                dateTPNgayDangki.Value.ToString(), txtDkTenDangnhap.Text, txtDKMatKhau.Text, cbBoxChucvu.Text);
                    dkd.ThemThanhVien(dk);
                }
            }    
        }

        private void FormDangKi_Load(object sender, EventArgs e)
        {
            dateTPNgayDangki.Enabled = false;
        }

        private void btnDkThoat_Click(object sender, EventArgs e)
        {
            FormDangNhap f = new FormDangNhap();
            f.Show();
            this.Hide();
        }
    }
}
