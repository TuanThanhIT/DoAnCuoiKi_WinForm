using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi_TraoDoiDo
{
    public partial class FormThanhToan : Form
    {
        BanDoDao bdd = new BanDoDao();
        BanDo bando;
        MuaHangDao mhd = new MuaHangDao();
        public FormThanhToan()
        {
            InitializeComponent();
        }
        public FormThanhToan(BanDo bando)
        {
            InitializeComponent();
            this.bando = bando;
            lblTtoanMa.Text = bando.Ma_San_Pham;
            lblTtoanLoai.Text = bando.Loai_Mat_Hang;
            lblTtoanTenMH.Text = bando.Ten_Mat_Hang;
        }
      
        FormTrangChu mainForm;
        public void OpenChildForm(Form childForm)
        {
            mainForm = this.ParentForm as FormTrangChu;

            if (mainForm != null)
            {
                childForm.Dock = DockStyle.Fill;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                mainForm.panelTrangChu.Controls.Clear();
                mainForm.panelTrangChu.Controls.Add(childForm);
                childForm.Show();
            }
        }
        private void btnThanhtoanThoat_Click(object sender, EventArgs e)
        {
            FormTrangChu f = new FormTrangChu();
            f.Show();
            this.Hide();
        }

        private void btnTtoanDathang_Click(object sender, EventArgs e)
        {
            double tongTienThanhToan = tinhTienDonHang();
            string TongTienThanhToan = tongTienThanhToan.ToString();    
            MuaHang mh = new MuaHang(lblTtoanTen.Text, lblTtoanSodt.Text, lblTtoanDiachi.Text, lblThanhToanNgaymua.Text, lblTtoanMa.Text, lblTtoanTenMH.Text, lblTtoanLoai.Text, 
                txtTtoanSLmua.Text, txtTtoanMaVou.Text, lblTtoanGiamgiaVou.Text, lblTtoanGgSukien.Text);
            mhd.ThemMuaHang(mh);

            DialogResult result = MessageBox.Show("Tổng số tiền bạn cần thanh toán là: " + TongTienThanhToan, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(result == DialogResult.OK)
            {
                CapNhatSoLuong();
                FormTrangChu f =new FormTrangChu();
                f.Show();
                this.Hide();
            }    

        }

        private double tinhTienDonHang()
        {
            double tongTien;
            if(lblTtoanGiamgiaVou.Text == "Khong co" && lblTtoanGgSukien.Text == "Khong co")
            {
                tongTien = Convert.ToDouble(bando.Gia_Ban);
            }
            else if(lblTtoanGiamgiaVou.Text != "Khong co" && lblTtoanGgSukien.Text == "Khong co")
            {
                tongTien = Convert.ToDouble(bando.Gia_Ban) * ((double)(Convert.ToDouble(lblTtoanGiamgiaVou.Text) / 100));
            }    
            else if(lblTtoanGiamgiaVou.Text == "Khong co" && lblTtoanGgSukien.Text != "Khong co")
            {
                tongTien = Convert.ToDouble(bando.Gia_Ban) * ((double)(Convert.ToDouble(lblTtoanGgSukien.Text) / 100));
            }
            else
            {
                tongTien = Convert.ToDouble(bando.Gia_Ban) * ((double)(Convert.ToDouble(lblTtoanGiamgiaVou.Text) / 100)) + Convert.ToDouble(bando.Gia_Ban)*((double)(Convert.ToDouble(lblTtoanGgSukien.Text) / 100));
            }
            tongTien = tongTien * Convert.ToInt32(txtTtoanSLmua.Text);
            tongTien = Convert.ToDouble(bando.Gia_Ban) - tongTien;
            return tongTien;
        }

        private void FormThanhToan_Load(object sender, EventArgs e)
        {
            txtTtoanMaVou.Enabled = false;
        }

        private void btnTtoanLuuTT_Click(object sender, EventArgs e)
        {
            lblTtoanTen.Text = txtTtoanHoten.Text;
            lblTtoanSodt.Text = txtTtoanSdt.Text;
            lblTtoanDiachi.Text = txtTtoanDiachi.Text;
            lblThanhToanNgaymua.Text = dateTimeNgaymua.Value.ToString();    
        }

        private void btnTtoanLuuMH_Click(object sender, EventArgs e)
        {
            HienThiVouCher();
            HienThiSuKien();
            
        }
        private void HienThiVouCher()
        {
            if (string.IsNullOrEmpty(txtTtoanMaVou.Text))
            {
                lblTtoanGiamgiaVou.Text = "Khong co";
            }
            else if (bando.Ma_Voucher == txtTtoanMaVou.Text)
            {
                lblTtoanGiamgiaVou.Text = bando.Giam_Gia;
            }
            else
            {
                MessageBox.Show("Mã Voucher bạn nhập cho mặt hàng này ko đúng");
                lblTtoanGiamgiaVou.Text = "Khong co";
            }
        }
        public void CapNhatSoLuong()
        {

            int soLuongMua = Convert.ToInt32(bando.So_Luong) - Convert.ToInt32(txtTtoanSLmua.Text);
            string soluongMua = soLuongMua.ToString();
            if (lblTtoanGiamgiaVou.Text == "Khong co")
            {
                BanDo bd = new BanDo(lblTtoanTenMH.Text, lblTtoanLoai.Text, bando.Gia_Ban, bando.Mo_ta_mat_hang, bando.Ngay_Dang_Ban, bando.Hinh_Anh_1,
                            bando.Hinh_Anh_2, bando.Hinh_Anh_3, bando.Hinh_Anh_4, bando.Ma_Voucher, bando.Giam_Gia, bando.So_Luong_Voucher, soluongMua, bando.Dia_Diem, bando.Phuong_Thuc_Giao_Hang, bando.Tinh_Trang_Mat_Hang, bando.Ma_San_Pham);
                bdd.Sua(bd);

            } 
            else
            {
                int soLuongVou = Convert.ToInt32(bando.So_Luong_Voucher) - 1;
                string soluongVou = soLuongVou.ToString();
                BanDo bd = new BanDo(lblTtoanTenMH.Text, lblTtoanLoai.Text, bando.Gia_Ban, bando.Mo_ta_mat_hang, bando.Ngay_Dang_Ban, bando.Hinh_Anh_1,
                               bando.Hinh_Anh_2, bando.Hinh_Anh_3, bando.Hinh_Anh_4, bando.Ma_Voucher, bando.Giam_Gia, soluongVou, soluongMua, bando.Dia_Diem, bando.Phuong_Thuc_Giao_Hang, bando.Tinh_Trang_Mat_Hang, bando.Ma_San_Pham);
                bdd.Sua(bd);
            }    
        }

        private void HienThiSuKien()
        {
            foreach (SuKien s in XuLySuKien.suKiens)
            {
                string startTimeString = s.BatDau;
                string endTimeString = s.KetThuc;
                string targetTimeString = lblThanhToanNgaymua.Text;

                DateTime startTime;
                DateTime endTime;
                DateTime targetTime;

                if (DateTime.TryParseExact(startTimeString, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out startTime) &&
                    DateTime.TryParseExact(endTimeString, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out endTime) &&
                    DateTime.TryParseExact(targetTimeString, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out targetTime))
                {
                    if (targetTime > startTime && targetTime < endTime)
                    {
                        lblTtoanGgSukien.Text = s.GiamGia;
                    }
                    else
                    {
                        lblTtoanGgSukien.Text = "Không có";
                    }
                }
            }
        }

        private void btnTtoanApdung_Click(object sender, EventArgs e)
        {
            txtTtoanMaVou.Enabled = true;
        }
    }
}
