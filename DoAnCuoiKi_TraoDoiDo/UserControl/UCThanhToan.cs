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
using DoAnCuoiKi_TraoDoiDo.DTO;

namespace DoAnCuoiKi_TraoDoiDo
{
    public partial class UCThanhToan : UserControl
    {
        ThanhToanBUS ttb = new ThanhToanBUS();
        FormBUS fd = new FormBUS();
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
            UCTTlblMa.Text = gh.Mã_sản_phẩm;
            UCTTlblTen.Text = gh.Tên_mặt_hàng;
            UCTTLoai.Text = gh.Loại_mặt_hàng;
            UCTTGiaBan.Text = gh.Giá_bán;
            UCTTSoluong.Text = gh.Soluongchon;
            string path = gh.Hình_ảnh_1;
            UCTTpicture.Image = Image.FromFile(path);
        }
        private void UCThanhToan_Load(object sender, EventArgs e)
        {
            double thanhtien = Convert.ToDouble(gh.Giá_bán) * Convert.ToInt32(gh.Soluongchon);
            UCTTThanhTien.Text = thanhtien.ToString();
            ThanhToan tt = new ThanhToan(gh.ID, gh.Mã_sản_phẩm, gh.Tên_mặt_hàng, gh.Loại_mặt_hàng, gh.Giá_bán, gh.Hình_ảnh_1, gh.Soluongchon, gh.Mã_Voucher, gh.Giảm_giá, thanhtien.ToString());
            ttb.ThemThanhToan(tt);
            soluong = Convert.ToInt32(gh.Số_lượng) - Convert.ToInt32(gh.Soluongchon);
            BanDo bd = new BanDo(gh.Số_lượng_Voucher, soluong.ToString(), gh.Mã_sản_phẩm);
            bdb.SuaMatHang1(bd);
            GioHang ghh = new GioHang(soluong.ToString(), gh.Mã_sản_phẩm);
            ghb.SuaGH(ghh);
        }


    
        private void UCTTbtnApMa_Click_1(object sender, EventArgs e)
        {
            if (gh.Mã_Voucher == "Khong co")
            {
                MessageBox.Show("Mặt hàng này của bạn ko có mã giảm giá", "Thông báo");
                UCTTThanhTien.Text = ttb.tinhTien(UCTTSoluong.Text, UCTTGiaBan.Text).ToString();
            }
            else
            {
                if (UCTTtxtMaVou.Text == gh.Mã_Voucher)
                {
                    UCTTThanhTien.Text = ttb.tinhTienMa(UCTTSoluong.Text, UCTTGiaBan.Text, gh.Giảm_giá).ToString();
                    ThanhToan tt = new ThanhToan(UCTTThanhTien.Text, UCTTlblMa.Text);
                    ttb.SuaThanhToan(tt);
                    MessageBox.Show("Áp mã giảm giá thành công", "Thông báo");
                    soluongVou = Convert.ToInt32(gh.Số_lượng_Voucher) - 1;
                    BanDo bd = new BanDo(soluongVou.ToString(), soluong.ToString(), gh.Mã_sản_phẩm);
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
