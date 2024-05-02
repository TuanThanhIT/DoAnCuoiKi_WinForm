using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi_TraoDoiDo.DTO
{
    public class ThanhToan : GioHang
    {
        private string thanhtien;
        public string ThanhTien
        {
            get { return thanhtien; }
            set { thanhtien = value; }
        }

        public ThanhToan(string iD, string maMatHang, string tenMatHang, string loaiMatHang, string giamoi, string hinhAnh, string soLuongMua, string maVoucher, string giamgia, string thanhtien)
        {
            ID = iD;
            Mã_sản_phẩm = maMatHang;
            Tên_mặt_hàng = tenMatHang;
            Loại_mặt_hàng = loaiMatHang;
            Giá_bán = giamoi;
            Hình_ảnh_1 = hinhAnh;
            Soluongchon = soLuongMua;
            Mã_Voucher = maVoucher;
            Giảm_giá = giamgia;
            this.thanhtien = thanhtien;
        }
        public ThanhToan()
        {

        }
        public ThanhToan(string iD, string maMatHang, string tenMatHang, string loaiMatHang, string giamoi, string hinhAnh, string soLuongMua, string maVoucher, string giamgia, string soluongVou, string soluong)
        {
            ID = iD;
            Mã_sản_phẩm = maMatHang;
            Tên_mặt_hàng = tenMatHang;
            Loại_mặt_hàng = loaiMatHang;
            Giá_bán = giamoi;
            Hình_ảnh_1 = hinhAnh;
            Soluongchon = soLuongMua;
            Mã_Voucher = maVoucher;
            Giảm_giá = giamgia;
            Số_lượng_Voucher = soluongVou;
            Số_lượng = soluong;
        }
        public ThanhToan(string thanhtien, string maMatHang)
        {
            this.thanhtien = thanhtien;
            Mã_sản_phẩm = maMatHang;
        }
    }

}


