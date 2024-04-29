using DoAnCuoiKi_TraoDoiDo.BUS;
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
    public partial class UCThanhToan : UserControl
    {
        ThanhToanBUS ttb = new ThanhToanBUS();
        FormDAO fd = new FormDAO();
        BanDoBUS bdb = new BanDoBUS();
        GioHangBUS ghb = new GioHangBUS();
        public UCThanhToan()
        {
            InitializeComponent();
        }
        ThanhToan gh;
        int soluong;
        int soluongVou;
        public UCThanhToan(ThanhToan gh)
        {
            InitializeComponent();
            this.gh = gh;
            UCTTlblMa.Text = gh.Ma_San_Pham;
            UCTTlblTen.Text = gh.Ten_Mat_Hang;
            UCTTLoai.Text = gh.Loai_Mat_Hang;
            UCTTGiaBan.Text = gh.Gia_Ban;
            UCTTSoluong.Text = gh.Soluongchon;
            string path = gh.Hinh_Anh_1;
            UCTTpicture.Image = Image.FromFile(path);
        }
        private void UCThanhToan_Load(object sender, EventArgs e)
        {
            double thanhtien = Convert.ToDouble(gh.Gia_Ban) * Convert.ToInt32(gh.Soluongchon);
            UCTTThanhTien.Text = thanhtien.ToString();
            ThanhToan tt = new ThanhToan(gh.ID, gh.Ma_San_Pham, gh.Ten_Mat_Hang, gh.Loai_Mat_Hang, gh.Gia_Ban, gh.Hinh_Anh_1, gh.Soluongchon, gh.Ma_Voucher, gh.Giam_Gia, thanhtien.ToString());
            ttb.ThemThanhToan(tt);
            soluong = Convert.ToInt32(gh.So_Luong) - Convert.ToInt32(gh.Soluongchon);
            BanDo bd = new BanDo(gh.So_Luong_Voucher, soluong.ToString(), gh.Ma_San_Pham);
            bdb.SuaMatHang1(bd);
            GioHang ghh = new GioHang(soluong.ToString(), gh.Ma_San_Pham);
            ghb.SuaGH(ghh);
        }


    
        private void UCTTbtnApMa_Click_1(object sender, EventArgs e)
        {
            if (gh.Ma_Voucher == "Khong co")
            {
                MessageBox.Show("Mặt hàng này của bạn ko có mã giảm giá", "Thông báo");
                UCTTThanhTien.Text = ttb.tinhTien(UCTTSoluong.Text, UCTTGiaBan.Text).ToString();
            }
            else
            {
                if (UCTTtxtMaVou.Text == gh.Ma_Voucher)
                {
                    UCTTThanhTien.Text = ttb.tinhTienMa(UCTTSoluong.Text, UCTTGiaBan.Text, gh.Giam_Gia).ToString();
                    ThanhToan tt = new ThanhToan(UCTTThanhTien.Text, UCTTlblMa.Text);
                    ttb.SuaThanhToan(tt);
                    MessageBox.Show("Áp mã giảm giá thành công", "Thông báo");
                    soluongVou = Convert.ToInt32(gh.So_Luong_Voucher) - 1;
                    BanDo bd = new BanDo(soluongVou.ToString(), soluong.ToString(), gh.Ma_San_Pham);
                    bdb.SuaMatHang1(bd);


                }
                else
                {
                    MessageBox.Show("Mã giảm giá của bạn ko đúng, vui lòng nhập lại", "Thông báo");
                }
            }
        }
    }
}
